using MBOapi.Database.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBOapi.Database
{
    public class MBOContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public MBOContext(DbContextOptions<MBOContext> options) : base(options)
        {
            
        }
    }
}
