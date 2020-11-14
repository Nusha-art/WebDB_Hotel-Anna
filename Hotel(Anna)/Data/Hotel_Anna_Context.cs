using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;

namespace Hotel_Anna_.Data
{
    public class Hotel_Anna_Context : DbContext
    {
        public Hotel_Anna_Context (DbContextOptions<Hotel_Anna_Context> options)
            : base(options)
        {
        }

        public DbSet<Hotel.Models.Employee> Employee { get; set; }

        public DbSet<Hotel.Models.Clients> Clients { get; set; }

        public DbSet<Hotel.Models.Positions> Positions { get; set; }

        public DbSet<Hotel.Models.Rooms> Rooms { get; set; }

        public DbSet<Hotel.Models.Services> Services { get; set; }
    }
}
