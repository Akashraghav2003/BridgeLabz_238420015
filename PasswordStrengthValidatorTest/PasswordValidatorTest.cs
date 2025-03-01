using NUnit.Framework;
using Security;

namespace SecurityTest
{
    [TestFixture]
    public class PasswordValidatorTest
    {
        private PasswordValidator passwordValidator;

        [SetUp]
        public void SetUp()
        {
            passwordValidator = new PasswordValidator();
        }

        [Test]
        public void Password_ValidPassword_ShouldReturnTrue()
        {
            bool result = passwordValidator.IsValidPassword("StrongP@ss1");
            Assert.IsTrue(result, "Valid password should pass.");
        }

        [Test]
        public void Password_TooShort_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValidPassword("Abc1");
            Assert.IsFalse(result, "Password too short should fail.");
        }

        [Test]
        public void Password_NoUpperCase_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValidPassword("password123");
            Assert.IsFalse(result, "Password without uppercase should fail.");
        }

        [Test]
        public void Password_NoDigit_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValidPassword("PasswordTest");
            Assert.IsFalse(result, "Password without a digit should fail.");
        }

        [Test]
        public void Password_EmptyString_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValidPassword("");
            Assert.IsFalse(result, "Empty password should fail.");
        }

        [Test]
        public void Password_NullInput_ShouldReturnFalse()
        {
            bool result = passwordValidator.IsValidPassword(null);
            Assert.IsFalse(result, "Null password should fail.");
        }
    }
}

