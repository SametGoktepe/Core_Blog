using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Api.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7SGN3KM\\SAMETSQL;database=CoreBlog_Api_Db;Trusted_Connection=true;");
        }
        public DbSet<Person> Persons { get; set; }

    }
}
