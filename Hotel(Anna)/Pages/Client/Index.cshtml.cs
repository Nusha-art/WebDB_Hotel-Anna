using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;
using Hotel_Anna_.Data;

namespace Hotel_Anna_.Pages.Client
{
    public class IndexModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public IndexModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public IList<Clients> Clients { get;set; }
        public IList<Rooms> Rooms { get;set; }
        public IList<Hotel.Models.Employee> Employee { get;set; }
        public IList<Hotel.Models.Services> Services { get;set; }

        public async Task OnGetAsync()
        {
            Clients = await _context.Clients.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Services = await _context.Services.ToListAsync();
           Rooms = await _context.Rooms.ToListAsync();
        }
    }
}
