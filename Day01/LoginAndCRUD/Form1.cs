using Microsoft.Data.SqlClient;
using System.Windows.Forms.Design;

namespace LoginAndCRUD
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();

            connection = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"select [Ins_Name] from Instructor where Ins_Id = {int.Parse(text_pass.Text)}",connection);
            
            connection.Open();

            object? obj = sqlCommand.ExecuteScalar();

            connection.Close();

            string? fname = (string) obj;

            if( fname != null && fname == text_userName.Text) {
                MessageBox.Show("Logged", "Logged in",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Home home = new Home(int.Parse(text_pass.Text));
                this.Hide();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Usernamr or Passowrd!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
