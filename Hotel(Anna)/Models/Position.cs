using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Positions
    {
        public long ID { get; set; }
        [Display(Name = "Обязанности")]
        public string Duties { get; set; }
        [Display(Name = "Наименование должности")]
        public string Name_of_the_position { get; set; }
        [Display(Name = "Оклад")]
        public int Salary { get; set; }
        [Display(Name = "Требования")]
        public string Requirements { get; set; }

    }
}
