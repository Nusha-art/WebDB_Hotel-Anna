using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Anna_.Pages.FilReq.Filter
{
    public class FilVmestModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public FilVmestModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public IList<Hotel.Models.Rooms> Rooms { get; set; }
        public IList<Hotel.Models.Employee> Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(string? vm)
        {
            if (vm == null)
            {
                return NotFound();
            }
            Rooms = await _context.Rooms.Where(m => m.Capacity == vm).ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            if (Rooms == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
