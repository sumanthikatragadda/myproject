using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class BuyerContext:DbContext
    {
        public BuyerContext(DbContextOptions<BuyerContext> options) : base(options)
        {

        }
        public DbSet<Buyer> Buyers { get; set; }
    }
}
