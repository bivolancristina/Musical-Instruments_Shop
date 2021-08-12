using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MIShop.Models;
using MusicData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Drums> Drums { get; set; }
        public DbSet<Flute> Flutes { get; set; }
        public DbSet<Violin> Violins { get; set; }

    }
}
