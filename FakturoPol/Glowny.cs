using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturoPol
{
    public partial class Glowny : Form
    {
        public Glowny()
        {
            InitializeComponent();
            this.WybierzTyp_comboBox1.Items.Add("Faktura");
            this.WybierzTyp_comboBox1.Items.Add("Paragon Fiskalny");
            this.WybierzTyp_comboBox1.Items.Add("Nota księgowa");
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=FakturoPol;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand("Select * from Kontrahents", conn);
            conn.Open();
            SqlDataReader r = sql.ExecuteReader();
            while (r.Read())
            {
                kontrahenci_listBox1.Items.Add(r[2]);
            }
            conn.Close();
            PobierzListeFaktur();
        }

        private void Glowny_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void OtworzFormularzNowaFaktura()
        {
            NowaFaktura oknoFaktury = new NowaFaktura();
            oknoFaktury.ShowDialog();
        }
        private void OtworzFormularzNotaKsiegowa()
        {
            NowaNotaKsiegowa oknoNotyKsiegowej = new NowaNotaKsiegowa();
            oknoNotyKsiegowej.ShowDialog();
        }
        private void OtworzFormularzParagonFiskalny()
        {
            ParagonFiskalny oknoParagonuFiskalnego = new ParagonFiskalny();
            oknoParagonuFiskalnego.ShowDialog();
        }

        private void Wystaw_button1_Click(object sender, EventArgs e)
        {
            if (WybierzTyp_comboBox1.SelectedItem.ToString() == "Faktura")
            {
                OtworzFormularzNowaFaktura();
            }
            if (WybierzTyp_comboBox1.SelectedItem.ToString() == "Nota księgowa")
            {
                OtworzFormularzNotaKsiegowa();
            }
            if (WybierzTyp_comboBox1.SelectedItem.ToString() == "Paragon Fiskalny")
            {
                OtworzFormularzParagonFiskalny();
            }
        }


        private void nowaFakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WlasciwosciFaktury wf = new WlasciwosciFaktury();
            wf.ShowDialog();
        }

        private void autorPracyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PobierzListeFaktur()
        {
            using (var db = new FakturoPolDbContext())
            {
                listBox2.Items.Clear();
                foreach(var faktura in  db.Faktury.ToList())
                {
                        listBox2.Items.Add(faktura.Numer);
                }
            }
        }

        private void paragonFiskalnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParagonFiskalny pf = new ParagonFiskalny();
            pf.ShowDialog();

        }

        private void notaKsięgowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NowaNotaKsiegowa nk = new NowaNotaKsiegowa();
            nk.ShowDialog();
        }

        private void grafikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafika gr = new Grafika();
            gr.ShowDialog();
        }

        private void podziękowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podziekowania po = new Podziekowania();
            po.ShowDialog();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
