using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Authentication
{
    public partial class frm_Home : Form
    {
        public frm_Home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }

        private void btn_adduseradmin_Click(object sender, EventArgs e)
        {
            frm_Add_User_Admin fau = new frm_Add_User_Admin();
            fau.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login fl=new frm_login();
            fl.Show();
            this.Hide();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            if(ulog.type == "A")
            {
                btn_adduseradmin.Visible = true;
                
                btn_Edit_Grade.Visible = true;
                
                btn_checkgrade.Visible = true;
                
            }
            else if (ulog.type == "D")
            {
                btn_adduseradmin.Visible = false;
                
                btn_Edit_Grade.Visible = true;
               
                btn_checkgrade.Visible = true;
                
            }
            else if (ulog.type == "S")
            {

                btn_checkgrade.Visible = true;
                btn_adduseradmin.Visible = false;
                btn_Edit_Grade.Visible= false;
            }
        }

        private void lbl_loguser_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Grade_Click(object sender, EventArgs e)
        {
            frm_Edit_Grade fau = new frm_Edit_Grade();
            fau.ShowDialog();
        }

        private void btn_checkgrade_Click(object sender, EventArgs e)
        {
            frm_viewgrade fau = new frm_viewgrade();
            fau.ShowDialog();
        }
    }
}
