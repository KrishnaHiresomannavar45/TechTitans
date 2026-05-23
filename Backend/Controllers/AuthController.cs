using Booking.Data;
using Booking.DTOs;
using Booking.Interfaces;
using Booking.Models;

using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ITokenService _tokenService;

        public AuthController(
            ApplicationDbContext context,
            ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        // REGISTER
        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            // Check existing email
            var existingUser = _context.Users
                .FirstOrDefault(x => x.Email == dto.Email);

            if (existingUser != null)
            {
                return BadRequest("Email already exists");
            }

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                Phone = dto.Phone,
                Role = "Customer"
            };

            _context.Users.Add(user);

            _context.SaveChanges();

            return Ok(new
            {
                Message = "User registered successfully"
            });
        }

        // LOGIN
        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _context.Users
                .FirstOrDefault(x =>
                    x.Email == dto.Email &&
                    x.Password == dto.Password);

            if (user == null)
            {
                return Unauthorized("Invalid email or password");
            }

            var token = _tokenService.CreateToken(
                user.Email,
                user.Role);

            return Ok(new
            {
                Token = token,
                User = user.Name,
                Role = user.Role
            });
        }
    }
}