namespace DLWMS.WinApp.IB230022
{
    partial class frmPorukeIB230022
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
            dgv = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Hitnost = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            lblStudent = new Label();
            btnPrintaj = new Button();
            btnNovaPoruka = new Button();
            groupBox1 = new GroupBox();
            btnDodaj = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpValidnost = new DateTimePicker();
            cmbPredmet = new ComboBox();
            txtInfo = new TextBox();
            txtBrojPoruka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Hitnost, Validnost, Brisi });
            dgv.Location = new Point(12, 103);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(857, 188);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            Sadrzaj.Width = 125;
            // 
            // Slika
            // 
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            Slika.Width = 125;
            // 
            // Hitnost
            // 
            Hitnost.DataPropertyName = "Hitnost";
            Hitnost.HeaderText = "Hitnost";
            Hitnost.MinimumWidth = 6;
            Hitnost.Name = "Hitnost";
            Hitnost.ReadOnly = true;
            Hitnost.Width = 125;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 6;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(9, 71);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(50, 20);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "label1";
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(719, 297);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(150, 29);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += button1_Click;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(730, 43);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(139, 29);
            btnNovaPoruka.TabIndex = 3;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Location = new Point(23, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(846, 277);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka";
            // 
            // btnDodaj
            // 
            btnDodaj.Enabled = false;
            btnDodaj.Location = new Point(11, 223);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(250, 29);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 152);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 7;
            label4.Text = "Poruka je validna do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 84);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 24);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Broj poruka";
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(11, 175);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(250, 27);
            dtpValidnost.TabIndex = 2;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(11, 107);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(250, 28);
            cmbPredmet.TabIndex = 1;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(267, 47);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(573, 205);
            txtInfo.TabIndex = 0;
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(11, 47);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(250, 27);
            txtBrojPoruka.TabIndex = 0;
            // 
            // frmPorukeIB230022
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 638);
            Controls.Add(groupBox1);
            Controls.Add(btnNovaPoruka);
            Controls.Add(btnPrintaj);
            Controls.Add(lblStudent);
            Controls.Add(dgv);
            Name = "frmPorukeIB230022";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poruke";
            Load += frmPorukeIB230022_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label lblStudent;
        private Button btnPrintaj;
        private Button btnNovaPoruka;
        private GroupBox groupBox1;
        private DateTimePicker dtpValidnost;
        private ComboBox cmbPredmet;
        private TextBox txtBrojPoruka;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDodaj;
        private TextBox txtInfo;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Hitnost;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
    }
}