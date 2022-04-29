namespace Inchirieri_Masini
{
    partial class Interfata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfata));
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUtilizator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUtilizator.Location = new System.Drawing.Point(44, 257);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(73, 22);
            this.lblUtilizator.TabIndex = 0;
            this.lblUtilizator.Text = "Utilizator";
            this.lblUtilizator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblParola.Location = new System.Drawing.Point(54, 302);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(54, 20);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUtilizator.Location = new System.Drawing.Point(138, 254);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(184, 26);
            this.txtUtilizator.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtParola.Location = new System.Drawing.Point(135, 299);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(187, 26);
            this.txtParola.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(135, 376);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 56);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Acceseaza";
            this.btnLogin.UseMnemonic = false;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Interfata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 614);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfata";
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnLogin;
    }
}

