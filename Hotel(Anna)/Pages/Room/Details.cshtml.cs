﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;
using Hotel_Anna_.Data;

namespace Hotel_Anna_.Pages.Room
{
    public class DetailsModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public DetailsModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public Rooms Rooms { get; set; }
        public Hotel.Models.Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rooms = await _context.Rooms.FirstOrDefaultAsync(m => m.ID == id);

            if (Rooms == null)
            {
                return NotFound();
            }
            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.ID == id);
            return Page();
        }
    }
}
