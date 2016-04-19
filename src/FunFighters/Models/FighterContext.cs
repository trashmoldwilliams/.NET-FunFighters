using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using FunFighters.Models;

namespace FunFighters.Models
{
    public class FunFightersContext : DbContext
    {
        public virtual DbSet<Fighter> fighters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=fighters.database.windows.net;Database=Fun_Fighters;integrated security=True;");
        }
    }
}