using Booking.Data;
using Booking.DTOs;
using Booking.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RoomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET ALL ROOMS
        [HttpGet]
        public IActionResult GetRooms()
        {
            var rooms = _context.Rooms.ToList();

            return Ok(rooms);
        }

        // GET ROOM BY ID
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var room = _context.Rooms.Find(id);

            if (room == null)
            {
                return NotFound("Room not found");
            }

            return Ok(room);
        }

        // ADD ROOM
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddRoom(RoomDto dto)
        {
            var room = new Room
            {
                RoomNumber = dto.RoomNumber,
                RoomType = dto.RoomType,
                Price = dto.Price,
                Capacity = dto.Capacity,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                IsAvailable = true
            };

            _context.Rooms.Add(room);

            _context.SaveChanges();

            return Ok(new
            {
                Message = "Room added successfully"
            });
        }

        // UPDATE ROOM
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult UpdateRoom(int id, RoomDto dto)
        {
            var room = _context.Rooms.Find(id);

            if (room == null)
            {
                return NotFound("Room not found");
            }

            room.RoomNumber = dto.RoomNumber;
            room.RoomType = dto.RoomType;
            room.Price = dto.Price;
            room.Capacity = dto.Capacity;
            room.Description = dto.Description;
            room.ImageUrl = dto.ImageUrl;

            _context.SaveChanges();

            return Ok(new
            {
                Message = "Room updated successfully"
            });
        }

        // DELETE ROOM
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var room = _context.Rooms.Find(id);

            if (room == null)
            {
                return NotFound("Room not found");
            }

            _context.Rooms.Remove(room);

            _context.SaveChanges();

            return Ok(new
            {
                Message = "Room deleted successfully"
            });
        }
    }
}