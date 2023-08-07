using System;
using System.Collections.Generic;
using System.Text;
using HastaneProjesi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HastaneProjesi.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Doktorlar> Doktorlar { get; set; }
        public DbSet<HastaGecmisi> HastaGecmisi { get; set; }
        public DbSet<HastaKabul> HastaKabul { get; set; }
        public DbSet<Hastalar> Hastalar { get; set; }
        public DbSet<Hastaneler> Hastaneler { get; set; }
        public DbSet<Tahliller> Tahliller { get; set; }
        public DbSet<HastaSikayeti> HastaSikayeti { get; set; }
        public DbSet<Ilaclar> Ilaclar { get; set; }
        public DbSet<KanGrubu> KanGrubu { get; set; }
        public DbSet<Poliniklik> Poliniklik { get; set; }
        public DbSet<Recete> Recete { get; set; }
        public DbSet<Unvanlar> Unvanlar { get; set; }
   

      
        
    }
}
