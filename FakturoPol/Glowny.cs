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

        private void Wystaw_button1_Click(object sender, EventArgs e)
        {
            if (WybierzTyp_comboBox1.SelectedItem.ToString() == "Faktura")
            {
                OtworzFormularzNowaFaktura();
            }
        }

        private void nowaFakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Nowa faktura")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                WlasciwosciFaktury otworzNowaFaktura = new WlasciwosciFaktury();
                otworzNowaFaktura.MdiParent = this;
                otworzNowaFaktura.Show();

            }
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
    }
}
