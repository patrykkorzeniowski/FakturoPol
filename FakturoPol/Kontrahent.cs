using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturoPol
{
    public class Kontrahent
    {
        public int KontrahentId { get; set; }
        public string NIP { get; set; }
        public string Nazwa { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NumerLokalu { get; set; }
        public string KodPocztowy { get; set; }
        
    }
}
