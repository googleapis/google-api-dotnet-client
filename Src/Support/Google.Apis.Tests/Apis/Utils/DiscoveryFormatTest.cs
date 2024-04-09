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

using Google.Apis.Util;
using System;
using Xunit;

namespace Google.Apis.Tests.Apis.Utils;

internal static class DateTimeExtensions
{
    internal static DateTimeOffset InUtc(this DateTime local) =>
        new DateTimeOffset(local, TimeSpan.Zero);

    internal static DateTimeOffset WithUtcOffsetMinutes(this DateTime local, int minutes) =>
        new DateTimeOffset(local, TimeSpan.FromMinutes(minutes));
}

public class DiscoveryFormatTest
{
    private static readonly DateTime DefaultLocal = new DateTime(2023, 11, 08, 12, 34, 56);
    private static readonly DateTimeOffset DefaultUtc = DefaultLocal.InUtc();

    public static TheoryData<string> FullyInvalid = new()
    {
        "broken",
        "reasonable length  Z",
        "2023-01-01T00:00:00z",
        // Invalid year/month/day/hour/minute/second format
        "23-13-01T00:00:00Z",
        "2023-1-30T00:00:00Z",
        "2023-01-3T00:00:00Z",
        "2023-01-03T0:00:00Z",
        "2023-01-03T00:0:00Z",
        "2023-01-03T00:00:0Z",
        // Invalid year/month/day/hour/minute/second values
        "2023-13-01T00:00:00Z",
        "2023-02-30T00:00:00Z",
        "2023-01-01T24:00:00Z",
        "2023-01-01T00:60:00Z",
        "2023-01-01T00:00:60Z",
        // Non-multiple-of-3-digit precision
        "2023-01-01T00:00:00.0Z",
        "2023-01-01T00:00:00.00Z",
        "2023-01-01T00:00:00.0000Z",
        "2023-01-01T00:00:00.00000Z",
        "2023-01-01T00:00:00.0000000Z",
        "2023-01-01T00:00:00.00000000Z",
        "2023-01-01T00:00:00.0000000000Z",
        // We don't support picosecond precision!
        "2023-01-01T00:00:00.000000000000Z",

        // Invalid offsets
        "2023-01-01T00:00:00+01:23:45.67",
        "2023-01-01T00:00:00x01:00:00",
        "2023-01-01T00:00:00++01:00:00",
        "2023-01-01T00:00:00+1",
        "2023-01-01T00:00:00+01:xx",
        "2023-01-01T00:00:00+01:234",
        "2023-01-01T00:00:00+01:60",
        "2023-01-01T00:00:00+01:00:60",
    };

    // Note on formatting for tick-of-second for the theory data in the following tests:
    // ticks are 100ns, so xxx_yyy_z is "xxx milliseconds, yyy microseconds, z ticks within the microsecond"
    // The "default" value is 2023-11-08T12:34:56

    public static TheoryData<string, DateTimeOffset> RoundTripUtc = new()
    {
        { "2023-11-08T12:34:56Z", DefaultUtc },

        { "2023-11-08T12:34:56.123Z", DefaultUtc.AddTicks(123_000_0) },
        { "2023-11-08T12:34:56.123456Z", DefaultUtc.AddTicks(123_456_0) },
        { "2023-11-08T12:34:56.123456700Z", DefaultUtc.AddTicks(123_456_7) },

        { "0001-01-01T00:00:00Z", new DateTimeOffset(0L, TimeSpan.Zero) },
        { "9999-12-31T23:59:59.999999900Z", new DateTimeOffset(9999, 12, 31, 23, 59, 59, TimeSpan.Zero).AddTicks(999_999_9) },
    };

    public static TheoryData<string, DateTimeOffset> NonRoundTripUtc = new()
    {
        { "2023-11-08T12:34:56.000Z", DefaultUtc },
        { "2023-11-08T12:34:56.000000Z", DefaultUtc },
        { "2023-11-08T12:34:56.000000000Z", DefaultUtc },
        { "2023-11-08T12:34:56.123000Z", DefaultUtc.AddTicks(123_000_0) },
        { "2023-11-08T12:34:56.123456789Z", DefaultUtc.AddTicks(123_456_7) },
        { "9999-12-31T23:59:59.999999999Z", new DateTimeOffset(9999, 12, 31, 23, 59, 59, TimeSpan.Zero).AddTicks(999_999_9) },
    };

    // All of these are invalid for google-datetime
    public static TheoryData<string, DateTimeOffset> RoundTripNonUtc = new()
    {
        { "2023-11-08T12:34:56+01", DefaultLocal.WithUtcOffsetMinutes(60) },
        { "2023-11-08T12:34:56-01", DefaultLocal.WithUtcOffsetMinutes(-60) },
        { "2023-11-08T12:34:56+00:01", DefaultLocal.WithUtcOffsetMinutes(1) },
        { "2023-11-08T12:34:56-00:01", DefaultLocal.WithUtcOffsetMinutes(-1) },
        // Just to prove we can combine hours and minutes...
        { "2023-11-08T12:34:56+02:13", DefaultLocal.WithUtcOffsetMinutes(133) },

        // Just a single case with subsecond precision - in generally it'll be covered by the UTC cases
        {  "2002-06-19T19:23:01.123+01", new DateTimeOffset(2002, 6, 19, 19, 23, 1, 123, TimeSpan.FromHours(1)) }
    };

    public static TheoryData<string, DateTimeOffset> NonRoundTripNonUtc = new()
    {
        { "2023-11-08T12:34:56+00", DefaultUtc },
        { "2023-11-08T12:34:56-00", DefaultUtc },
        { "2023-11-08T12:34:56+00:00", DefaultUtc },
        { "2023-11-08T12:34:56-00:00", DefaultUtc },
        { "2023-11-08T12:34:56+00:00:00", DefaultUtc },
        { "2023-11-08T12:34:56-00:00:00", DefaultUtc },

        { "2023-11-08T12:34:56+01:00", DefaultLocal.WithUtcOffsetMinutes(60) },
        { "2023-11-08T12:34:56-01:00", DefaultLocal.WithUtcOffsetMinutes(-60) },

        // The test cases below all have second-precision offsets, which can't be represented
        // in DateTimeOffset. We adjust the instant in time, and truncate the seconds
        { "2023-11-08T12:34:56+00:00:01", DefaultUtc.AddSeconds(-1) },
        { "2023-11-08T12:34:56-00:00:01", DefaultUtc.AddSeconds(1) },
        { "2023-11-08T12:34:56+11:22:33", DefaultLocal.WithUtcOffsetMinutes(11 * 60 + 22).AddSeconds(-33) },
        { "2023-11-08T12:34:56.000+11:22:33", DefaultLocal.WithUtcOffsetMinutes(11 * 60 + 22).AddSeconds(-33) },
        { "2023-11-08T12:34:56.000-11:22:33", DefaultLocal.WithUtcOffsetMinutes(-11 * 60 - 22).AddSeconds(33) },

        { "2023-11-08T12:34:56.000+01", DefaultLocal.WithUtcOffsetMinutes(60) },
    };

    [Fact]
    public void NullPropagation()
    {
        Assert.Null(DiscoveryFormat.ParseDateTimeToDateTimeOffset(null));
        Assert.Null(DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(null));
        Assert.Null(DiscoveryFormat.FormatDateTimeOffsetToDateTime(null));
        Assert.Null(DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(null));
    }

    [Theory]
    [MemberData(nameof(FullyInvalid))]
    public void ParseDateTimeToDateTimeOffset_Invalid(string text) =>
        Assert.Throws<FormatException>(() => DiscoveryFormat.ParseDateTimeToDateTimeOffset(text));

    [Theory]
    [MemberData(nameof(FullyInvalid))]
    public void ParseGoogleDateTimeToDateTimeOffset_Invalid(string text) =>
        Assert.Throws<FormatException>(() => DiscoveryFormat.ParseDateTimeToDateTimeOffset(text));

    [Theory]
    [MemberData(nameof(RoundTripNonUtc))]
    [MemberData(nameof(NonRoundTripNonUtc))]
    public void ParseGoogleDateTimeToDateTimeOffset_NonUtc(string text, DateTimeOffset _) =>
        Assert.Throws<FormatException>(() => DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(text));

    [Theory]
    [MemberData(nameof(RoundTripUtc))]
    [MemberData(nameof(NonRoundTripUtc))]
    [MemberData(nameof(RoundTripNonUtc))]
    [MemberData(nameof(NonRoundTripNonUtc))]
    public void ParseDateTimeToDateTimeOffset_Valid(string text, DateTimeOffset expected)
    {
        var actual = DiscoveryFormat.ParseDateTimeToDateTimeOffset(text);
        Assert.NotNull(actual);
        Assert.Equal(expected.DateTime, actual.Value.DateTime);
        Assert.Equal(expected.Offset, actual.Value.Offset);
    }

    [Theory]
    [MemberData(nameof(RoundTripUtc))]
    [MemberData(nameof(NonRoundTripUtc))]
    public void ParseGoogleDateTimeToDateTimeOffset_Valid(string text, DateTimeOffset expected)
    {
        var actual = DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(text);
        Assert.NotNull(actual);
        Assert.Equal(expected.DateTime, actual.Value.DateTime);
        Assert.Equal(expected.Offset, actual.Value.Offset);
    }

    [Theory]
    [MemberData(nameof(RoundTripUtc))]
    [MemberData(nameof(RoundTripNonUtc))]
    public void FormatDateTimeOffsetToDateTime(string expected, DateTimeOffset dto)
    {
        var actual = DiscoveryFormat.FormatDateTimeOffsetToDateTime(dto);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(RoundTripUtc))]
    public void FormatDateTimeOffsetToGoogleDateTime(string expected, DateTimeOffset dto)
    {
        var actual = DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(dto);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatDateTimeOffsetToGoogleDateTime_ConvertsToUtc()
    {
        // 2023-11-08T12:34:56+01 == 2023-11-08T11:34:56Z
        var dto = DefaultLocal.WithUtcOffsetMinutes(60);
        var expected = "2023-11-08T11:34:56Z";
        var actual = DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(dto);
        Assert.Equal(expected, actual);
    }
}
