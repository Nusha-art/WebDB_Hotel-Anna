using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Anna_.Pages.FilReq.Filter
{
    public class FilterPosModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public FilterPosModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }
        public Hotel.Models.Positions Position { get; set; }
        public IList<Hotel.Models.Employee> Employee { get; set; }
        

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Position = await _context.Positions.FirstOrDefaultAsync(m=>m.ID==id);
            if (Position == null)
            {
                return NotFound();
            }
            Employee = await _context.Employee.Where(m=>m.PositionID== Position.ID).ToListAsync();
            return Page();
        }
    }
}
