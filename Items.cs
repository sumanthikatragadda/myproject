using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Items
    {
            public int iid;
            public double price;
            public string itemname;
            public string description;
            public int stock_number;
            public string remarks;



            public Items(int iid, double price, string itemname, string description, int stock_number, string remarks)
            {
                this.iid = iid;
                this.price = price;
                this.itemname = itemname;
                this.description = description;
                this.stock_number = stock_number;
                this.remarks = remarks;
            }
    }
    class ItemsBO
    {
        static List<Items> li = new List<Items>();
        static List<SubCategory> sc = new List<SubCategory>();
        public void Additems(int Category_id, string Category_name, string Description,int sub_id, string sub_name,   float GST, int iid, string itemname, double price, string description, int stock_number, string remarks)
        {
            SubCategory sco = new SubCategory(Category_id, Category_name, Description, sub_id, sub_name, GST);
            sc.Add(sco);
            Items i = new Items(iid, price, itemname, description, stock_number, remarks);
            li.Add(i);
        }
        public void DisplayProducts()
        {
            foreach (Category i in sc)
            {
                Console.WriteLine("CategoryId :" + i.Category_id + "   Category Name :" + i.Category_name + "  Category Details :" + i.Description);
                //Console.WriteLine( "           "+i.cid + "             " + i.cname + "            " + i.details);
            }
            Console.WriteLine("\n \n Enter Categoryid to display the Subcategories");
            int cho = int.Parse(Console.ReadLine());
            foreach (SubCategory s in sc)
            {
                if (s.Category_id == cho)
                {
                    Console.WriteLine("SubCategory Id :" + s.Sub_id + "  SubCategory Name :" + s.Sub_name + "   SubCategory Gst :" + s.GST); ;
                    // Console.WriteLine("\t"+s.sbid+ " \t  " + s.sbname + " \t" + s.details);
                }
            }
            Console.WriteLine("\n \n Enter subcategory id to display the Items");
            int cho1 = int.Parse(Console.ReadLine());
            foreach (Items j in li)
            {
                if (j.iid == cho1)
                {
                    Console.WriteLine("Item Id :" + j.iid + "  IteamNeam  :" + j.itemname + "   stocknumber :" + j.stock_number + "   price :" + j.price + "   remarks :" + j.remarks);
                    //       Console.WriteLine(j.iid+"   " + j.itemname + "   " +j.stock_number +" "+j.price+"  "+j.remarks);
                }
            }
        }

    }
}
