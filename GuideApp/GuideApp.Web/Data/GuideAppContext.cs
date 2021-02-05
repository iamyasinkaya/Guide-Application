using GuideApp.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuideApp.Web.Data
{
    public class GuideAppContext : DbContext
    {
        public GuideAppContext(DbContextOptions<GuideAppContext> options) : base (options)
        {

        }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
