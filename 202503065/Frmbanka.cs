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
    public partial class Frmbanka : Form
    {
        
        public Frmbanka()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=localhost\\SQLExpress;Initial Catalog=tbl_krediotomasyon;Integrated Security=True");
        public static string tcnoc;
        private void Frmbanka_Load(object sender, EventArgs e)
        {
            tcnoc = frm_giris.gonder;



            con.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_kredimüşteri where tcno=@tcno1", con);
            komut.Parameters.AddWithValue("@tcno1",tcnoc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               lbl_ADSOYAD.Text = dr[2].ToString() + " " + dr[3].ToString();



            }
              con.Close();  
                   


             

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_giris frm9 = new frm_giris();
            frm9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_faiz.bankaismi = "DENİZBANK";
            frm_faiz frm10=new frm_faiz();
            frm10.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_faiz.bankaismi = "GARANTİ";
            frm_faiz frm10 = new frm_faiz();
            frm10.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_faiz.bankaismi = "QNB";
            frm_faiz frm10 = new frm_faiz();
            frm10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_faiz.bankaismi = "İŞBANKASI";
            frm_faiz frm10 = new frm_faiz();
            frm10.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_faiz.bankaismi = "TEB";
            frm_faiz frm10 = new frm_faiz();
            frm10.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_faiz.bankaismi = "ZİRAAT";
            frm_faiz frm10 = new frm_faiz();
            frm10.Show();
            this.Hide();
        }
    }
}
