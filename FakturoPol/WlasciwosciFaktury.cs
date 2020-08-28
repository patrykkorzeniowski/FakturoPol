using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturoPol
{
    public partial class WlasciwosciFaktury : Form
    {
        delegate Task DelegatZadania();
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

            Thread thread = new Thread(new ParameterizedThreadStart(WyodrebnijSymulacjeDlugiegoZapisu));
            thread.Start(nowaFaktura);
        }

        private void WyodrebnijSymulacjeDlugiegoZapisu(object faktura)
        {
            Faktura nowaFaktura = (Faktura)faktura;
            timer1.Start();

            Task.WhenAll(new[] { DodajFakture(nowaFaktura), CheckTimer() });
            timer1.Stop();
        }

        private async Task CheckTimer()
        {
            if (textBox1.InvokeRequired)
            {
                DelegatZadania d = CheckTimer;
                this.Invoke(d);
            }
            else
            {

                if (Convert.ToInt32(textBox1.Text) < 400)
                {
                    Task.Delay(10).Wait();
                    int zegar = Convert.ToInt32(textBox1.Text) + 1;
                    textBox1.Text = zegar.ToString();
                    await CheckTimer();
                }
            }

        }
        private async Task DodajFakture(Faktura faktura)
        {
            using (var db = new FakturoPolDbContext())
            {
                db.Faktury.Add(faktura);
                await db.SaveChangesAsync();
                this.Hide();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zegar = Convert.ToInt32(textBox1.Text) + 1;
            textBox1.Text = zegar.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void WlasciwosciFaktury_Load(object sender, EventArgs e)
        {

        }
    }
}
