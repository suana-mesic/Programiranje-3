namespace DLWMS.WinApp.IB230022
{
    partial class frmProstorijeIB230022
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProstorije = new DataGridView();
            btnNovaProstorija = new Button();
            btnPrintaj = new Button();
            Id = new DataGridViewTextBoxColumn();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrPredmeta = new DataGridViewTextBoxColumn();
            Nastava = new DataGridViewButtonColumn();
            Prisustvo = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).BeginInit();
            SuspendLayout();
            // 
            // dgvProstorije
            // 
            dgvProstorije.AllowUserToAddRows = false;
            dgvProstorije.AllowUserToDeleteRows = false;
            dgvProstorije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorije.Columns.AddRange(new DataGridViewColumn[] { Id, Logo, Naziv, Oznaka, Kapacitet, BrPredmeta, Nastava, Prisustvo });
            dgvProstorije.Location = new Point(0, 68);
            dgvProstorije.Name = "dgvProstorije";
            dgvProstorije.ReadOnly = true;
            dgvProstorije.RowHeadersWidth = 51;
            dgvProstorije.Size = new Size(927, 270);
            dgvProstorije.TabIndex = 0;
            dgvProstorije.CellClick += dgvProstorije_CellClick;
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(799, 33);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(128, 29);
            btnNovaProstorija.TabIndex = 1;
            btnNovaProstorija.Text = "Nova prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += btnNovaProstorija_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(833, 341);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Logo
            // 
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Logo.MinimumWidth = 6;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            Logo.Resizable = DataGridViewTriState.True;
            Logo.SortMode = DataGridViewColumnSortMode.Automatic;
            Logo.Width = 72;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Kapacitet
            // 
            Kapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 6;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            // 
            // BrPredmeta
            // 
            BrPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrPredmeta.DataPropertyName = "BrPredmeta";
            BrPredmeta.HeaderText = "Br. predmeta";
            BrPredmeta.MinimumWidth = 6;
            BrPredmeta.Name = "BrPredmeta";
            BrPredmeta.ReadOnly = true;
            // 
            // Nastava
            // 
            Nastava.HeaderText = "";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            Nastava.Text = "Nastava";
            Nastava.ToolTipText = "Nastava";
            Nastava.UseColumnTextForButtonValue = true;
            Nastava.Width = 125;
            // 
            // Prisustvo
            // 
            Prisustvo.HeaderText = "";
            Prisustvo.MinimumWidth = 6;
            Prisustvo.Name = "Prisustvo";
            Prisustvo.ReadOnly = true;
            Prisustvo.Text = "Prisustvo";
            Prisustvo.ToolTipText = "Prisustvo";
            Prisustvo.UseColumnTextForButtonValue = true;
            Prisustvo.Width = 125;
            // 
            // frmProstorijeIB230022
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 405);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaProstorija);
            Controls.Add(dgvProstorije);
            Name = "frmProstorijeIB230022";
            Text = "Prostorije";
            Load += frmProstorijeIB230022_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProstorije;
        private Button btnNovaProstorija;
        private Button btnPrintaj;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrPredmeta;
        private DataGridViewButtonColumn Nastava;
        private DataGridViewButtonColumn Prisustvo;
    }
}