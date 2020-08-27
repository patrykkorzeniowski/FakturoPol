using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturoPol
{
    public class Faktura
    {
        [Key]
        public string Numer { get; set; }
        public int KontrahentId { get; set; }
        public DateTime DataWystawienia { get; set; }
        public DateTime DataSprzedazy { get; set; }
        public DateTime TerminPlatnosci { get; set; }
        public string MetodaPlatnosci { get; set; }
        public string JednostkaMiary { get; set; }
        public int Ilosc { get; set; }
        public float Netto { get; set; }
        public int VAT { get; set; }
        public float Brutto { get; set; }
        public float Podatek { get; set; }
        public string Opis { get; set; }
        [NotMapped]
        public virtual Kontrahent Kontrahent { get; set; }



    }
}
