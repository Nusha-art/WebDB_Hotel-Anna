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
    public class DetailsModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public DetailsModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public Clients Clients { get; set; }
        public Rooms Rooms { get; set; }
        public Hotel.Models.Employee Employee { get; set; }
        public Hotel.Models.Services Services1 { get; set; }
        public Hotel.Models.Services Services2 { get; set; }
        public Hotel.Models.Services Services3 { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Clients = await _context.Clients.FirstOrDefaultAsync(m => m.ID == id);

            if (Clients == null)
            {
                return NotFound();
            }
            Rooms = await _context.Rooms.FirstOrDefaultAsync(m => m.ID == Clients.RoomID);
            
            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.ID == Clients.EmployeeID);
            
            Services1 = await _context.Services.FirstOrDefaultAsync(m => m.ID == Clients.Service1ID);
            
            Services2 = await _context.Services.FirstOrDefaultAsync(m => m.ID == Clients.Service2ID);
            
            Services3 = await _context.Services.FirstOrDefaultAsync(m => m.ID == Clients.Service3ID);
            
            return Page();
        }
    }
}
