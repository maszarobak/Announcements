using Announcements.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Announcements.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly AnnouncementContext _context;
        public AnnouncementController(AnnouncementContext context)
        {
            _context = context;
            
        }
        // GET: api/<AnnouncementController>
        [HttpGet]
        public IEnumerable<Announcement> GetAnnoucements()
        {
            return _context.Announcements.ToList();
        }

        // GET api/<AnnouncementController>/5
        [HttpGet("{id}")]
        public ActionResult<Announcement> GetAnnoucement(int id)
        {
            var Announcement = _context.Announcements.Find(id);
            if(Announcement == null)
            {
                return NotFound();
            }

            return Announcement;
        }

        // POST api/<AnnouncementController>
        [HttpPost]
        public ActionResult<Announcement> PostAnnouncement(Announcement announcement)
        {
            _context.Announcements.Add(announcement);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetAnnoucement), new { id = announcement.id }, announcement);
        }

        // PUT api/<AnnouncementController>/5
        [HttpPut("{id}")]
        public ActionResult<Announcement> PutAnnouncement(int id, Announcement announcement)
        {
            if(id != announcement.id)
            {
                return BadRequest();
            }
            _context.Announcements.Update(announcement);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<AnnouncementController>/5
        [HttpDelete("{id}")]
        public ActionResult<Announcement> DeleteAnnouncement(int id)
        {
            var Announcement = _context.Announcements.Find(id);
            if(Announcement == null)
            {
                return NotFound();
            }
            _context.Announcements.Remove(Announcement);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
