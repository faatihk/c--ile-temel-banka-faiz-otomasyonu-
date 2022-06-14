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
    public partial class frm_kayıtol : Form
    {
        public frm_kayıtol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=localhost\\SQLExpress;Initial Catalog=tbl_krediotomasyon;Integrated Security=True");
        private void frm_kayıtol_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_kayıt_kayıt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_kredimüşteri(tcno,isim,soyisim,parola,email)values(@tcno,@isim,@soyisim,@parola,@email)", con);
            cmd.Parameters.AddWithValue("@tcno", txt_kayıttc.Text.ToUpper());
            cmd.Parameters.AddWithValue("isim", txt_kayitisim.Text.ToUpper());
            cmd.Parameters.AddWithValue("@soyisim", txt_kayitsoyisim.Text.ToUpper());
            cmd.Parameters.AddWithValue("@parola", txt_kayitparola.Text);
            cmd.Parameters.AddWithValue("@email", txt_kayitemail.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("   Kayıt Eklendi  ", " Kayıt Eklendi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Hide();
            frm_giris frm5 = new frm_giris();
            frm5.Show();
        }
    }
}
