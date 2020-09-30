using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Provider.EntityFramework
{
    public class Context : DbContext
    {
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Campagne> Campagne { get; set; }

        //public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=.;Initial Catalog=IHM-C-Sharp;Integrated Security=SSPI");
    }
}
