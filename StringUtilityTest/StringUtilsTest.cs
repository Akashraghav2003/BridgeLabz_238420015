using StringUtility;
using NUnit.Framework;


namespace StringUtilityTest
{
    [TestFixture]
    public class StringUtilsTest
    {
        private StringUtils stringUtils;
        [SetUp]
        public void SetUp()
        {
            stringUtils = new StringUtils("aaaaaaa");
        }
        [Test]
        public void Reverse_String_ReturnReverse()
        {
            stringUtils.str = "akash";
            string result  = stringUtils.Reverse();
            Assert.AreEqual("hsaka", result);
        }

        [Test]
        public void Reverse_String_ReturnIrReverse()
        {
            stringUtils.str = "akash";
            string result = stringUtils.Reverse();
            Assert.AreNotEqual("akash", result);
        }
        [Test]
        public void IsPalindrome_string_returnIsTrue()
        {
            stringUtils.str = "aaaaaaa";
            bool result = stringUtils.IsPalindrome();
            Assert.IsTrue(result);
        }
        [Test]
        public void IsPalindrome_string_returnIsFalse()
        {
            stringUtils.str = "asdfgh";
            bool result = stringUtils.IsPalindrome();
            Assert.IsFalse(result);
        }
        [Test]
        public void ToUpper_string_returnUpperString()
        {
            stringUtils.str = "akashraghav";
            string result = stringUtils.ToUpperCase();
            Assert.AreEqual("AKASHRAGHAV", result);
        }
        [Test]
        public void ToUpper_string_returnNotUpperString()
        {
            stringUtils.str = "akashraghav";
            string result = stringUtils.ToUpperCase();
            Assert.AreNotEqual("AKAShRaghav", result);
        }




    }
}
