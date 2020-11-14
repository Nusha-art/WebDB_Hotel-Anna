using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Anna_.Pages.FilReq.Filter
{
    public class FilNomModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public FilNomModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public Hotel.Models.Rooms Room { get; set; }

        public IList<Hotel.Models.Clients> Clients { get; set; }
        public IList<Hotel.Models.Employee> Employee { get; set; }
        public IList<Hotel.Models.Services> Services { get; set; }

        public async Task<IActionResult> OnGetAsync(long? ro)
        {
            if (ro == null)
            {
                return NotFound();
            }
            Room = _context.Rooms.First(m => m.ID == ro);
            if (Room == null)
            {
                return NotFound();
            }
            Clients = await _context.Clients.Where(m => m.RoomID == Room.ID).ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Services = await _context.Services.ToListAsync();
            
            return Page();
        }
    }
}
