/*
Copyright 2023 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Globalization;

namespace Google.Apis.Util;

/// <summary>
/// Utility methods to convert to/from Discovery API formats.
/// See https://developers.google.com/discovery/v1/type-format
/// </summary>
/// <remarks>
/// Methods starting "Parse" are for parsing the Discovery format to a .NET type.
/// Methods starting "Format" are for formatting .NET types to Discovery formats.
/// This class does not provide methods for <see cref="DateTime" /> and <see cref="object"/>
/// conversions; properties with a type of DateTime or object are marked as obsolete in the generated code,
/// and have legacy behavior which cannot reasonably be changed for backward compatibility reasons.
/// </remarks>
public static class DiscoveryFormat
{
    private static readonly char[] OffsetLeaders = { 'Z', '-', '+' };

    // Design note 1: none of the public methods call each other, to make it easier to modify
    // behavior in the future.

    // Design note 2: there's a lot of substring use in here. It would be nice to be span-based,
    // or otherwise avoid creating string garbage, but simplicity is more important than performance
    // for this code (at least until we hear otherwise).

    /// <summary>
    /// Parses a Discovery "date-time" format value to <see cref="DateTimeOffset"/>.
    /// The value must start in the format "yyyy-MM-ddTHH:mm:ss", with optional milliseconds,
    /// microseconds and nanoseconds. A UTC offset may be provided with up to second precision
    /// (e.g. +01, -02:30, +03:45:12), or "Z" for UTC. If nanosecond precision is provided,
    /// the value is truncated to .NET "tick" precision (100ns). If the UTC offset has a non-zero
    /// seconds component, a value is returned which preserves the instant in time, but truncates
    /// the UTC offset to the minute.
    /// </summary>
    public static DateTimeOffset? ParseDateTimeToDateTimeOffset(string value)
    {
        if (value is null)
        {
            return null;
        }
        int offsetIndex = value.LastIndexOfAny(OffsetLeaders);
        if (offsetIndex == -1)
        {
            ThrowFormatException();
        }
        string localPart = value.Substring(0, offsetIndex);
        string offsetPart = value.Substring(offsetIndex);
        var local = ParseLocalDateTime(localPart);
        var offset = ParseUtcOffset(offsetPart);
        // DateTimeOffset doesn't support UTC offsets with a non-zero second component.
        // The closest we can come is to preserve the instant in time, and truncate the
        // offset to the minute (towards zero).
        if (offset.Seconds != 0)
        {
            local = local.AddSeconds(-offset.Seconds);
            offset = new TimeSpan(offset.Hours, offset.Minutes, 0);
        }
        return new DateTimeOffset(local, offset);        
    }

    /// <summary>
    /// Parses a Discovery "google-datetime" format value to <see cref="DateTimeOffset"/>.
    /// The value must start in the format "yyyy-MM-ddTHH:mm:ss", with optional milliseconds,
    /// microseconds and nanoseconds, and a trailing 'Z' to indicate UTC.
    /// </summary>
    public static DateTimeOffset? ParseGoogleDateTimeToDateTimeOffset(string value)
    {
        if (value is null)
        {
            return null;
        }
        if (!value.EndsWith("Z", StringComparison.Ordinal))
        {
            ThrowFormatException();
        }
        var local = ParseLocalDateTime(value.Substring(0, value.Length - 1));
        return new DateTimeOffset(local, TimeSpan.Zero);
    }

    /// <summary>
    /// Formats a <see cref="DateTime"/> value appropriately for a Discovery "date-time" value.
    /// This does not automatically convert the given value to UTC; some services require values
    /// to be presented in UTC, in which case user code should ensure that only UTC values are
    /// specified.
    /// </summary>
    public static string FormatDateTimeOffsetToDateTime(DateTimeOffset? value) =>
        FormatDateTimeOffsetImpl(value);

    /// <summary>
    /// Formats a <see cref="DateTime"/> value appropriately for a Discovery "google-datetime" value.
    /// This automatically converts the given value to UTC before formatting.
    /// </summary>
    public static string FormatDateTimeOffsetToGoogleDateTime(DateTimeOffset? value) =>
        FormatDateTimeOffsetImpl(value?.ToUniversalTime());

    // Implementation methods

    /// <summary>
    /// Parses the "local" part of a date-time/google-datetime value. This is expected to be in the format
    /// yyyy-MM-ddTHH:mm:ss with optional millisecond, microsecond or nanosecond precision.
    /// The returned DateTime has a Kind of Unspecified.
    /// </summary>
    private static DateTime ParseLocalDateTime(string value)
    {
        // Date part is 10 characters; time to seconds is 8.
        // We need to take account of the "T" separator, the decimal separator for subseconds.
        const int SecondsOnlyLength = 19;
        const int MillisecondsLength = SecondsOnlyLength + 4;
        const int MicrosecondsLength = MillisecondsLength + 3;
        const int NanosecondsLength = MicrosecondsLength + 3;
        const int NanosecondsBeyondTicksIndex = NanosecondsLength - 2;

        return value.Length switch
        {
            SecondsOnlyLength => DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture),
            MillisecondsLength => DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss.fff", CultureInfo.InvariantCulture),
            MicrosecondsLength => DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss.ffffff", CultureInfo.InvariantCulture),
            // Note: deliberately no Z here.
            NanosecondsLength => DateTime.ParseExact(AdjustForNanoseconds(value), "yyyy-MM-dd'T'HH:mm:ss.fffffff", CultureInfo.InvariantCulture),
            _ => ThrowFormatException<DateTime>()
        };

        // If we receive "2023-10-2713:45:00.123456789" we need to parse it
        // as "2023-10-2713:45:00.1234567" (i.e. to tick precision) as .NET doesn't support
        // parsing and automatically truncating nanoseconds.
        static string AdjustForNanoseconds(string value)
        {
            ValidateDigit(value[NanosecondsBeyondTicksIndex]);
            ValidateDigit(value[NanosecondsBeyondTicksIndex + 1]);
            return value.Substring(0, NanosecondsBeyondTicksIndex);
        }

        static void ValidateDigit(char c)
        {
            if (c < '0' || c > '9')
            {
                ThrowFormatException();
            }
        }
    }

    private static string FormatDateTimeOffsetImpl(DateTimeOffset? value)
    {
        if (value is not DateTimeOffset dto)
        {
            return null;
        }

        const int TicksPerMicrosecond = 10;
        // Note: DateTimeOffset.Ticks is always non-negative, which makes things simpler.
        long tickOfSecond = dto.Ticks % TimeSpan.TicksPerSecond;
        string pattern = tickOfSecond switch
        {
            0 => "yyyy-MM-dd'T'HH:mm:ss",
            _ when tickOfSecond % TimeSpan.TicksPerMillisecond == 0 => "yyyy-MM-dd'T'HH:mm:ss.fff",
            _ when tickOfSecond % TicksPerMicrosecond == 0 => "yyyy-MM-dd'T'HH:mm:ss.ffffff",
            _ => "yyyy-MM-dd'T'HH:mm:ss.fffffff'00'"
        };
        var localPart = dto.DateTime.ToString(pattern, CultureInfo.InvariantCulture);
        return localPart + FormatOffset(dto.Offset);

        static string FormatOffset(TimeSpan offset)
        {
            // Note: DateTimeOffset doesn't allow for an offset of more than a day, so we don't need to worry about that.
            int totalSeconds = (int) offset.TotalSeconds;
            if (totalSeconds == 0)
            {
                return "Z";
            }

            var abs = Math.Abs(totalSeconds);

            int hours = abs / 3600;
            int minutes = (abs % 3600) / 60;
            int seconds = abs % 60;

            string absText = abs % 3600 == 0 ? FormatTwoDigits(hours)
                : abs % 60 == 0 ? $"{FormatTwoDigits(hours)}:{FormatTwoDigits(minutes)}"
                : $"{FormatTwoDigits(hours)}:{FormatTwoDigits(minutes)}:{FormatTwoDigits(seconds)}";
            string sign = totalSeconds > 0 ? "+" : "-";
            return sign + absText;
        }

        static string FormatTwoDigits(int value) => value.ToString("00", CultureInfo.InvariantCulture);
    }
    
    /// <summary>
    /// Parses the UTC offset part of a date-time value. This may be "Z" (for UTC) or a string of the format
    /// +HH, +HH:mm, +HH:mm:ss where "+" can actually be + or -.
    /// </summary>
    private static TimeSpan ParseUtcOffset(string offset)
    {
        if (offset == "Z")
        {
            return TimeSpan.Zero;
        }
        // Note: TimeSpan parsing cannot handle +/-, so we need to do that separately.
        string pattern = offset.Length switch
        {
            // Hours only, e.g. +01 or -12
            3 => @"hh",
            // Hours and minutes, e.g. +01:30 or -12:30
            6 => @"hh\:mm",
            // Hours, minutes and seconds, e.g. +01:30:45 or -12:30:45
            9 => @"hh\:mm\:ss",
            _ => ThrowFormatException<string>()
        };
        bool positive = offset[0] switch
        {
            '+' => true,
            '-' => false,
            _ => ThrowFormatException<bool>()
        };
        try
        {
            TimeSpan parsed = TimeSpan.ParseExact(offset.Substring(1), pattern, CultureInfo.InvariantCulture);
            return positive ? parsed : -parsed;
        }
        // Some parts of parsing offsets throw OverflowException; let's stick to FormatException to be consistent.
        catch (OverflowException)
        {
            return ThrowFormatException<TimeSpan>();
        }
    }

    private static void ThrowFormatException() =>
        throw new FormatException("String was not recognized as a valid DateTime");

    // Generic method to allow it to be used easily in a switch expression.
    private static T ThrowFormatException<T>() =>
        throw new FormatException("String was not recognized as a valid DateTime");
}
