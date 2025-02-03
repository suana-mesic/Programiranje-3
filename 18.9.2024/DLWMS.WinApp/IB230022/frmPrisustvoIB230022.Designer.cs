namespace DLWMS.WinApp.IB230022
{
    partial class frmPrisustvoIB230022
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
            dgvPrisustvo = new DataGridView();
            PPPP = new DataGridViewTextBoxColumn();
            ss = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cmbNastava = new ComboBox();
            btnDodaj = new Button();
            groupBox1 = new GroupBox();
            txtBrojZapisa = new TextBox();
            btnGenerisi = new Button();
            txtInfo = new TextBox();
            label5 = new Label();
            cmbStudent = new ComboBox();
            label2 = new Label();
            lblRazlomak = new Label();
            lblProstorija = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPrisustvo
            // 
            dgvPrisustvo.AllowUserToAddRows = false;
            dgvPrisustvo.AllowUserToDeleteRows = false;
            dgvPrisustvo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustvo.Columns.AddRange(new DataGridViewColumn[] { PPPP, ss });
            dgvPrisustvo.Location = new Point(8, 133);
            dgvPrisustvo.Name = "dgvPrisustvo";
            dgvPrisustvo.ReadOnly = true;
            dgvPrisustvo.RowHeadersWidth = 51;
            dgvPrisustvo.Size = new Size(780, 291);
            dgvPrisustvo.TabIndex = 0;
            // 
            // PPPP
            // 
            PPPP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PPPP.DataPropertyName = "PPV";
            PPPP.HeaderText = "Predmet, prostorija, vrijeme";
            PPPP.MinimumWidth = 6;
            PPPP.Name = "PPPP";
            PPPP.ReadOnly = true;
            // 
            // ss
            // 
            ss.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ss.DataPropertyName = "StudentIIP";
            ss.HeaderText = "Student";
            ss.MinimumWidth = 6;
            ss.Name = "ss";
            ss.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 76);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Nastava";
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(8, 99);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(295, 28);
            cmbNastava.TabIndex = 2;
            cmbNastava.SelectedValueChanged += cmbNastava_SelectedValueChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(670, 98);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(118, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBrojZapisa);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(8, 447);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 189);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(92, 33);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(103, 27);
            txtBrojZapisa.TabIndex = 2;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(201, 33);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(8, 74);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(766, 115);
            txtInfo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 36);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 1;
            label5.Text = "Broj zapisa: ";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(325, 98);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(295, 28);
            cmbStudent.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Student";
            // 
            // lblRazlomak
            // 
            lblRazlomak.AutoSize = true;
            lblRazlomak.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRazlomak.Location = new Point(680, 30);
            lblRazlomak.Name = "lblRazlomak";
            lblRazlomak.Size = new Size(86, 35);
            lblRazlomak.TabIndex = 1;
            lblRazlomak.Text = "label1";
            // 
            // lblProstorija
            // 
            lblProstorija.AutoSize = true;
            lblProstorija.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblProstorija.Location = new Point(8, 30);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(86, 35);
            lblProstorija.TabIndex = 1;
            lblProstorija.Text = "label1";
            // 
            // frmPrisustvoIB230022
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 658);
            Controls.Add(groupBox1);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(lblProstorija);
            Controls.Add(lblRazlomak);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPrisustvo);
            Name = "frmPrisustvoIB230022";
            Text = "Evidencija nastave";
            Load += frmPrisustvoIB230022_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrisustvo;
        private Label label1;
        private ComboBox cmbNastava;
        private Button btnDodaj;
        private GroupBox groupBox1;
        private TextBox txtBrojZapisa;
        private Button btnGenerisi;
        private TextBox txtInfo;
        private Label label5;
        private ComboBox cmbStudent;
        private Label label2;
        private Label lblRazlomak;
        private Label lblProstorija;
        private DataGridViewTextBoxColumn PPPP;
        private DataGridViewTextBoxColumn ss;
    }
}