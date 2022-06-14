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
    public partial class frm_faiz : Form
    {
        public frm_faiz()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection("Data source=localhost\\SQLExpress; Initial Catalog = tbl_krediotomasyon; Integrated Security = True");
        public static string bankaismi;
        private void frm_faiz_Load(object sender, EventArgs e)
        {


            con.Open();
            SqlCommand cmd = new SqlCommand("(select * from tbl_bankalar where bankalar=@bankaismi)", con);
            cmd.Parameters.AddWithValue("@bankaismi", bankaismi);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                txt_faiz.Text = dr[1].ToString();


            }

        }

        private void btn_kredihesapla_Click(object sender, EventArgs e)
        {
          

            double y = Convert.ToDouble(txt_kreditutar.Text);
            double v = Convert.ToDouble(txt_faiz.Text);
            double b = (y*v/10);
            double c =Convert.ToDouble(txt_vade.Text);
            lbl_faiztoplam.Text=Convert.ToString(b);
            lbl_maliyet.Text = Convert.ToString(b+y);
            lbl_aylıktaksit.Text=Convert.ToString( (b+y)/c);




            con.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmbanka frm122 = new Frmbanka();
            frm122.Show();
            this.Hide();
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_giris frm22 = new frm_giris();
            frm22.Show();
            this.Hide();
        }
    }
}
