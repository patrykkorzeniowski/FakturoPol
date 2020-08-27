namespace FakturoPol
{
    partial class Glowny
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
            this.Wystaw_button1 = new System.Windows.Forms.Button();
            this.WybierzTyp_comboBox1 = new System.Windows.Forms.ComboBox();
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
            // Wystaw_button1
            // 
            this.Wystaw_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wystaw_button1.Location = new System.Drawing.Point(169, 89);
            this.Wystaw_button1.Name = "Wystaw_button1";
            this.Wystaw_button1.Size = new System.Drawing.Size(130, 24);
            this.Wystaw_button1.TabIndex = 2;
            this.Wystaw_button1.Text = "Dodaj";
            this.Wystaw_button1.UseVisualStyleBackColor = true;
            this.Wystaw_button1.Click += new System.EventHandler(this.Wystaw_button1_Click);
            // 
            // WybierzTyp_comboBox1
            // 
            this.WybierzTyp_comboBox1.FormattingEnabled = true;
            this.WybierzTyp_comboBox1.Location = new System.Drawing.Point(36, 89);
            this.WybierzTyp_comboBox1.Name = "WybierzTyp_comboBox1";
            this.WybierzTyp_comboBox1.Size = new System.Drawing.Size(127, 24);
            this.WybierzTyp_comboBox1.TabIndex = 4;
            this.WybierzTyp_comboBox1.Text = "Typ dokumentu";
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
            // Glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WybierzTyp_comboBox1);
            this.Controls.Add(this.Wystaw_button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.kontrahenci_listBox1);
            this.Name = "Glowny";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Glowny_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox kontrahenci_listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Wystaw_button1;
        private System.Windows.Forms.ComboBox WybierzTyp_comboBox1;
        private FakturoPolDataSet fakturoPolDataSet;
        private System.Windows.Forms.BindingSource fakturoPolDataSetBindingSource;
    }
}

