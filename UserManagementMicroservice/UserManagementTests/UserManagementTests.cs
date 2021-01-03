
using Xunit;
using UserManagementMicroservice;
using UserManagementMicroservice.Entities;
using System.Text;
using System.Collections.Generic;
using UserManagementMicroservice.Data;
using Microsoft.EntityFrameworkCore;
using UserManagementMicroservice.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using static UserManagementMicroservice.Controllers.RatingsController;

namespace UserManagementTests
{

    public class UsersControllerUnitTest
    {
        readonly string AdminJWT = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MTMxODU0ODQsInVzZXJJZCI6NH0.t2sFnEMWbtKdRxPQDNOE80IJS5PPK9qyPg0mlbrZ4B0";
        private User GetTestUser(int i)
        {
            if (i == 1)
            {
                return new User()
                {
                    Id = 1,
                    UserName = "Test One",
                    Password = Cryptography.HashString("123"),
                    Email = Cryptography.HashString("has@gmail.com"),
                    Administrator = false
                };
            }
            else
            {
                return new User()
                {
                    Id = 2,
                    UserName = "Test Two",
                    Password = Cryptography.HashString("123"),
                    Email = Cryptography.HashString("mist@gmail.com"),
                    Administrator = false
                };
            }
        }

        [Fact]
        public void ValidAdministrator_GetUsers_ReturnAListOfRegisteredUsers()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                              .UseInMemoryDatabase(databaseName: "GetUsersDataBase")
                              .Options;
            var context = new DataContext(options);
            context.Add(GetTestUser(1));
            context.Add(GetTestUser(2));
            context.SaveChanges();
            UsersController usersController = new UsersController(context);
            var result = usersController.GetUsers(AdminJWT).Value;
            Assert.Equal(1, result[0].Id);
            Assert.Equal("Test One", result[0].UserName);
            Assert.Equal(Cryptography.HashString("123"), result[0].Password);
            Assert.Equal(Cryptography.HashString("has@gmail.com"), result[0].Email);
            Assert.False(result[0].Administrator);
            Assert.Equal(2, result[1].Id);
            Assert.Equal("Test Two", result[1].UserName);
            Assert.Equal(Cryptography.HashString("123"), result[1].Password);
            Assert.Equal(Cryptography.HashString("mist@gmail.com"), result[1].Email);
            Assert.False(result[1].Administrator);

        }

        [Fact]
        public void ValidAdministrator_GetUser_ReturnASpecifiedUserByEmail()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                              .UseInMemoryDatabase(databaseName: "GetUserSpecifiedDataBase")
                              .Options;
            var context = new DataContext(options);
            context.Add(GetTestUser(1));
            context.Add(GetTestUser(2));
            context.SaveChanges();
            UsersController usersController = new UsersController(context);
            var user1 = usersController.GetUser("has@gmail.com", AdminJWT).Value;
            var user2 = usersController.GetUser("mist@gmail.com", AdminJWT).Value;
            Assert.Equal("Test One", user1.UserName);
            Assert.Equal(Cryptography.HashString("123"), user1.Password);
            Assert.Equal(Cryptography.HashString("has@gmail.com"), user1.Email);
            Assert.False(user1.Administrator);
            Assert.Equal("Test Two", user2.UserName);
            Assert.Equal(Cryptography.HashString("123"), user2.Password);
            Assert.Equal(Cryptography.HashString("mist@gmail.com"), user2.Email);
            Assert.False(user2.Administrator);
        }

        [Fact]
        public void UpdatingAnExistingUser_ReturnNoContent()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                              .UseInMemoryDatabase(databaseName: "PutUserSpecifiedDataBase")
                              .Options;
            var context = new DataContext(options);
            UsersController usersController = new UsersController(context);
            context.Add(new User()
            {
                UserName = "Mirel",
                Password = Cryptography.HashString("123"),
                Email = Cryptography.HashString("has@gmail.com"),
                Administrator = false
            });
            context.Add(new User()
            {
                UserName = "Sandel",
                Password = Cryptography.HashString("123456"),
                Email = Cryptography.HashString("mist@gmail.com"),
                Administrator = false
            });
            context.SaveChanges();
            User user1 = new User() { UserName = "Dorel", Password = "123", Email = "has@gmail.com", Administrator = false };
            User user2 = new User() { UserName = "Giugel", Password = "123456", Email = "mist@gmail.com", Administrator = false };
            var requestForUser1 = usersController.PutUser(user1, AdminJWT);
            var requestForUser2 = usersController.PutUser(user2, AdminJWT);
            Assert.IsType<NoContentResult>(requestForUser1);
            Assert.IsType<NoContentResult>(requestForUser2);

        }

        [Fact]
        public void RegisterNotExistingUser_WithMatchingPasswords_ReturnListWithJWTAndUsername()
        {
            string expected = "Marian";
            var options = new DbContextOptionsBuilder<DataContext>()
                              .UseInMemoryDatabase(databaseName: "PostUsersDataBase")
                              .Options;
            var context = new DataContext(options);
            UsersController usersController = new UsersController(context);
            var result = usersController.PostUser(new UsersController.UserRegister()
            {
                UserName = "Marian",
                Email = "mist@gmail.com",
                Password = "123",
                ConfirmPassword = "123"
            }).Value;
            Assert.Equal(expected, result[1]);
        }

        [Fact]
        public void LoginExistingUser_WithCorrectCredentials_ReturnListWithJWTAndUsername()
        {
            string expected = "Dexter";
            var options = new DbContextOptionsBuilder<DataContext>()
                              .UseInMemoryDatabase(databaseName: "LoginUsersDataBase")
                              .Options;
            var context = new DataContext(options);
            UsersController usersController = new UsersController(context);
            context.Add(new User()
            {
                UserName = "Dexter",
                Email = Cryptography.HashString("dexter@gmail.com"),
                Password = Cryptography.HashString("123"),
                Administrator = false
            });
            context.SaveChanges();
            var result = usersController.LoginUser(new UsersController.Credentials()
            {
                Email = "dexter@gmail.com",
                Password = "123",
            }).Value;
            Assert.Equal(expected, result[1]);
        }

        [Fact]
        public void DeleteExistingUser_ReturnNoContent()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                              .UseInMemoryDatabase(databaseName: "DeleteUsersDataBase")
                              .Options;
            var context = new DataContext(options);
            UsersController usersController = new UsersController(context);
            context.Add(new User()
            {
                UserName = "Mitica",
                Email = Cryptography.HashString("mitica@gmail.com"),
                Password = Cryptography.HashString("123"),
                Administrator = false
            });
            context.SaveChanges();
            var result = usersController.DeleteUser("mitica@gmail.com", AdminJWT);
            Assert.IsType<NoContentResult>(result);
        }
    }

    public class RatingsControllerUnitTest
    {
        [Fact]
        public void GetExistingRating_ReturnRatingScore()
        {
            int expectedScore = 4;
            var options = new DbContextOptionsBuilder<DataContext>()
                             .UseInMemoryDatabase(databaseName: "GetRatingsDataBase")
                             .Options;
            var context = new DataContext(options);
            RatingsController ratingsController = new RatingsController(context);
            context.Add(new Rating()
            {
                MovieId = 1,
                UserId = 1,
                Score = 4
            });
            context.SaveChanges();
            string jwt = UserManagementMicroservice.JWT.CreateJWT(1, 1);
            var score = ratingsController.GetRating(1, jwt).Value;
            Assert.Equal(expectedScore, score);
        }

        [Fact]
        public void AddNotExistingRating_ReturnNoContent()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                             .UseInMemoryDatabase(databaseName: "AddRatingsDataBase")
                             .Options;
            var context = new DataContext(options);
            RatingsController ratingsController = new RatingsController(context);
            string jwt = UserManagementMicroservice.JWT.CreateJWT(2, 1);
            var result = ratingsController.PostRating(new RequestRating() { MovieId = 1, Score = 4 }, jwt);
            Assert.IsType<NoContentResult>(result);

        }

        [Fact]
        public void UpdateExistingRating_ReturnNoContent()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                             .UseInMemoryDatabase(databaseName: "UpdateRatingsDataBase")
                             .Options;
            var context = new DataContext(options);
            RatingsController ratingsController = new RatingsController(context);
            context.Add(new Rating()
            {
                MovieId = 3,
                UserId = 3,
                Score = 3

            });
            context.SaveChanges();
            string jwt = UserManagementMicroservice.JWT.CreateJWT(3, 1);
            var result = ratingsController.PutRating(new RequestRating() { MovieId = 3, Score = 4}, jwt);
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void DeleteExistingRating_ReturnNoContent()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                            .UseInMemoryDatabase(databaseName: "DeleteRatingsDataBase")
                            .Options;
            var context = new DataContext(options);
            RatingsController ratingsController = new RatingsController(context);
            context.Add(new Rating()
            {
                MovieId = 3,
                UserId = 3,
                Score = 3

            });
            context.SaveChanges();
            string jwt = UserManagementMicroservice.JWT.CreateJWT(3, 1);
            var result = ratingsController.DeleteRating(3, jwt);
            Assert.IsType<NoContentResult>(result);
        }
    }

    public class NotControllerUnitTest
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
            if (stringBuilder[stringBuilder.Length - 1] == 'b')
            {
                stringBuilder[stringBuilder.Length - 1] = 'a';
            }
            else
            {
                stringBuilder[stringBuilder.Length - 1] = 'b';
            }
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
