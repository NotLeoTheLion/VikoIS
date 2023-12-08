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
using User_Authentication.AppDataTableAdapters;

namespace User_Authentication
{
    public partial class frm_Add_User_Admin : Form
    {
        public frm_Add_User_Admin()
        {
            InitializeComponent();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jgluk\\OneDrive\\Stalinis kompiuteris\\Praktika\\User Authentication\\User Authentication\\uaDB.mdf\";Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            tbllogTableAdapter.Adapter.UpdateCommand = new SqlCommand(
                "UPDATE tbllog SET UserName = @UserName, Password = @Password, Role = @Role WHERE ID = @ID", connection);

            tbllogTableAdapter.Adapter.UpdateCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 50, "UserName");
            tbllogTableAdapter.Adapter.UpdateCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50, "Password");
            tbllogTableAdapter.Adapter.UpdateCommand.Parameters.Add("@Role", SqlDbType.NVarChar, 50, "Role");
            tbllogTableAdapter.Adapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");

        }

        private void frm_Add_User_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);
        }


        private void Edit(bool value)
        {
            txt_userName.Enabled = value;
            txt_password.Enabled = value;
            cb_role.Enabled = value;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_userName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_userName.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_adminuser.Refresh();
                txt_userName.Focus();
                MessageBox.Show("Duomenys issaugoti", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai norite pasalinti?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
