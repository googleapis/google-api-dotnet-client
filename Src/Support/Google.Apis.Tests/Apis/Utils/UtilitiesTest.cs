/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Util;
using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Google.Apis.Tests.Apis.Util
{
    /// <summary>Tests for <seealso cref="Google.Apis.Util.Utilities"/> class.</summary>
    public class UtilitiesTest
    {
        /// <summary>Tests the "ThrowIfNull" method.</summary>
        [Fact]
        public void ThrowIfNullTest()
        {
            string str = null;
            Assert.Throws<ArgumentNullException>(() => str.ThrowIfNull("str"));
            str = "123";
            str.ThrowIfNull("Not throwen");
        }

        private enum MockEnum
        {
            [StringValue("Test")]
            EntryWithStringValue,
            [StringValue("3.14159265358979323846")]
            EntryWithSecondStringValue,
            EntryWithoutStringValue
        }

        /// <summary>Tests the "GetStringValue" extension method of Enums.</summary>
        [Fact]
        public void StringValueTest()
        {
            Assert.Equal("Test", Utilities.GetEnumStringValue(MockEnum.EntryWithStringValue));
            Assert.Equal("3.14159265358979323846", Utilities.GetEnumStringValue(MockEnum.EntryWithSecondStringValue));
            Assert.Throws<ArgumentException>(() => Utilities.GetEnumStringValue(MockEnum.EntryWithoutStringValue));
            Assert.Throws<ArgumentNullException>(() => Utilities.GetEnumStringValue((MockEnum)123456));
        }

        /// <summary>Tests the "ConvertToString" method.</summary>
        [Fact]
        public void ConvertToStringTest()
        {
            Assert.Equal("FooBar", Google.Apis.Util.Utilities.ConvertToString("FooBar"));
            Assert.Equal("123", Google.Apis.Util.Utilities.ConvertToString(123));
            Assert.Equal("false", Google.Apis.Util.Utilities.ConvertToString(false));
            Assert.Equal("true", Google.Apis.Util.Utilities.ConvertToString(true));

            // Check Enums work with and without StringValueAttribute.
            Assert.Equal("Test", Google.Apis.Util.Utilities.ConvertToString(MockEnum.EntryWithStringValue));
            Assert.Equal("3.14159265358979323846",
                Google.Apis.Util.Utilities.ConvertToString(MockEnum.EntryWithSecondStringValue));
            Assert.Equal("EntryWithoutStringValue",
                Google.Apis.Util.Utilities.ConvertToString(MockEnum.EntryWithoutStringValue));
            Assert.Null(Google.Apis.Util.Utilities.ConvertToString(null));

            // Test nullable types.
            int? nullable = 123;
            Assert.Equal("123", Google.Apis.Util.Utilities.ConvertToString(nullable));
            nullable = null;
            Assert.Null(Google.Apis.Util.Utilities.ConvertToString(nullable));
            MockEnum? nullEnum = null;
            Assert.Null(Google.Apis.Util.Utilities.ConvertToString(nullEnum));
        }

        [Fact]
        public void GetDateTimeOffsetFromString_Null() =>
            Assert.Null(Utilities.GetDateTimeOffsetFromString(null));

        [Theory]
        [InlineData("broken")]
        [InlineData("")]
        [InlineData("2023-13-01T00:00:00Z")]
        [InlineData("2023-06-14T12:23:45.5Z")] // Subsecond digit count must be a multiple of 3
        [InlineData("2023-13-01T00:00:00+00")] // We require the Z
        [InlineData("2023-13-01T00:00:00+01")] // We require the Z
        [InlineData("2023-06-14T12:23:45.0000000x0Z")] // Broken past ticks
        [InlineData("2023-06-14T12:23:45.00000000xZ")] // Broken past ticks
        [InlineData("2023-06-14T12:23:45.000000000z")] // Broken past ticks
        public void GetDateTimeOffsetFromString_Invalid(string input) =>
            Assert.Throws<FormatException>(() => Utilities.GetDateTimeOffsetFromString(input));

        // Note on formatting for tick-of-second for the theory data in the following tests:
        // ticks are 100ns, so xxx_yyy_z is "xxx milliseconds, yyy microseconds, z ticks within the microsecond"

        [Theory]
        [InlineData("2023-12-01T00:00:00Z", 2023, 12, 1, 0, 0, 0, 0)]
        [InlineData("0001-01-01T00:00:00Z", 1, 1, 1, 0, 0, 0, 0)]
        [InlineData("9999-12-31T23:59:59.999Z", 9999, 12, 31, 23, 59, 59, 999_000_0)]
        [InlineData("9999-12-31T23:59:59.999999Z", 9999, 12, 31, 23, 59, 59, 999_999_0)]
        [InlineData("9999-12-31T23:59:59.999999999Z", 9999, 12, 31, 23, 59, 59, 999_999_9)]
        
        [InlineData("2023-06-14T12:23:45.123Z", 2023, 6, 14, 12, 23, 45, 123_000_0)]
        [InlineData("2023-06-14T12:23:45.123456Z", 2023, 6, 14, 12, 23, 45, 123_456_0)]
        [InlineData("2023-06-14T12:23:45.123456789Z", 2023, 6, 14, 12, 23, 45, 123_456_7)]
        [InlineData("2023-06-14T12:23:45.000Z", 2023, 6, 14, 12, 23, 45, 0)] // .000 is redundant but valid
        [InlineData("2023-06-14T12:23:45.000000Z", 2023, 6, 14, 12, 23, 45, 0)] // .000 is redundant but valid
        [InlineData("2023-06-14T12:23:45.000000000Z", 2023, 6, 14, 12, 23, 45, 0)] // .000 is redundant but valid
        [InlineData("2023-06-14T12:23:45Z", 2023, 6, 14, 12, 23, 45, 0)]
        public void GetDateTimeOffsetFromString_Valid(string input, int year, int month, int day, int hour, int minute, int second, int tickOfSecond)
        {
            var actual = Utilities.GetDateTimeOffsetFromString(input).Value;
            var expected = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.Zero).AddTicks(tickOfSecond);
            Assert.Equal(expected, actual);
            // Be explicit about this, as DateTimeOffset.Equals only compares instants in time, not offsets.
            Assert.Equal(TimeSpan.Zero, actual.Offset);
        }

        [Theory]
        [InlineData(500_000_0, "2023-06-13T15:54:13.500Z")]
        [InlineData(123_456_0, "2023-06-13T15:54:13.123456Z")]
        [InlineData(123_456_7, "2023-06-13T15:54:13.123456700Z")]
        [InlineData(123_999_9, "2023-06-13T15:54:13.123999900Z")]
        [InlineData(999_999_9, "2023-06-13T15:54:13.999999900Z")]
        [InlineData(1_000_0, "2023-06-13T15:54:13.001Z")]
        [InlineData(10_000_0, "2023-06-13T15:54:13.010Z")]
        [InlineData(0, "2023-06-13T15:54:13Z")]
        public void GetStringFromDateTimeOffset_SubsecondHandling(int tickOfSecond, string expectedResult)
        {
            var value = new DateTimeOffset(2023, 6, 13, 15, 54, 13, TimeSpan.Zero).AddTicks(tickOfSecond);
            Assert.Equal(expectedResult, Utilities.GetStringFromDateTimeOffset(value));
        }

        [Fact]
        public void DateTimeOffsetConversionsAreInvariant()
        {
            using var _ = new CultureSwitcher("da-DK");
            var dto = new DateTimeOffset(2023, 6, 13, 15, 54, 13, 500, TimeSpan.Zero);
            string text = "2023-06-13T15:54:13.500Z";
            Assert.Equal(text, Utilities.GetStringFromDateTimeOffset(dto));
            Assert.Equal(dto, Utilities.GetDateTimeOffsetFromString(text));
        }

        // Local time of 2023-06-13T15:54:13, with variable UTC offset.
        [Theory]
        [InlineData(60, "2023-06-13T14:54:13Z")]
        [InlineData(30, "2023-06-13T15:24:13Z")]
        [InlineData(0, "2023-06-13T15:54:13Z")]
        [InlineData(-30, "2023-06-13T16:24:13Z")]
        [InlineData(-60, "2023-06-13T16:54:13Z")]
        public void GetStringFromDateTimeOffset_ConvertsToUtc(int offsetMinutes, string expectedResult)
        {
            var value = new DateTimeOffset(2023, 6, 13, 15, 54, 13, TimeSpan.FromMinutes(offsetMinutes));
            Assert.Equal(expectedResult, Utilities.GetStringFromDateTimeOffset(value));
        }

        [Fact]
        public void GetStringFromDateTimeOffset_Null() =>
            Assert.Null(Utilities.GetStringFromDateTimeOffset(null));

        [Fact]
        public void GetStringFromDateTimeOffset_NonGregorianCulture()
        {
            var culture = CultureInfo.GetCultureInfo("fa-AF");

            var original = CultureInfo.CurrentCulture;
            try
            {
                Thread.CurrentThread.CurrentCulture = culture;
                // Demonstrate that there's a problem for DateTime, albeit with an invalid raw value...
                // (DateTime.Parse seems to use the invariant culture if a full ISO-8601 timestamp is provided...)
                var dtResult = Utilities.GetDateTimeFromString("2023-06-14");
                // The difference in calendar means the year is actually 2644.
                Assert.NotEqual(2023, dtResult.Value.Year);

                // We don't have the possibility of this problem for DateTimeOffset, because
                // we use the invariant culture. We can't check this against the "just date" value,
                // because we require the exact value for DateTimeOffset.
                var dtoResult = Utilities.GetDateTimeFromString("2023-06-14T00:00:00Z");
                var expected = new DateTimeOffset(2023, 6, 14, 0, 0, 0, TimeSpan.Zero);
                Assert.Equal(expected, dtoResult.Value);
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = original;
            }
        }

        [Fact]
        public void SerializeForGoogleFormat_Null() =>
            Assert.Null(Utilities.SerializeForGoogleFormat(null));

        [Theory]
        [InlineData("simple")]
        [InlineData("with \"quotes\"")]
        [InlineData("with emoji \U0001F604")]
        [InlineData("with backslash \\")]
        [InlineData("2023-06-15T10:52:00+00:00")] // DeserializeForGoogleFormat would return a DateTime
        public void SerializeForGoogleFormat_String(string input) =>
            Assert.Equal(input, Utilities.SerializeForGoogleFormat(input));

        [Fact]
        public void SerializeForGoogleFormat_DateTime() =>
            Assert.Equal("2023-06-15T10:52:00.000Z", Utilities.SerializeForGoogleFormat(new DateTime(2023, 6, 15, 10, 52, 0, DateTimeKind.Utc)));

        [Fact]
        public void SerializeForGoogleFormat_DateTimeOffset_Utc() =>
            Assert.Equal("2023-06-15T10:52:00+00:00", Utilities.SerializeForGoogleFormat(new DateTimeOffset(2023, 6, 15, 10, 52, 0, TimeSpan.Zero)));

        [Fact]
        public void SerializeForGoogleFormat_DateTimeOffset_NonUtc() =>
            Assert.Equal("2023-06-15T10:52:00+01:00", Utilities.SerializeForGoogleFormat(new DateTimeOffset(2023, 6, 15, 10, 52, 0, TimeSpan.FromHours(1))));

        [Fact]
        public void DeserializeForGoogleFormat_Null() =>
            Assert.Null(Utilities.DeserializeForGoogleFormat(null));

        [Theory]
        [InlineData("simple")]
        [InlineData("with \"quotes\"")]
        [InlineData("with emoji \U0001F604")]
        [InlineData("with backslash \\")]
        public void DeserializeForGoogleFormat_String(string input) =>
            Assert.Equal(input, Utilities.DeserializeForGoogleFormat(input));

        [Theory]
        [InlineData("2023-06-15T10:52:00.000Z")]
        [InlineData("2023-06-15T10:52:00Z")]
        public void DeserializeForGoogleFormat_DateTime(string text)
        {
            var result = Utilities.DeserializeForGoogleFormat(text);
            var dt = Assert.IsAssignableFrom<DateTime>(result);
            Assert.Equal(new DateTime(2023, 6, 15, 10, 52, 0, DateTimeKind.Utc), dt);
            // DateTime.Equals doesn't take the kind into account.
            Assert.Equal(DateTimeKind.Utc, dt.Kind);
        }
    }
}