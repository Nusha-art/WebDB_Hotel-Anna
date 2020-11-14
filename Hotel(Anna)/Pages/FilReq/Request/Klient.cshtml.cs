using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;
using Hotel_Anna_.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Hotel_Anna_.Pages.FilReq.Request
{
    public class KlientModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public KlientModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public IList<Hotel.Models.Rooms> Rooms { get; set; }
        public IList<Hotel.Models.Employee> Employees { get; set; }
        public IList<Hotel.Models.Clients> Clients { get; set; }
        public IList<Hotel.Models.Services> Services1 { get; set; }
        public IList<Hotel.Models.Services> Services2 { get; set; }
        public IList<Hotel.Models.Services> Services3 { get; set; }
        public async Task OnGetAsync()
        {
            Rooms = await _context.Rooms.ToListAsync();
            Employees = await _context.Employee.ToListAsync();
            Clients = await _context.Clients.ToListAsync();
            Services1 = await _context.Services.ToListAsync();
            Services2 = await _context.Services.ToListAsync();
            Services3 = await _context.Services.ToListAsync();
        }
    }
}
