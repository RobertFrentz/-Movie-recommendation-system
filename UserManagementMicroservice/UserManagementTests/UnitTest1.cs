using System;
using Xunit;
using UserManagementMicroservice;

namespace UserManagementTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("HaiLaMunte", "HaiLaMunte")]
        [InlineData("Martie", "Martie")]
        [InlineData("Cireasa", "Cireasa")]
        public void UserRegister_PasswordsDoMatch_ReturnTrue(string password1, string password2)
        {
            Assert.True(InputValidationOperations.ArePasswordsEqual(password1, password2));
        }

        [Theory]
        [InlineData("HaiLaMunte", "covrig")]
        [InlineData("Martie", "extraterestru")]
        [InlineData("Cireasa", "lucerna")]
        public void UserRegister_PasswordsDoNotMatch_ReturnFalse(string password1, string password2)
        {
            Assert.False(InputValidationOperations.ArePasswordsEqual(password1, password2));
        }

        [Theory]
        [InlineData("Maradona", "Maradona")]
        [InlineData("Barcelona", "Barcelona")]
        [InlineData("Elon Musk", "Elon Musk")]
        public void HashingEqualStringsShouldReturnEqualHashes(string string1, string string2)
        {
            var hash1 = Cryptography.HashString(string1);
            var hash2 = Cryptography.HashString(string2);
            Assert.Equal(hash1, hash2);
        }

        [Theory]
        [InlineData("Maradona", "prepelita")]
        [InlineData("Barcelona", "fotbal")]
        [InlineData("Elon Musk", "Jeff Bezos")]
        public void HashingNotEqualStringsShouldReturnNotEqualHashes(string string1, string string2)
        {
            var hash1 = Cryptography.HashString(string1);
            var hash2 = Cryptography.HashString(string2);
            Assert.NotEqual(hash1, hash2);
        }

        [Fact]
        public void GenerateJWTWithExpiredClaim_CheckIfValid_ReturnFalse()
        {

        }

        [Fact]
        public void GenerateJWTAndModifyOneChar_CheckIfValid_ReturnFalse()
        {

        }

        [Fact]
        public void GenerateJWT_CheckIfValid_ReturnTrue()
        {

        }
    }
}
