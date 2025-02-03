namespace DLWMS.WinApp.IB230022
{
    partial class frmNovaPorukaIB230022
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
            label1 = new Label();
            cmbPredmet = new ComboBox();
            dtpValidnost = new DateTimePicker();
            txtSadrzaj = new TextBox();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbHitnost = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(362, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 1;
            label1.Text = "Odaberite preedmet";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(8, 67);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(250, 28);
            cmbPredmet.TabIndex = 2;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(8, 138);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(250, 27);
            dtpValidnost.TabIndex = 3;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 293);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(253, 133);
            txtSadrzaj.TabIndex = 4;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(452, 266);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(94, 29);
            btnOdustani.TabIndex = 5;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(552, 266);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 115);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 7;
            label2.Text = "Poruka je validna do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 255);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 8;
            label3.Text = "Sadrzaj poruke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 187);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 9;
            label4.Text = "Hitnost poruke";
            // 
            // cmbHitnost
            // 
            cmbHitnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHitnost.FormattingEnabled = true;
            cmbHitnost.Items.AddRange(new object[] { "Visoka", "Srednja", "Niska" });
            cmbHitnost.Location = new Point(12, 212);
            cmbHitnost.Name = "cmbHitnost";
            cmbHitnost.Size = new Size(246, 28);
            cmbHitnost.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaPorukaIB230022
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(cmbHitnost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            Controls.Add(txtSadrzaj);
            Controls.Add(dtpValidnost);
            Controls.Add(cmbPredmet);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmNovaPorukaIB230022";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poruka";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbPredmet;
        private DateTimePicker dtpValidnost;
        private TextBox txtSadrzaj;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbHitnost;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
    }
}