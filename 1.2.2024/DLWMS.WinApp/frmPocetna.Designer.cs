namespace DLWMS.WinApp
{
    partial class frmPocetna
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
            lblKonekcijaInfo = new Label();
            btnDrzaveIGradovi = new Button();
            btnPretraga = new Button();
            SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 13F);
            lblKonekcijaInfo.Location = new Point(409, 112);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 30);
            lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnDrzaveIGradovi
            // 
            btnDrzaveIGradovi.Location = new Point(246, 194);
            btnDrzaveIGradovi.Name = "btnDrzaveIGradovi";
            btnDrzaveIGradovi.Size = new Size(153, 43);
            btnDrzaveIGradovi.TabIndex = 3;
            btnDrzaveIGradovi.Text = "Ispit";
            btnDrzaveIGradovi.UseVisualStyleBackColor = true;
            btnDrzaveIGradovi.Click += btnDrzaveIGradovi_Click;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(246, 145);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(153, 43);
            btnPretraga.TabIndex = 3;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 279);
            Controls.Add(btnPretraga);
            Controls.Add(btnDrzaveIGradovi);
            Controls.Add(lblKonekcijaInfo);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Početna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnDrzaveIGradovi;
        private Button btnPretraga;
    }
}