namespace _202503065
{
    partial class frm_sifreunuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sifreunuttum));
            this.btn_sıfırla = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sıfırla.Location = new System.Drawing.Point(166, 239);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.Size = new System.Drawing.Size(475, 103);
            this.btn_sıfırla.TabIndex = 0;
            this.btn_sıfırla.Text = "ŞİFRE SIFIRLA";
            this.btn_sıfırla.UseVisualStyleBackColor = true;
            this.btn_sıfırla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(237, 128);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(417, 22);
            this.txt_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-MAİL ADRESİ =";
            // 
            // frm_sifreunuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(759, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_sıfırla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sifreunuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Sıfırla";
            this.Load += new System.EventHandler(this.frm_sifreunuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sıfırla;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
    }
}