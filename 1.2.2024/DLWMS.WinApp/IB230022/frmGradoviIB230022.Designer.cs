namespace DLWMS.WinApp.IB230022
{
    partial class frmGradoviIB230022
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblDrzava = new Label();
            txtNazivGrada = new TextBox();
            btnDodaj = new Button();
            dgv = new DataGridView();
            Generator = new GroupBox();
            txtBrojZapisa = new TextBox();
            cbAktivan = new CheckBox();
            btnGenerisi = new Button();
            label2 = new Label();
            txtInfo = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            NazivGrada = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            Generator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(186, 9);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(50, 20);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "label1";
            // 
            // txtNazivGrada
            // 
            txtNazivGrada.Location = new Point(206, 86);
            txtNazivGrada.Name = "txtNazivGrada";
            txtNazivGrada.Size = new Size(383, 27);
            txtNazivGrada.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(616, 85);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { NazivGrada, Aktivan, PromijeniStatus });
            dgv.Location = new Point(16, 120);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(772, 188);
            dgv.TabIndex = 4;
            dgv.CellClick += dgv_CellClick;
            // 
            // Generator
            // 
            Generator.Controls.Add(txtBrojZapisa);
            Generator.Controls.Add(cbAktivan);
            Generator.Controls.Add(btnGenerisi);
            Generator.Controls.Add(label2);
            Generator.Controls.Add(txtInfo);
            Generator.Location = new Point(16, 335);
            Generator.Name = "Generator";
            Generator.Size = new Size(772, 220);
            Generator.TabIndex = 5;
            Generator.TabStop = false;
            Generator.Text = "Generator";
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(100, 46);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(105, 27);
            txtBrojZapisa.TabIndex = 4;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(211, 49);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(76, 24);
            cbAktivan.TabIndex = 0;
            cbAktivan.Text = "Aktivni";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(293, 44);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Broj gradova:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 79);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(752, 121);
            txtInfo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 6;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NazivGrada
            // 
            NazivGrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivGrada.DataPropertyName = "Naziv";
            NazivGrada.HeaderText = "Naziv grada";
            NazivGrada.MinimumWidth = 6;
            NazivGrada.Name = "NazivGrada";
            NazivGrada.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivna";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            Aktivan.Width = 125;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromijeniStatus.HeaderText = "";
            PromijeniStatus.MinimumWidth = 6;
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.ReadOnly = true;
            PromijeniStatus.Text = "Promijeni status";
            PromijeniStatus.UseColumnTextForButtonValue = true;
            // 
            // frmGradoviIB230022
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(label1);
            Controls.Add(Generator);
            Controls.Add(dgv);
            Controls.Add(btnDodaj);
            Controls.Add(txtNazivGrada);
            Controls.Add(lblDrzava);
            Controls.Add(pictureBox1);
            Name = "frmGradoviIB230022";
            Text = "Podaci o gradovima";
            Load += frmGradoviIB230022_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            Generator.ResumeLayout(false);
            Generator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDrzava;
        private TextBox txtNazivGrada;
        private Button btnDodaj;
        private DataGridView dgv;
        private GroupBox Generator;
        private TextBox txtBrojZapisa;
        private CheckBox cbAktivan;
        private Button btnGenerisi;
        private Label label2;
        private TextBox txtInfo;
        private Label label1;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn NazivGrada;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromijeniStatus;
    }
}