using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Buyer
    {
        public int id;
        string name;
        string address;
        string mail;
        int phoneno;
        public string password;
        DateTime createddate;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Phoneno { get => phoneno; set => phoneno = value; }
        public string Password { get => password; set => password = value; }
        public DateTime CreatedDate { get; set; }

        public Buyer(int Id,string Name,string Address,string Mail,int Phoneno,string Password,DateTime CreatedDate)
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
    class BuyerBO
    {

        static List<Buyer> blist = new List<Buyer>();
        public void Signup(int Id, string Name,string Address, string Mail, int Phoneno,string Password, DateTime CreatedDate)
        {
           // List<Buyer> b = new List<Buyer>();
            blist.Add(new Buyer(Id, Name,Address,Mail,Phoneno, Password, CreatedDate));


        }
        public bool Login(int bId, string password)
        {

            Buyer bo = blist.Find(e => e.Id == bId && e.Password == password);
            if (bo != null)
            {

                // bb.InitializeBuyersList(bid, bname, Password, mobile, Email, CreatedDate);
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
