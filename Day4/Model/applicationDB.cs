using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace Day4.Model
{
    public class applicationDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-MQUDFCMH;user id=userLogin;password=password;database=userDataBase");
        }
        public DbSet<user> users { get; set; }
    }
}
