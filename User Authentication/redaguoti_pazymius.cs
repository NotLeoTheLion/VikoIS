using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace User_Authentication
{
    public partial class frm_Edit_Grade : Form
    {
        public frm_Edit_Grade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_Edit_Grade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uaDBDataSet.grade' table. You can move, or remove it, as needed.
            this.gradeTableAdapter.Fill(this.uaDBDataSet.grade);
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\jgluk\OneDrive\Stalinis kompiuteris\Praktika\User Authentication\User Authentication\uaDB.mdf"";Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbllog WHERE role = @role", con);

                    cmd.Parameters.AddWithValue("@role", "Studentas");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);


                    con.Close();

                    cb_vardai.DataSource = ds.Tables[0];
                    cb_vardai.DisplayMember = "Username";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jgluk\\OneDrive\\Stalinis kompiuteris\\Praktika\\User Authentication\\User Authentication\\uaDB.mdf\";Integrated Security=True"))
                {
                    con.Open();

                    string selectedUsername = cb_vardai.Text;

                    using (SqlCommand getIdCmd = new SqlCommand("SELECT Id FROM tbllog WHERE Username = @Username", con))
                    {
                        getIdCmd.Parameters.AddWithValue("@Username", selectedUsername);

                        int userId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO grade (Paskaita, Pazimys) VALUES (@Paskaita, @Pazimys)", con))
                        {
                            cmd.Parameters.AddWithValue("@Id", userId);
                            cmd.Parameters.AddWithValue("@Paskaita", cb_paskaita.Text);
                            cmd.Parameters.AddWithValue("@Pazimys", cb_pazymys.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sekmingai iterpta!");
                            dgv_grades.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jgluk\\OneDrive\\Stalinis kompiuteris\\Praktika\\User Authentication\\User Authentication\\uaDB.mdf\";Integrated Security=True"))
                {
                    con.Open();

                    // Assuming you have a variable to store the selected username
                    string selectedUsername = cb_vardai.Text;

                    // Fetch the corresponding Id from tbllog based on the selected username
                    using (SqlCommand getIdCmd = new SqlCommand("SELECT Id FROM tbllog WHERE Username = @Username", con))
                    {
                        getIdCmd.Parameters.AddWithValue("@Username", selectedUsername);

                        int selectedUserId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                        using (SqlCommand cmd = new SqlCommand("UPDATE grade SET Paskaita=@Paskaita, Pazimys=@Pazimys WHERE IdGrade=@IdGrade", con))
                        {
                            cmd.Parameters.AddWithValue("@Paskaita", cb_paskaita.Text);
                            cmd.Parameters.AddWithValue("@Pazimys", cb_pazymys.Text);
                            cmd.Parameters.AddWithValue("@IdGrade", selectedUserId);
                            cmd.ExecuteNonQuery();
                        }
                    }



                    con.Close();

                    cb_paskaita.Text = "";
                    cb_pazymys.Text = "";

                    MessageBox.Show("Sekmingai redaguota!");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jgluk\\OneDrive\\Stalinis kompiuteris\\Praktika\\User Authentication\\User Authentication\\uaDB.mdf\";Integrated Security=True");

            con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO grade (Paskaita,Pazimys) VALUES (@Paskaita,@Pazimys)", con))
            {
                //cmd.Parameters.AddWithValue()
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\jgluk\\OneDrive\\Stalinis kompiuteris\\Praktika\\User Authentication\\User Authentication\\uaDB.mdf\";Integrated Security=True"))
                {
                    con.Open();

                    string selectedUsername = cb_vardai.Text;

                    using (SqlCommand getIdCmd = new SqlCommand("SELECT Id FROM tbllog WHERE Username = @Username", con))
                    {
                        getIdCmd.Parameters.AddWithValue("@Username", selectedUsername);

                        int selectedUserId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM grade WHERE IdGrade=@IdGrade", con))
                        {
                            cmd.Parameters.AddWithValue("@IdGrade", selectedUserId);
                            cmd.ExecuteNonQuery();
                        }
                    }



                    con.Close();

                    MessageBox.Show("Sekmingai istrinta!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void dgv_grades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
