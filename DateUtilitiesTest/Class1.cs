using NUnit.Framework;
using DateUtilities;
using System;

namespace DateUtilitiesTest
{
    [TestFixture]
    public class DateFormatterTest
    {
        private DateFormatter dateFormatter;

        [SetUp]
        public void SetUp()
        {
            dateFormatter = new DateFormatter();
        }

        [Test]
        public void FormatDate_ValidDate_ShouldReturnFormattedDate()
        {
            string result = dateFormatter.FormatDate("2024-02-22");
            Assert.AreEqual("22-02-2024", result, "2024-02-22 should convert to 22-02-2024");
        }

        [Test]
        public void FormatDate_InvalidDate_ShouldThrowFormatException()
        {
            Assert.Throws<FormatException>(() => dateFormatter.FormatDate("22-02-2024"), "Should throw exception for wrong format.");
        }

        [Test]
        public void FormatDate_EmptyString_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => dateFormatter.FormatDate(""), "Should throw exception for empty input.");
        }

        [Test]
        public void FormatDate_NullInput_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => dateFormatter.FormatDate(null), "Should throw exception for null input.");
        }
    }
}
