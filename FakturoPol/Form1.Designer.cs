namespace FakturoPol
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kontrahenci_listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Dodaj_comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fakturoPolDataSet = new FakturoPol.FakturoPolDataSet();
            this.fakturoPolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kontrahenci_listBox1
            // 
            this.kontrahenci_listBox1.FormattingEnabled = true;
            this.kontrahenci_listBox1.ItemHeight = 16;
            this.kontrahenci_listBox1.Location = new System.Drawing.Point(36, 125);
            this.kontrahenci_listBox1.Name = "kontrahenci_listBox1";
            this.kontrahenci_listBox1.Size = new System.Drawing.Size(263, 276);
            this.kontrahenci_listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(305, 125);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(468, 276);
            this.listBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Dodaj_comboBox1
            // 
            this.Dodaj_comboBox1.FormattingEnabled = true;
            this.Dodaj_comboBox1.Location = new System.Drawing.Point(36, 89);
            this.Dodaj_comboBox1.Name = "Dodaj_comboBox1";
            this.Dodaj_comboBox1.Size = new System.Drawing.Size(127, 24);
            this.Dodaj_comboBox1.TabIndex = 4;
            this.Dodaj_comboBox1.Text = "Wystaw";
            this.Dodaj_comboBox1.SelectedIndexChanged += new System.EventHandler(this.Dodaj_comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(172, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // fakturoPolDataSet
            // 
            this.fakturoPolDataSet.DataSetName = "FakturoPolDataSet";
            this.fakturoPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakturoPolDataSetBindingSource
            // 
            this.fakturoPolDataSetBindingSource.DataSource = this.fakturoPolDataSet;
            this.fakturoPolDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Dodaj_comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.kontrahenci_listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox kontrahenci_listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Dodaj_comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private FakturoPolDataSet fakturoPolDataSet;
        private System.Windows.Forms.BindingSource fakturoPolDataSetBindingSource;
    }
}

