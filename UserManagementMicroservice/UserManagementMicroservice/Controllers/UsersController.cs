
using Microsoft.AspNetCore.Mvc;
using UserManagementMicroservice.Data;
using UserManagementMicroservice.Entities;
using System.Collections.Generic;
using System.Linq;
using JWT.Builder;
using JWT.Algorithms;
using System;
using JWT;
using JWT.Serializers;
using JWT.Exceptions;
using System.Data;

namespace UserManagementMicroservice.Controllers
{

    //TOKEN ADMINISTRATOR FOR TESTING eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MDg2NzgzOTAsInVzZXJJZCI6MjAzfQ.HoCs9HegYMDogKW-WoTq9LBfXnM1HEg9mdp3QIj38hA

    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly DataContext _context;

        private class Error
        {
            public Error(string _error_info)
            {
                error_info = _error_info;
            }
            public string error_info { get; set; }
        }

        public class Credentials
        {
            public string Email { get; set; }

            public string Password { get; set; }

        }

        public class UserRegister
        {
            public string UserName { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }

            public string ConfirmPassword { get; set; }

        }

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers([FromHeader] string Authentification_Token)
        {
            string auth = CheckJWT(Authentification_Token);
            if (auth == "Token has expired" || auth == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string elements = auth.Split(',').ToList()[1].Split(':').ToList()[1];
                string el = elements.Remove(elements.Length - 1);
                var userApproved = _context.Users.Where(u => (u.Administrator == true) && (u.Id == Convert.ToInt32(el))).ToList();
                if (userApproved.Count == 0)
                {
                    return Forbid();
                }
                else
                {
                    return _context.Users.ToList();
                }
            }
        }

        [HttpGet("{email}")]
        public ActionResult<User> GetUser(string email, [FromHeader] string Authentification_Token)
        {
            string auth = CheckJWT(Authentification_Token);
            List<User> user = new List<User>();
            if (auth == "Token has expired" || auth == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string elements = auth.Split(',').ToList()[1].Split(':').ToList()[1];
                string el = elements.Remove(elements.Length - 1);
                var userApproved = _context.Users.Where(u => (u.Administrator == true) && (u.Id == Convert.ToInt32(el))).ToList();
                if (userApproved.Count == 0)
                {
                    return Forbid();
                }
                else
                {
                    user = _context.Users.Where(u => u.Email == email).ToList();
                    if (user.Count == 0)
                    {
                        return NotFound(new Error("User doesn't exists"));
                    }

                    return user[0];
                }
            }

        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public IActionResult PutUser([FromBody] User user, [FromHeader] string Authentification_Token)
        {
            string auth = CheckJWT(Authentification_Token);
            if (auth == "Token has expired" || auth == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                if (!UserExists(user.Email))
                {
                    return NotFound(new Error("User doesn't exists"));
                }
                _context.Update(user);
                _context.SaveChanges();
            }
            return NoContent();
        }

        [Route("login")]
        [HttpPost]
        public ActionResult<List<string>> LoginUser([FromBody] Credentials userCredentials)
        {
            string hashedMail = Cryptography.HashString(userCredentials.Email);
            string hashedPassword = Cryptography.HashString(userCredentials.Password);
            Console.WriteLine("Email: " + hashedMail + " password: " + hashedPassword);
            List<User> user = _context.Users.Where(u => u.Email == Cryptography.HashString(userCredentials.Email) && u.Password == Cryptography.HashString(userCredentials.Password)).ToList();
            if (user.Count != 0)
            {
                List<string> response = new List<string>();
                response.Add(CreateJWT(user[0]));
                response.Add(user[0].UserName);
                return response;
            }
            else
            {
                return BadRequest(new Error("Email or password invalid"));
            }

        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("register")]
        [HttpPost]
        public ActionResult<List<string>> PostUser([FromBody] UserRegister user)
        {

            if (user.Password != user.ConfirmPassword)
            {
                return BadRequest(new Error("Passwords don't match"));
            }
            if (!UserExists(Cryptography.HashString(user.Email)))
            {
                User newUser = new User();
                newUser.UserName = user.UserName;
                newUser.Email = user.Email;
                newUser.Password = user.Password;
                newUser.Administrator = true;
                newUser = Cryptography.HashUserData(newUser);
                _context.Add(newUser);
                _context.SaveChanges();
                List<string> jsonResponse = new List<string>();
                jsonResponse.Add(CreateJWT(newUser));
                jsonResponse.Add(user.UserName);
                return jsonResponse;
            }
            else
            {
                return Conflict(new Error("Email already exists"));
            }

        }


        //Ruta test
        [Route("verify")]
        [HttpGet]
        public ActionResult<string> CheckUser(string jwtToken)
        {
            return CheckJWT(jwtToken);
        }

        [HttpDelete("{email}")]
        public IActionResult DeleteUser(string email, [FromHeader] string Authentification_Token)
        {
            string auth = CheckJWT(Authentification_Token);
            List<User> user = new List<User>();
            if (auth == "Token has expired" || auth == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string elements = auth.Split(',').ToList()[1].Split(':').ToList()[1];
                string el = elements.Remove(elements.Length - 1);
                var userApproved = _context.Users.Where(u => (u.Administrator == true) && (u.Id == Convert.ToInt32(el))).ToList();
                if (userApproved.Count == 0)
                {
                    return Forbid();
                }
                else
                {
                    user = _context.Users.Where(u => u.Email == email).ToList();
                    if (user.Count == 0)
                    {
                        return NotFound(new Error("User doesn't exists"));
                    }

                    _context.Users.Remove(user[0]);
                    _context.SaveChanges();
                }
            }
            return NoContent();
        }
        private bool UserExists(string email)
        {
            return _context.Users.Any(e => e.Email == email);
        }

        private string CreateJWT(User user)
        {
            var token = new JwtBuilder()
                           .WithAlgorithm(new HMACSHA256Algorithm())
                           .WithSecret("GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk")
                           .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(200).ToUnixTimeSeconds())
                           .AddClaim("userId", user.Id)
                           .Encode();
            return token;
        }

        private string CheckJWT(string jwtToken)
        {
            string json;
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                var provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

                json = decoder.Decode(jwtToken, "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk", verify: true);
            }
            catch (TokenExpiredException)
            {
                return "Token has expired";
            }
            catch (SignatureVerificationException)
            {
                return "Token has invalid signature";
            }
            return json;
        }
    }
}
