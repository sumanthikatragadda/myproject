using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Buyer
    {
        [Key]
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        //[RegularExpression(@"[6-9]\d{9}", ErrorMessage = "invalid mobile no")]
        public int Phoneno { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public Buyer()
        {

        }

        public Buyer(int Id, string Name, string Address, string Mail, int Phoneno, string Password, DateTime CreatedDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Mail = Mail;
            this.Phoneno = Phoneno;
            this.Password = Password;
            this.CreatedDate = CreatedDate;
        }
    }
}
