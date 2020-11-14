using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Services
    {
        public long ID { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Наименование")]
        public string Appellation { get; set; }
        [Display(Name = "Стоимость")]
        public int Price { get; set; }

    }
}
