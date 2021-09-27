
using Microsoft.EntityFrameworkCore;
using Sonacid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Models
{
    public class SonacidDbContext:DbContext
    {
        public SonacidDbContext(DbContextOptions<SonacidDbContext> options):base(options)
        {

        }
        public DbSet<Masse_Lineique_I> MLI { get; set; }
        public DbSet<Masse_Lineique_II> MLII { get; set; }
        public DbSet<H_V> HV { get; set; }
        public DbSet<COURONNES> Couronnes { get; set; }
        public DbSet<FARDEAUX> Fardeaux { get; set; }

    }
}
