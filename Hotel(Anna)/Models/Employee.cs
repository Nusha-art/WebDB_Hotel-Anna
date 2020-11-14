using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Employee
    {
        public long ID { get; set; }
        [Display(Name = "ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Паспортные данные")]
        public string Passport_data { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public int Telephone { get; set; }
        [Display(Name = "Код должности")]
        public long? PositionID { get; set; }
        [Display(Name = "Должность")]
        public DbSet<Positions> ID_Position { get; set; }

    }
}
