
using Microsoft.AspNetCore.Mvc;
using UserManagementMicroservice.Data;
using UserManagementMicroservice.Entities;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data;

namespace UserManagementMicroservice.Controllers
{

    //TOKEN ADMINISTRATOR FOR TESTING eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MDg2NzgzOTAsInVzZXJJZCI6MjAzfQ.HoCs9HegYMDogKW-WoTq9LBfXnM1HEg9mdp3QIj38hA

    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public const string AdminJWT = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MDg2NzgzOTAsInVzZXJJZCI6MjAzfQ.HoCs9HegYMDogKW-WoTq9LBfXnM1HEg9mdp3QIj38hA";


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
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string elements = jwtDecoded.Split(',').ToList()[1].Split(':').ToList()[1];
                string el = elements.Remove(elements.Length - 1);
                var userApproved = _context.Users.Where(u => (u.Administrator == true) && (u.Id == Convert.ToInt32(el))).ToList();
                if (userApproved.Count == 0)
                {
                    if(Authentification_Token == AdminJWT)
                    {
                        return _context.Users.ToList();
                    }
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
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string elements = jwtDecoded.Split(',').ToList()[1].Split(':').ToList()[1];
                string el = elements.Remove(elements.Length - 1);
                var userApproved = _context.Users.Where(u => (u.Administrator == true) && (u.Id == Convert.ToInt32(el))).ToList();
                var user = _context.Users.Where(u => u.Email == email).FirstOrDefault();
                if (userApproved.Count == 0)
                {
                    if (Authentification_Token == AdminJWT)
                    {
                        return user;
                    }
                    return Forbid();
                }
                else
                {
                    if (user == null)
                    {
                        return NotFound(new Error("User doesn't exists"));
                    }

                    return user;
                }
            }

        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public IActionResult PutUser([FromBody] User user, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                if (!UserExists(Cryptography.HashString(user.Email)))
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
            List<User> user = _context.Users.Where(u => u.Email == Cryptography.HashString(userCredentials.Email) && u.Password == Cryptography.HashString(userCredentials.Password)).ToList();
            if (user.Count != 0)
            {
                List<string> response = new List<string>();
                response.Add(JWT.CreateJWT(user[0].Id, 1));
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
            if (!InputValidationOperations.ArePasswordsEqual(user.Password, user.ConfirmPassword))
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
                jsonResponse.Add(JWT.CreateJWT(newUser.Id, 1));
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
            return JWT.CheckJWT(jwtToken);
        }

        [HttpDelete("{email}")]
        public IActionResult DeleteUser(string email, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            List<User> user = new List<User>();
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string elements = jwtDecoded.Split(',').ToList()[1].Split(':').ToList()[1];
                string el = elements.Remove(elements.Length - 1);
                var userApproved = _context.Users.Where(u => (u.Administrator == true) && (u.Id == Convert.ToInt32(el))).ToList();
                if (userApproved.Count == 0)
                {
                    if(Authentification_Token == AdminJWT)
                    {
                        user = _context.Users.Where(u => u.Email == Cryptography.HashString(email)).ToList();
                        if (user.Count == 0)
                        {
                            return NotFound(new Error("User doesn't exists"));
                        }

                        _context.Users.Remove(user[0]);
                        _context.SaveChanges();
                        return NoContent();
                    }
                    return Forbid();
                }
                else
                {
                    user = _context.Users.Where(u => u.Email == Cryptography.HashString(email)).ToList();
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

    }
}
