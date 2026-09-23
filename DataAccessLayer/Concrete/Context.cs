using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;database=TraverselDB;Integrated Security=True;");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-KQ884KE\\SQLEXPRESS;database=AdvenNewDB;Integrated Security=True;");
            optionsBuilder.UseSqlServer("Data Source=AKKUS;database=AdvenNewDB;Integrated Security=True;TrustServerCertificate=True");
            //add-migration mig1
            //update-database
        }


        public DbSet<Ayarlar> Ayarlars { get; set; }
        public DbSet<Haberler> Haberlers { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<Loglar> Loglars { get; set; }
        public DbSet<Mesajlar> Mesajlars { get; set; }
        public DbSet<Projeler> Projelers { get; set; }
        public DbSet<Referanslar> Referanslars { get; set; }
        public DbSet<Sliderlar> Sliderlars { get; set; }
        public DbSet<Surecler> Sureclers { get; set; }
        public DbSet<Bultenler> Bultenlers { get; set; }
    }
}
