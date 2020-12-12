
using Microsoft.AspNetCore.Mvc;
using UserManagementMicroservice.Data;
using UserManagementMicroservice.Entities;
using System.Collections.Generic;
using System.Linq;

namespace UserManagementMicroservice.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly DataContext _context;

        public UserController(DataContext context)
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
        public IActionResult PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if (!UserExists(id))
            {
                return NotFound();
            }

            _context.Update(user);
            _context.SaveChanges();

            return NoContent();
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
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
    }
}
