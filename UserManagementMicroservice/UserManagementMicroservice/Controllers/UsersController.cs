
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

namespace UserManagementMicroservice.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).ToList();

            if (user == null)
            {
                return NotFound();
            }

            return user[0];
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutUser([FromBody]User user)
        {
            if (!UserExists(user.Id))
            {
                return NotFound();
            }

            _context.Update(user);
            _context.SaveChanges();

            return NoContent();
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<string> PostUser([FromBody]User user)
        {
            if (!UserExists(user.Id))
            {
                _context.Add(user);
                _context.SaveChanges();
                return CreateJWT(user);
            } 
            else
            {
                return Conflict();
            }
            
        }


        //Ruta test
        [Route("verify")]
        [HttpGet]
        public ActionResult<string> CheckUser(string jwtToken)
        {
            return CheckJWT(jwtToken);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).ToList();
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user[0]);
            _context.SaveChanges();

            return NoContent();
        }
        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        private string CreateJWT(User user)
        {
            var token = new JwtBuilder()
                           .WithAlgorithm(new HMACSHA256Algorithm())
                           .WithSecret("GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk")
                           .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                           .AddClaim("userId", user.Id)
                           .Encode();
            return token;
        }

        private string CheckJWT(string jwtToken)
        {
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                var provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

                var json = decoder.Decode(jwtToken, "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk", verify: true);
                Console.WriteLine(json);
            }
            catch (TokenExpiredException)
            {
                return "Token has expired";
            }
            catch (SignatureVerificationException)
            {
                return "Token has invalid signature";
            }
            return "Token Valid";
        }
    }
}
