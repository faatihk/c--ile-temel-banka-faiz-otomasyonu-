namespace _202503065
{
    partial class frm_giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.lbl_sifreunut = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_giris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kayıtol = new System.Windows.Forms.Button();
            this.msktxt_tc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(679, 18);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(64, 22);
            this.lbl_tarih.TabIndex = 1;
            this.lbl_tarih.Text = "TARİH";
            this.lbl_tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(883, 18);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(58, 22);
            this.lbl_saat.TabIndex = 1;
            this.lbl_saat.Text = "SAAT";
            this.lbl_saat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.Location = new System.Drawing.Point(433, 145);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(275, 27);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "TC KİMLİK NUMARASI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(560, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "PAROLA :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(748, 267);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Parolayı Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(737, 217);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.PasswordChar = '*';
            this.txt_parola.Size = new System.Drawing.Size(167, 22);
            this.txt_parola.TabIndex = 1;
            // 
            // lbl_sifreunut
            // 
            this.lbl_sifreunut.AutoSize = true;
            this.lbl_sifreunut.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifreunut.ForeColor = System.Drawing.Color.Blue;
            this.lbl_sifreunut.Location = new System.Drawing.Point(458, 343);
            this.lbl_sifreunut.Name = "lbl_sifreunut";
            this.lbl_sifreunut.Size = new System.Drawing.Size(139, 20);
            this.lbl_sifreunut.TabIndex = 7;
            this.lbl_sifreunut.Text = "Şifremi Unuttum";
            this.lbl_sifreunut.Click += new System.EventHandler(this.lbl_sifreunut_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "2199089_enter_send_login_mail_icon.ico");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "1110960_essential_in_minus_round_set_icon.ico");
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giris.ImageIndex = 0;
            this.btn_giris.ImageList = this.ımageList1;
            this.btn_giris.Location = new System.Drawing.Point(748, 343);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(157, 58);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giriş yap";
            this.btn_giris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_202503065.Properties.Resources._871233;
            this.pictureBox1.Location = new System.Drawing.Point(57, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıtol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayıtol.ImageIndex = 0;
            this.btn_kayıtol.ImageList = this.ımageList2;
            this.btn_kayıtol.Location = new System.Drawing.Point(748, 433);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.Size = new System.Drawing.Size(157, 55);
            this.btn_kayıtol.TabIndex = 4;
            this.btn_kayıtol.Text = "Kayıt Ol";
            this.btn_kayıtol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayıtol.UseVisualStyleBackColor = true;
            this.btn_kayıtol.Click += new System.EventHandler(this.btn_kayıtol_Click);
            // 
            // msktxt_tc
            // 
            this.msktxt_tc.Location = new System.Drawing.Point(737, 150);
            this.msktxt_tc.MaxLength = 11;
            this.msktxt_tc.Name = "msktxt_tc";
            this.msktxt_tc.Size = new System.Drawing.Size(167, 22);
            this.msktxt_tc.TabIndex = 1;
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1001, 528);
            this.Controls.Add(this.btn_kayıtol);
            this.Controls.Add(this.lbl_sifreunut);
            this.Controls.Add(this.msktxt_tc);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.frm_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbl_sifreunut;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btn_kayıtol;
        private System.Windows.Forms.TextBox msktxt_tc;
    }
}

