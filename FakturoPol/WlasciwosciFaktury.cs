using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturoPol
{
    public partial class WlasciwosciFaktury : Form
    {
        public WlasciwosciFaktury()
        {
            InitializeComponent();
        }

        private void WybierzKontrahenta_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NowaFaktura_button1_Click(object sender, EventArgs e)
        {
            using (var db = new FakturoPolDbContext())
            {
                try
                {








                    Kontrahent k1 = new Kontrahent() { NIP = "1251699020", Nazwa = "Test", Miasto = "Mrk", Ulica = "Testowa", NumerLokalu = "12a", KodPocztowy = "02-222" };
                    db.Kontrahenci.Add(k1);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
