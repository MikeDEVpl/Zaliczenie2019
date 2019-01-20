using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WielkieKino.Lib
{
    public class Seans
    {
        public DateTime Date { get; set; }
        public Sala Sala { get; set; }
        public Film Film { get; set; }

        [Key]
        public int ID { get; set; }

        public virtual List<Bilet> Bilety { get; set; }

        public Seans()
        {
            Bilety = new List<Bilet>();
        }
    }
}
