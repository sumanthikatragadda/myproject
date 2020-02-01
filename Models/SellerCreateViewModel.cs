using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class SellerCreateViewModel
    {
        [Key]
        public int Sid { get; set; }


        public string Sname { get; set; }
        public string Companyname { get; set; }
        public string Website { get; set; }

        public string Semail { get; set; }
        public string Spassword { get; set; }
        public string Saddress { get; set; }
        public int Contactno { get; set; }
         public IFormFile Photopath { get; set; }
        public SellerCreateViewModel()
        {

        }

    }
}
