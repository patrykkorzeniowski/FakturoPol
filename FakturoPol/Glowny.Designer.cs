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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wystawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paragonFiskalnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaKsięgowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podziękowaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.grafikaToolStripMenuItem,
            this.podziękowaniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wystawToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wystawToolStripMenuItem
            // 
            this.wystawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fakturaToolStripMenuItem,
            this.paragonFiskalnyToolStripMenuItem,
            this.notaKsięgowaToolStripMenuItem});
            this.wystawToolStripMenuItem.Name = "wystawToolStripMenuItem";
            this.wystawToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.wystawToolStripMenuItem.Text = "Wystaw";
            // 
            // fakturaToolStripMenuItem
            // 
            this.fakturaToolStripMenuItem.Name = "fakturaToolStripMenuItem";
            this.fakturaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.fakturaToolStripMenuItem.Text = "Faktura";
            this.fakturaToolStripMenuItem.Click += new System.EventHandler(this.fakturaToolStripMenuItem_Click);
            // 
            // paragonFiskalnyToolStripMenuItem
            // 
            this.paragonFiskalnyToolStripMenuItem.Name = "paragonFiskalnyToolStripMenuItem";
            this.paragonFiskalnyToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.paragonFiskalnyToolStripMenuItem.Text = "Paragon Fiskalny";
            // 
            // notaKsięgowaToolStripMenuItem
            // 
            this.notaKsięgowaToolStripMenuItem.Name = "notaKsięgowaToolStripMenuItem";
            this.notaKsięgowaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.notaKsięgowaToolStripMenuItem.Text = "Nota księgowa";
            // 
            // grafikaToolStripMenuItem
            // 
            this.grafikaToolStripMenuItem.Name = "grafikaToolStripMenuItem";
            this.grafikaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.grafikaToolStripMenuItem.Text = "Grafika";
            // 
            // podziękowaniaToolStripMenuItem
            // 
            this.podziękowaniaToolStripMenuItem.Name = "podziękowaniaToolStripMenuItem";
            this.podziękowaniaToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.podziękowaniaToolStripMenuItem.Text = "Podziękowania :)";
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
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glowny";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Glowny_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturoPolDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kontrahenci_listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Wystaw_button1;
        private System.Windows.Forms.ComboBox WybierzTyp_comboBox1;
        private FakturoPolDataSet fakturoPolDataSet;
        private System.Windows.Forms.BindingSource fakturoPolDataSetBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wystawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paragonFiskalnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaKsięgowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podziękowaniaToolStripMenuItem;
    }
}

