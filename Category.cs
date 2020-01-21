using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    class Category
    {
        public int category_id;
        public string category_name;
        public string description;
       
       
        public Category(int Category_id, string Category_name, String Description)
        {
            this.Category_id = Category_id;
            this.Category_name = Category_name;
            this.Description = Description;
        }

        public int Category_id { get => category_id; set => category_id = value; }
        public string Category_name { get => category_name; set => category_name = value; }
        public string Description { get => description; set => description = value; }
    }
}
