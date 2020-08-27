using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
