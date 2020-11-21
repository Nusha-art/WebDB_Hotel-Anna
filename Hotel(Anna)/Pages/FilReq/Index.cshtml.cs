using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;
using Hotel_Anna_.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hotel_Anna_.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly Hotel_Anna_.Data.Hotel_Anna_Context _context;

        public IndexModel(Hotel_Anna_.Data.Hotel_Anna_Context context)
        {
            _context = context;
        }

        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelNom { get; set; }
        public List<SelectListItem> SelVmest { get; set; }

        public IActionResult OnGet()
        {
            SelPosition = _context.Positions.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name_of_the_position
            }).ToList();

            SelNom = _context.Rooms.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Appellation
            }).ToList();
            SelVmest = _context.Rooms.Select(p =>
            new SelectListItem
            {
                Value = p.Capacity.ToString(),
                Text = p.Capacity
            }).ToList();
            return Page();
        }
    }
}
