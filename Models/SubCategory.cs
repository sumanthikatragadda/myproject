using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class SubCategory:Category
    {
        private int sub_id;
        private string sub_name;
        private float gST;
        [Key]
        public int Sub_id { get => sub_id; set => sub_id = value; }
        public string Sub_name { get => sub_name; set => sub_name = value; }
        public float GST { get => gST; set => gST = value; }

        public SubCategory(int Category_id, string Category_name, String Description, int sub_id, string sub_name, float GST) : base(Category_id, Category_name, Description)
        {
            this.Sub_id = Sub_id;
            this.Sub_name = Sub_name;
            this.Category_id = Category_id;
            this.Category_name = Category_name;
            this.Description = Description;
            this.GST = GST;
        }
    }
}
