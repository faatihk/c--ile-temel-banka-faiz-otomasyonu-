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
using System.Net;
using System.Net.Mail;
namespace _202503065
{
    public partial class frm_sifreunuttum : Form
    {
        public frm_sifreunuttum()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=localhost\\SQLExpress;Initial Catalog=tbl_krediotomasyon;Integrated Security=True");
            con.Open();
            SqlCommand cmd=new SqlCommand("select *from tbl_kredimüşteri where email=@mail ",con);
            cmd.Parameters.AddWithValue("@mail",txt_email.Text);
           SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();    
                    }
               
                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                string mailadresi = ("iste5353@gmail.com");
                string sifre = ("otomasyon.123");
                string smpt = "smtp.gmail.com";
                string kime = (txt_email.Text);
                string konu = ("şifre hatırlatma maili");
                string yaz = ("Sayın , " + dr["isim"].ToString() + "  " + dr["soyisim"].ToString()+"  "+" parolanız = " + dr["parola"].ToString());
                smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smpt;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadresi);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;    
                smtpserver.Send(mail);
                DialogResult bilgi = new DialogResult();
                bilgi = MessageBox.Show("Şifreniz maile gönderildi");
                    
                this.Hide();
                    break;
                    
                
               
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("Mail Gönderilmedi",Hata.Message);

                }

                frm_giris frm8 = new frm_giris();
                frm8.Show();
            }
        }

        private void frm_sifreunuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
