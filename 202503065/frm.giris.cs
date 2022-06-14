using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503065
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        public static string gonder;
        SqlConnection con = new SqlConnection("Data source=localhost\\SQLExpress;Initial Catalog=tbl_krediotomasyon;Integrated Security=True");
        
        public  void frm_giris_Load(object sender, EventArgs e)
        { 
          timer1.Start();
            

    }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
           lbl_tarih.Text = DateTime.Now.ToLongDateString();
           lbl_saat.Text = DateTime.Now.ToLongTimeString();
        }

        public void btn_giris_Click(object sender, EventArgs e)

        {

            
            if (msktxt_tc.Text == "")
            {
                MessageBox.Show("Lütfen TC kimliğinizi giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                gonder = msktxt_tc.Text;
                con.Open();
                SqlCommand komut1 = new SqlCommand("select * from tbl_kredimüşteri where tcno=@tcno1 and parola=@parola1",con);
                komut1.Parameters.AddWithValue("@tcno1", msktxt_tc.Text);
                komut1.Parameters.AddWithValue("@parola1", txt_parola.Text);
                SqlDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    Frmbanka frm1 = new Frmbanka();
                    frm1.Show();
                    this.Hide();
                    DialogResult result1 = MessageBox.Show("Lütfen banka seçiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();

                
               
            }   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
              
                txt_parola.PasswordChar = '\0';
            }
            
            else
            {
             
                txt_parola.PasswordChar = '*';
            }
        }

        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            frm_kayıtol frmkayıt=new frm_kayıtol();
            frmkayıt.Show();    
        }

        private void lbl_sifreunut_Click(object sender, EventArgs e)
        {
            frm_sifreunuttum frm7 =new frm_sifreunuttum();
            frm7.Show();
        }
    }
}
