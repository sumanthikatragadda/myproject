using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Seller
    {
        private int sid;
        string sname;
        private string spassword;
        string companyname;
        string saddress;
        string website;
        string semail;
        int contactno;

        
        public string Sname { get => sname; set => sname = value; }
        public string Companyname { get => Companyname1; set => Companyname1 = value; }
        public string Website { get => website; set => website = value; }
        public string Companyname1 { get => companyname; set => companyname = value; }
        public string Semail { get => semail; set => semail = value; }   
        public string Spassword { get => spassword; set => spassword = value; }
        public string Saddress { get => saddress; set => saddress = value; }
        public int Contactno { get => contactno; set => contactno = value; }
        public int Sid { get => sid; set => sid = value; }

        public Seller(int Sid,string Sname,string Spassword,string companyname,string Saddress,string Website,string Semail,int contactno )
        {
            this.Sid = Sid;
            this.Sname = Sname;
            this.Spassword = Spassword;
            this.Companyname = Companyname;
            this.Saddress = Saddress;
            this.Website = Website;
            this.Semail = Semail;
            this.Contactno = Contactno;
        }
    }

    class SellerBO
    {
        static List<Seller> blist = new List<Seller>();
        public void Signup(int sid, string sname, string spassword, string companyname, string saddress, string website, string semail, int contactno)
        {
            // List<Buyer> b = new List<Buyer>();
            blist.Add(new Seller(sid, sname, spassword, companyname, saddress,website, semail, contactno));


        }
        public bool Login(int bId, string password)
        {

            Seller so = blist.Find(e => e.Sid == bId && e.Spassword == password);
            if (so != null)
            {

                
                //Console.WriteLine("success");
                return true;
            }
            else
            {
                // Console.WriteLine("invalid.......SignIn");
                return false;

            }
        }

    }
}
