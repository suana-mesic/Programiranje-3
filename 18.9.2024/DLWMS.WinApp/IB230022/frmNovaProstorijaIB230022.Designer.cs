namespace DLWMS.WinApp.IB230022
{
    partial class frmNovaProstorijaIB230022
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            txtNaziv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOznaka = new TextBox();
            label3 = new Label();
            txtKapacitet = new TextBox();
            label4 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(431, 209);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(240, 72);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(285, 27);
            txtNaziv.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Logo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 49);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Naziv:";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(240, 148);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(126, 27);
            txtOznaka.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 125);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Oznaka:";
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(399, 148);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(126, 27);
            txtKapacitet.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 125);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Kapacitet:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaProstorijaIB230022
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 303);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKapacitet);
            Controls.Add(txtOznaka);
            Controls.Add(txtNaziv);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "frmNovaProstorijaIB230022";
            Text = "Podaci o prostoriji";
            Load += frmNovaProstorijaIB230022_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private TextBox txtNaziv;
        private Label label1;
        private Label label2;
        private TextBox txtOznaka;
        private Label label3;
        private TextBox txtKapacitet;
        private Label label4;
        private ErrorProvider err;
    }
}