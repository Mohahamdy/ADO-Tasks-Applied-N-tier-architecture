using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndCRUD
{
    public partial class Home : Form
    {
        SqlConnection connection;
        int ins_id = 0;
        int course_id = 0;

        public Home(int id)
        {
            InitializeComponent();
            ins_id = id;
            connection = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            GetCourses();

            GetTopics();

            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }
        void GetCourses()
        {
            SqlCommand cmd = new SqlCommand($"select C.Crs_Id,C.Crs_Name,C.Crs_Duration,T.Top_Name,T.Top_Id\r\nfrom Instructor I inner join Ins_Course IC\r\n\t\ton I.Ins_Id = IC.Ins_Id \r\n\tinner join Course C\r\n\t\ton C.Crs_Id = IC.Crs_Id\r\n\tinner join Topic T\r\n\t\ton T.Top_Id = C.Top_Id\r\nwhere I.Ins_Id = {ins_id}", connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable courses = new DataTable();

            courses.Load(reader);

            connection.Close();

            dg_courses.DataSource = courses;

            dg_courses.Columns["Crs_Id"].Visible = false;
            dg_courses.Columns["Top_Id"].Visible = false;
        }

        void GetTopics()
        {

            SqlCommand cmd = new SqlCommand("select Top_Id,Top_Name from Topic", connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable topics = new DataTable();
            topics.Load(reader);

            connection.Close();

            cb_topic.DataSource = topics;
            cb_topic.DisplayMember = "Top_Name";
            cb_topic.ValueMember = "Top_Id";

            cb_topic.SelectedIndex = -1;
        }

        int GetCourseId(string crsName,int crsDuration,int topId)
        {

            SqlCommand cmd = new SqlCommand($"select crs_id from Course where Crs_Name = '{crsName}' and Top_Id = {topId} and Crs_Duration = {crsDuration}", connection);

            connection.Open();

            object? obj = cmd.ExecuteScalar();

            connection.Close();

            return (int) obj;
        }

        int ExcuteCommand(string command)
        {
            int rowsAffected = 0;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                connection.Open();

                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please check your data and try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int rowsAffected1 = ExcuteCommand($"insert into Course values('{text_courseName.Text}', {(int)nud_courseDuration.Value}, {(int?)cb_topic.SelectedValue})");

            int rowsAffected2 = ExcuteCommand($"insert into Ins_Course values({ins_id},{GetCourseId(text_courseName.Text, (int)nud_courseDuration.Value, (int)cb_topic.SelectedValue)},'good')");

            if (rowsAffected1 > 0 && rowsAffected2 > 0)
            {
                MessageBox.Show("Data added successfully", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCourses();
                nud_courseDuration.Value = 0;
                text_courseName.Text = "";
                cb_topic.SelectedIndex = -1;
            }
        }

        private void dg_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = dg_courses.SelectedRows[0].Cells;
            course_id = (int)cells["Crs_Id"].Value;

            text_courseName.Text = cells["Crs_Name"].Value.ToString();
            cb_topic.SelectedValue = (int)cells["Top_Id"].Value;
            nud_courseDuration.Value = (int)cells["Crs_Duration"].Value;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_edit.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowAffected1 = ExcuteCommand($"delete from Ins_Course where Crs_Id={course_id}");
            int rowAffected2 = ExcuteCommand($"delete from Course\r\nwhere Crs_Id ={course_id}");

            if (rowAffected1 > 0 && rowAffected2 > 0)
            {
                MessageBox.Show("Data is deleted successfully", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCourses();
                nud_courseDuration.Value = 0;
                text_courseName.Text = "";
                cb_topic.SelectedIndex = -1;
            }

            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int rowAffected = ExcuteCommand($"update Course set Crs_Duration={(int)nud_courseDuration.Value}, Crs_Name='{text_courseName.Text}', Top_Id={(int?)cb_topic.SelectedValue} where Crs_Id = {course_id}");
            if (rowAffected > 0)
            {
                MessageBox.Show("Data is Updated successfully", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCourses();
                nud_courseDuration.Value = 0;
                text_courseName.Text = "";
                cb_topic.SelectedIndex= -1;
            }

            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }
    }
}
