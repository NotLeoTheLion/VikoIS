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

namespace User_Authentication
{
    public partial class frm_viewgrade : Form
    {
        public frm_viewgrade(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }
        public frm_viewgrade()
        {
            InitializeComponent();
        }

        private void frm_viewgrade_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jgluk\\OneDrive\\Stalinis kompiuteris\\Praktika\\User Authentication\\User Authentication\\uaDB.mdf\";Integrated Security=True"))
                {
                    con.Open();

                    // Fetch the user's ID based on the logged-in username
                    int loggedInUserId = GetUserIdByUsername(ulog.username);

                    // Fetch grades for the logged-in user
                    using (SqlCommand cmd = new SqlCommand("SELECT Paskaita, Pazimys FROM grade WHERE Id = @UserId", con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", loggedInUserId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgv_gradeview.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private int GetUserIdByUsername(string username)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jgluk\\OneDrive\\Stalinis kompiuteris\\Praktika\\User Authentication\\User Authentication\\uaDB.mdf\";Integrated Security=True"))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Id FROM tbllog WHERE Username = @Username", con))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 255).Value = username;

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }

            return -1;
        }


        public static class ulog
        {
            public static string type { get; set; }
            public static string username { get; set; }
        }




        private void lbl_loguser_Click(object sender, EventArgs e)
        {

        }
    }
}
