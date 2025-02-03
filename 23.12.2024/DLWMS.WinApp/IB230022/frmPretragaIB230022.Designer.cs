namespace DLWMS.WinApp.IB230022
{
    partial class frmPretragaIB230022
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
            label1 = new Label();
            cmbSemestar = new ComboBox();
            dgv = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            ProsjecnaOcjena = new DataGridViewTextBoxColumn();
            Uloga = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            dtpod = new DateTimePicker();
            label2 = new Label();
            cmbUloga = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dtpdo = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Semestar";
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(80, 35);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(174, 28);
            cmbSemestar.TabIndex = 1;
            cmbSemestar.SelectionChangeCommitted += cmbSpol_SelectionChangeCommitted;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, DatumRodjenja, ProsjecnaOcjena, Uloga, Aktivan, Poruke });
            dgv.Location = new Point(12, 69);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1227, 215);
            dgv.TabIndex = 2;
            dgv.CellClick += dgv_CellClick;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "BrojIndeksa";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezimeGodina";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // ProsjecnaOcjena
            // 
            ProsjecnaOcjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            ProsjecnaOcjena.HeaderText = "Prosječna ocjena";
            ProsjecnaOcjena.MinimumWidth = 6;
            ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            ProsjecnaOcjena.ReadOnly = true;
            // 
            // Uloga
            // 
            Uloga.DataPropertyName = "Uloga";
            Uloga.HeaderText = "Uloga";
            Uloga.MinimumWidth = 6;
            Uloga.Name = "Uloga";
            Uloga.ReadOnly = true;
            Uloga.Width = 125;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // Poruke
            // 
            Poruke.HeaderText = "";
            Poruke.MinimumWidth = 6;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            Poruke.Width = 125;
            // 
            // dtpod
            // 
            dtpod.Location = new Point(650, 35);
            dtpod.Name = "dtpod";
            dtpod.Size = new Size(283, 27);
            dtpod.TabIndex = 3;
            dtpod.ValueChanged += dtpod_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 37);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "uloga";
            // 
            // cmbUloga
            // 
            cmbUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUloga.FormattingEnabled = true;
            cmbUloga.Location = new Point(314, 34);
            cmbUloga.Name = "cmbUloga";
            cmbUloga.Size = new Size(179, 28);
            cmbUloga.TabIndex = 1;
            cmbUloga.SelectionChangeCommitted += cmbUloga_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 38);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 4;
            label3.Text = "rođen u periodu od: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(937, 40);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 5;
            label4.Text = "do";
            // 
            // dtpdo
            // 
            dtpdo.Location = new Point(970, 37);
            dtpdo.Name = "dtpdo";
            dtpdo.Size = new Size(269, 27);
            dtpdo.TabIndex = 3;
            dtpdo.ValueChanged += dtpdo_ValueChanged;
            // 
            // frmPretragaIB230022
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 313);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpdo);
            Controls.Add(dtpod);
            Controls.Add(dgv);
            Controls.Add(cmbUloga);
            Controls.Add(label2);
            Controls.Add(cmbSemestar);
            Controls.Add(label1);
            Name = "frmPretragaIB230022";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmPretragaIB230022_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbSemestar;
        private DataGridView dgv;
        private DateTimePicker dtpod;
        private Label label2;
        private ComboBox cmbUloga;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpdo;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn ProsjecnaOcjena;
        private DataGridViewTextBoxColumn Uloga;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Poruke;
    }
}