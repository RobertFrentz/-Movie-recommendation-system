
using Xunit;
using UserManagementMicroservice;
using UserManagementMicroservice.Entities;
using System.Text;
using System.Collections.Generic;
using UserManagementMicroservice.Data;
using Microsoft.EntityFrameworkCore;
using UserManagementMicroservice.Controllers;
using System;

namespace UserManagementTests
{

    public class UserControllerTests
    {

        private User GetTestUser(int i)
        {
            if (i == 1)
            {
                return new User()
                {
                    Id = 1,
                    UserName = "Test One",
                    Password = "123",
                    Email = "has@gmail.com",
                    Administrator = false
                };
            }
            else
            {
                return new User()
                {
                    Id = 2,
                    UserName = "Test Two",
                    Password = "123",
                    Email = "mist@gmail.com",
                    Administrator = false
                };
            }
        }

        [Fact]
        public void ValidAdministrator_GetUsers_ReturnAListOfRegisteredUsers()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                              .UseInMemoryDatabase(databaseName: "UserDataBase")
                              .Options;
            var context = new DataContext(options);
            context.Users.Add(GetTestUser(1));
            context.Users.Add(GetTestUser(2));
            context.SaveChanges();
            UsersController usersController = new UsersController(context);
            var result = usersController.GetUsers("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MDg2NzgzOTAsInVzZXJJZCI6MjAzfQ.HoCs9HegYMDogKW-WoTq9LBfXnM1HEg9mdp3QIj38hA").Value;
            Assert.Equal(1, result[0].Id);
            Assert.Equal("Test One", result[0].UserName);
            Assert.Equal("123", result[0].Password);
            Assert.Equal("has@gmail.com", result[0].Email);
            Assert.False(result[0].Administrator);
            Assert.Equal(2, result[1].Id);
            Assert.Equal("Test Two", result[1].UserName);
            Assert.Equal("123", result[1].Password);
            Assert.Equal("mist@gmail.com", result[1].Email);
            Assert.False(result[1].Administrator);

        }
    }
    public class UnitTest1
    {
        public static IEnumerable<object[]> GetUserDataTestNotEqualUsers()
        {
            //yield e ca sa returneze un iterabal object
            yield return new object[]
            {
                    new User() {Id = 1, UserName = "costel", Password = "lala", Email = "costel@gmail.com", Administrator = false},
                    new User() {Id = 2, UserName = "mirel", Password = "dudu", Email = "mirel@gmail.com", Administrator = true}
            };
            yield return new object[]
            {
                    new User() {Id = 5, UserName = "gigel", Password = "lulu", Email = "gigel@gmail.com", Administrator = false},
                    new User() {Id = 2, UserName = "mirel", Password = "dudu", Email = "mirel@gmail.com", Administrator = true}
            };
            yield return new object[]
            {
                    new User() {Id = 10, UserName = "sorinel", Password = "lele", Email = "sorinel@gmail.com", Administrator = true},
                    new User() {Id = 2, UserName = "mirel", Password = "dudu", Email = "mirel@gmail.com", Administrator = true}
            };
        }

        public static IEnumerable<object[]> GetUserDataTestEqualUsers()
        {
            //yield e ca sa returneze un iterabal object
            yield return new object[]
            {
                    new User() {Id = 1, UserName = "costel", Password = "lala", Email = "costel@gmail.com", Administrator = false},
                    new User() {Id = 1, UserName = "costel", Password = "lala", Email = "costel@gmail.com", Administrator = false}
            };
            yield return new object[]
            {
                    new User() {Id = 5, UserName = "gigel", Password = "lulu", Email = "gigel@gmail.com", Administrator = false},
                    new User() {Id = 5, UserName = "gigel", Password = "lulu", Email = "gigel@gmail.com", Administrator = false}
            };
            yield return new object[]
            {
                    new User() {Id = 10, UserName = "sorinel", Password = "lele", Email = "sorinel@gmail.com", Administrator = true},
                    new User() {Id = 10, UserName = "sorinel", Password = "lele", Email = "sorinel@gmail.com", Administrator = true}
            };
        }


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

        [Theory]
        [MemberData(nameof(GetUserDataTestNotEqualUsers))]
        public void HashingNotEqualUsersShouldReturnNotEqualHashes(User user1, User user2)
        {
            var hash1 = Cryptography.HashUserData(user1);
            var hash2 = Cryptography.HashUserData(user2);
            Assert.NotEqual(hash1.Email, hash2.Email);
        }

        [Theory]
        [MemberData(nameof(GetUserDataTestEqualUsers))]
        public void HashingEqualUsersShouldReturnEqualHashes(User user1, User user2)
        {
            var hash1 = Cryptography.HashUserData(user1);
            var hash2 = Cryptography.HashUserData(user2);
            Assert.Equal(hash1.UserName, hash2.UserName);
            Assert.Equal(hash1.Password, hash2.Password);
            Assert.Equal(hash1.Email, hash2.Email);
            Assert.Equal(hash1.Administrator, hash2.Administrator);
            Assert.Equal(hash1.Id, hash2.Id);

        }


        [Theory]
        [InlineData(1, -1)]
        [InlineData(2, -1)]
        [InlineData(3, -1)]
        public void GenerateJWTWithExpiredClaim_CheckIfValid_ReturnFalse(int userId, int time)
        {
            string jwt = UserManagementMicroservice.JWT.CreateJWT(userId, time);
            string output = UserManagementMicroservice.JWT.CheckJWT(jwt);
            Assert.Equal("Token has expired", output);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        public void GenerateJWTAndModifyOneChar_CheckIfValid_ReturnFalse(int userId, int time)
        {
                string jwt = UserManagementMicroservice.JWT.CreateJWT(userId, time);
                StringBuilder stringBuilder = new StringBuilder(jwt);
                stringBuilder[stringBuilder.Length-1] = '+';
                string changedJWT = stringBuilder.ToString();
                Assert.Equal("Token has invalid signature", UserManagementMicroservice.JWT.CheckJWT(changedJWT));
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,1)]
        public void GenerateJWT_CheckIfValid_ReturnTrue(int userId, int time)
        {
            string jwt = UserManagementMicroservice.JWT.CreateJWT(userId,time);
            string output = UserManagementMicroservice.JWT.CheckJWT(jwt);
            Assert.NotEqual("Token has invalid signature", output);
            Assert.NotEqual("Token has expired", output);
        }

        

    }

}
