using JaysData.Entitties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaysData.MyDbContext
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customers1 { get; set; }
        public DbSet<Order> Order1 { get; set; }
    }
}
