using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WielkieKino.Lib
{
    public class Film
    {
        public string Tytul { get; set; }
        public int CzasTrwania { get; set; }
        public string Gatunek { get; set; }

        [Key]
        public int ID { get; set; }

        public virtual List<Seans> Seanse { get; set; }

        public Film()
        {
            Seanse = new List<Seans>();
        }

    }
}
