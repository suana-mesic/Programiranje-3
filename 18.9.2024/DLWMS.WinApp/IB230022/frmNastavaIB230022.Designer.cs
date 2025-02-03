namespace DLWMS.WinApp.IB230022
{
    partial class Nastava
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
            dgvNastava = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            cmbPredmet = new ComboBox();
            label1 = new Label();
            cmbDan = new ComboBox();
            cmbVrijeme = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lblNaziv = new Label();
            button1 = new Button();
            bsPredmet = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPredmet).BeginInit();
            SuspendLayout();
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastava.Location = new Point(8, 143);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowHeadersWidth = 51;
            dgvNastava.Size = new Size(780, 188);
            dgvNastava.TabIndex = 0;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "NazivPredmeta";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            Vrijeme.Width = 125;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(8, 109);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(188, 28);
            cmbPredmet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 85);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Predmet";
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" });
            cmbDan.Location = new Point(229, 108);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(188, 28);
            cmbDan.TabIndex = 1;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "8 - 10", "10 - 12", "12 - 14", "14 - 16", "16 - 18", "18 - 20" });
            cmbVrijeme.Location = new Point(445, 108);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(188, 28);
            cmbVrijeme.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Dan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 85);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Vrijeme";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblNaziv.Location = new Point(8, 32);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(86, 35);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(683, 107);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 3;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Nastava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(button1);
            Controls.Add(lblNaziv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmet);
            Controls.Add(dgvNastava);
            Name = "Nastava";
            Text = "Nastava";
            Load += Nastava_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPredmet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNastava;
        private ComboBox cmbPredmet;
        private Label label1;
        private ComboBox cmbDan;
        private ComboBox cmbVrijeme;
        private Label label2;
        private Label label3;
        private Label lblNaziv;
        private Button button1;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
        private BindingSource bsPredmet;
    }
}