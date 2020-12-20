using System;
using Xunit;
using UserManagementMicroservice;
using UserManagementMicroservice.Entities;
using System.Text;
using System.Collections.Generic;
using System.Collections;

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
            //aici nu prea am inteles, daca poti face tu si eventual adaugi alte teste pe care sa le fac :)
        }

        //trebuie modificat la final, unde e signatura, ca altfel da eroare la json parser :)
        [Theory]
        [MemberData(nameof(GetUserDataTest))]
        public void GenerateJWTAndModifyOneChar_CheckIfValid_ReturnFalse(User user)
        {
                string jwt = UserManagementMicroservice.JWT.CreateJWT(user);
                Console.WriteLine(jwt);
                StringBuilder stringBuilder = new StringBuilder(jwt);
                stringBuilder[stringBuilder.Length-1] = '/';
                string changedJWT = stringBuilder.ToString();
                Console.WriteLine(changedJWT);
                Assert.Equal("Token has invalid signature", UserManagementMicroservice.JWT.CheckJWT(changedJWT));
        }

        public static IEnumerable<object[]> GetUserDataTest()
        {
            //yield e ca sa returneze un iterabal object
            yield return new object[]
            {
                    new User() {Id = 1, UserName = "costel", Password = "lala", Email = "costel@gmail.com", Administrator = false}
            };
            yield return new object[]
            {
                    new User() {Id = 5, UserName = "gigel", Password = "lulu", Email = "gigel@gmail.com", Administrator = false}
            };
            yield return new object[]
            {
                    new User() {Id = 10, UserName = "sorinel", Password = "lele", Email = "sorinel@gmail.com", Administrator = true}
            };
        }
        

        [Theory]
        [MemberData(nameof(GetUserDataTest))]
        public void GenerateJWT_CheckIfValid_ReturnTrue(User user)
        {
            string jwt = UserManagementMicroservice.JWT.CreateJWT(user);
            Console.WriteLine(jwt);
            string output = UserManagementMicroservice.JWT.CheckJWT(jwt);
            Assert.NotEqual("Token has invalid signature", output);
            Assert.NotEqual("Token has expired", output);
        }
    }
}
