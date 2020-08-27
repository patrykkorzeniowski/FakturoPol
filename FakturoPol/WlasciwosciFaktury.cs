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
            this.TerminPlatnosci_comboBox1.Items.AddRange(new[] { "7", "14", "30" });
            this.MetodaPlatnosci_comboBox2.Items.AddRange(new[] { "gotówka", "karta", "przelew" });
            this.Jednostka_comboBox3.Items.AddRange(new[] { "Kilogram", "Litr", "Sztuka" });
            this.VAT_comboBox4.Items.AddRange(new[] { "0", "5", "8", "23" });
        }

        private void WybierzKontrahenta_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NowaFaktura_button1_Click(object sender, EventArgs e)
        {
            using (var db = new FakturoPolDbContext())
            {
                Faktura nowaFaktura = new Faktura()
                {
                    Numer = Numer_textBox1.Text,
                    Netto = float.Parse(Netto_richTextBox4.Text),
                    Brutto = float.Parse(Brutto_richTextBox5.Text),
                    DataSprzedazy = DataSprzedazy_dateTimePicker2.Value,
                    DataWystawienia = DataWystawienia_dateTimePicker1.Value,
                    Ilosc = Convert.ToInt32(Ilosc_richTextBox3.Text),
                    JednostkaMiary = Jednostka_comboBox3.Text,
                    KontrahentId = 1,
                    MetodaPlatnosci = MetodaPlatnosci_comboBox2.Text,
                    Podatek = float.Parse(Podatek_richTextBox6.Text),
                    Opis = Opis_richTextBox1.Text,
                    VAT = Convert.ToInt32(VAT_comboBox4.Text)
                };
                nowaFaktura.TerminPlatnosci = nowaFaktura.DataWystawienia.AddDays(Convert.ToDouble(TerminPlatnosci_comboBox1.Text));
                db.Faktury.Add(nowaFaktura);
                db.SaveChanges();
                //try
                //{
                //    Kontrahent k1 = new Kontrahent() { NIP = "1251699020", Nazwa = "Test", Miasto = "Mrk", Ulica = "Testowa", NumerLokalu = "12a", KodPocztowy = "02-222" };
                //    db.Kontrahenci.Add(k1);
                //    db.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

            }
        }

        private void TerminPlatnosci_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetodaPlatnosci_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Jednostka_comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ilosc_richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void VAT_comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Brutto_richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Podatek_richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
