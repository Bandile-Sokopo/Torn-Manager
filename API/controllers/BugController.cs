using Api.Controllers;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.controllers
{
    public class BugController : BaseApiController
    {
        private readonly DataContext _context;
        public BugController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }
        [HttpGet("not-found")]
        public ActionResult<User> GetNotFound()
        {
            var item = _context.Users.Find(-1);

            if (item == null) return NotFound();
            return item;
        }
        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var item = _context.Users.Find(-1);

            var itemToReturn = item.ToString();

            return itemToReturn;
        }
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("This was not a good request");
        }
    }
}
