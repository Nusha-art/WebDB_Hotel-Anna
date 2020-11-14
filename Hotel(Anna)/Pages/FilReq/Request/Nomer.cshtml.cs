using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hotel.Models;
using Hotel_Anna_.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Anna_.Pages.FilReq.Request
{
    public class NomerModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public NomerModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public IList<Hotel.Models.Rooms> Rooms { get; set; }
        public IList<Hotel.Models.Employee> Employees { get; set; }
        public async Task OnGetAsync()
        {
            Rooms = await _context.Rooms.ToListAsync();
            Employees = await _context.Employee.ToListAsync();
        }
    }
}
