using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Announcements.Models
{
    public class AnnouncementContext : DbContext
        
    {
        public DbSet<Announcement> Announcements { get; set; }
        public AnnouncementContext(DbContextOptions<AnnouncementContext> option) : base(option)
        {

        }
    }
}
