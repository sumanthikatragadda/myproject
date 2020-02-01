using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ProjectMVC.Models
{
    public class Seller
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
        public string Photopath { get; set; }
        

      
        
        public Seller()
        {

        }

        public Seller(int Sid, string Sname, string Spassword, string Companyname, string Saddress, string Website, string Semail, int Contactno, string Photopath)
        {
            this.Sid = Sid;
            this.Sname = Sname;
            this.Spassword = Spassword;
            this.Companyname = Companyname;
            this.Saddress = Saddress;
            this.Website = Website;
            this.Semail = Semail;
            this.Contactno = Contactno;
            this.Photopath = Photopath;
        }
    }
}
