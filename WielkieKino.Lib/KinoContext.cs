using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WielkieKino.Lib
{
    class KinoContext : DbContext
    {
        public DbSet<Bilet> Bilety{ get;set; }
        public DbSet<Film> Filmy { get; set; }
        public DbSet<Seans> Seanse { get; set; }
        public DbSet<Sala> Sale { get; set; }

    }
}
