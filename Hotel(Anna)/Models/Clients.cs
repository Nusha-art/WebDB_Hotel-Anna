using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Clients
    {
        public long ID { get; set; }
        [Display(Name ="ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Дата заселения")]
        public DateTime Check_in_date { get; set; }
        [Display(Name = "Дата выезда")]
        public DateTime Check_out_date { get; set; }
        [Display(Name = "Стоимость")]
        public string Price { get; set; }
        [Display(Name = "Паспортные данные")]
        public string Passport_data { get; set; }
        [Display(Name = "Код комнаты")]
        public long? RoomID { get; set; }
        [Display(Name = "Комната")]
        public DbSet<Rooms> Room { get; set; }
        [Display(Name = "Код сотрудника")]
        public long? EmployeeID { get; set; }
        [Display(Name = "Сотрудник")]
        public DbSet<Employee> Employee { get; set; }
        [Display(Name = "Код услуги 1")]
        public long? Service1ID { get; set; }
        [Display(Name = "Услуга 1")]
        public DbSet<Services> Service1 { get; set; }
        [Display(Name = "Код услуги 2")]
        public long? Service2ID { get; set; }
        [Display(Name = "Услуга 2")]
        public DbSet<Services> Service2 { get; set; }
        [Display(Name = "Код услуги 3")]
        public long? Service3ID { get; set; }
        [Display(Name = "Услуга 3")]
        public DbSet<Services> Service3 { get; set; }

    }
}