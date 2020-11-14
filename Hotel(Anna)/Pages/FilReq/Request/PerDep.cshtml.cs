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
    public class PerDepModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public PerDepModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public IList<Hotel.Models.Positions> Position { get; set; }
        public IList<Hotel.Models.Employee> Employees { get; set; }
        public async Task OnGetAsync()
        {
            Position = await _context.Positions.ToListAsync();
            Employees = await _context.Employee.ToListAsync();
        }
    }
}