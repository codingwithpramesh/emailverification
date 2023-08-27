using emailverification.Data;
using emailverification.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace emailverification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        { 
            _context = context;
        }
    }

   /* [HttpPost("Register")]
    public async Task<IActionResult> Register(UserRegisterRequest Request)
    {
     

    } */
}
