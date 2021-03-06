﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hotel.Models;
using Hotel_Anna_.Data;

namespace Hotel_Anna_.Pages.Service
{
    public class CreateModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public CreateModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Services Services { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Services.Add(Services);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
