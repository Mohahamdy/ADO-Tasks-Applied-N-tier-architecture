using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Disconnected_CRUD
{
    public partial class Form1 : Form
    {
        SqlConnection con;

        SqlDataAdapter adapter;

        DataTable DataTable;

        int lastCrsId = 0;
        int crsId = 0;
        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI"].ToString());
            adapter = new SqlDataAdapter();
            DataTable = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCourses();

            SqlCommand cmd = new SqlCommand("select Top_Id,Top_Name from Topic", con);
            adapter.SelectCommand = cmd;
            DataTable topics = new DataTable();
            adapter.Fill(topics);

            cb_topic.DataSource = topics;
            cb_topic.DisplayMember = "Top_Name";
            cb_topic.ValueMember = "Top_Id";
            cb_topic.SelectedIndex = -1;
            
            btn_edit.Visible = false;
            btn_delete.Visible = false;
        }

        void GetCourses()
        {
            SqlCommand cmd = new SqlCommand("select [Crs_Id],[Crs_Name],[Crs_Duration],[Top_Id] from Course", con);
            adapter.SelectCommand = cmd;
            DataTable.Clear();
            adapter.Fill(DataTable);
            lastCrsId = (int)DataTable.Rows[DataTable.Rows.Count - 1]["Crs_Id"];
            dgv_course.DataSource = DataTable;
            dgv_course.Columns["Crs_Id"].Visible = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow row = DataTable.NewRow();
            try
            {
                lastCrsId += 100;
                row["Crs_Id"] = lastCrsId;
                row["Crs_Name"] = txt_courseName.Text;
                row["Crs_Duration"] = (int)nud_courseDuration.Value;
                row["Top_Id"] = (int?)cb_topic.SelectedValue;
                DataTable.Rows.Add(row);

                txt_courseName.Text = string.Empty;
                nud_courseDuration.Value = 0;
                cb_topic.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show($"Please add your data correctly and try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = dgv_course.SelectedRows[0].Cells;

            crsId = (int)cells["Crs_Id"].Value;
            txt_courseName.Text = cells["Crs_Name"].Value.ToString();
            nud_courseDuration.Value = (int)cells["Crs_Duration"].Value;
            cb_topic.SelectedValue = (int)cells["Top_Id"].Value;

            btn_add.Visible = false;
            btn_edit.Visible = true;
            btn_delete.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dataRow in DataTable.Rows)
                {
                    if (dataRow.RowState != DataRowState.Deleted && (int)dataRow["Crs_Id"] == crsId)
                    {
                        dataRow["Crs_Name"] = txt_courseName.Text;
                        dataRow["Crs_Duration"] = nud_courseDuration.Value;
                        dataRow["Top_Id"] = cb_topic.SelectedValue;
                    }
                }

                txt_courseName.Text = string.Empty;
                nud_courseDuration.Value = 0;
                cb_topic.SelectedIndex = -1;

                btn_add.Visible = true;
                btn_edit.Visible = false;
                btn_delete.Visible = false;
            }
            catch
            {
                MessageBox.Show($"Please add your data correctly and try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataRow row = DataTable.NewRow();
    
            foreach (DataRow dataRow in DataTable.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted && (int)dataRow["Crs_Id"] == crsId)
                {
                    row = dataRow;
                }
            }

            row.Delete();

            txt_courseName.Text = string.Empty;
            nud_courseDuration.Value = 0;
            cb_topic.SelectedIndex = -1;

            btn_add.Visible = true;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand deleteCourseFromIns_Crs = new SqlCommand("delete from Ins_Course where Crs_Id = @crsId", con);
                deleteCourseFromIns_Crs.Parameters.Add("crsId", SqlDbType.Int, 4, "Crs_Id");
                adapter.DeleteCommand = deleteCourseFromIns_Crs;
                adapter.Update(DataTable);
            }
            catch { }
            finally
            {
                SqlCommand insertCourse = new SqlCommand("insert into Course values(@crsName,@crsDuration,@topId)", con);
                insertCourse.Parameters.Add("crsName", SqlDbType.NVarChar, 50, "Crs_Name");
                insertCourse.Parameters.Add("crsDuration", SqlDbType.Int, 4, "Crs_Duration");
                insertCourse.Parameters.Add("topId", SqlDbType.Int, 4, "Top_ID");

                SqlCommand deleteCourse = new SqlCommand("delete from Course where Crs_Id = @crsId", con);
                deleteCourse.Parameters.Add("crsId", SqlDbType.Int, 4, "Crs_Id");

                SqlCommand updateCourse = new SqlCommand("update Course set [Crs_Name]=@crsName,[Crs_Duration]=@crsDuration,[Top_Id]=@topId where Crs_Id = @crsId", con);
                updateCourse.Parameters.Add("crsName", SqlDbType.NVarChar, 50, "Crs_Name");
                updateCourse.Parameters.Add("crsDuration", SqlDbType.Int, 4, "Crs_Duration");
                updateCourse.Parameters.Add("topId", SqlDbType.Int, 4, "Top_ID");
                updateCourse.Parameters.Add("crsId", SqlDbType.Int, 4, "Crs_Id");

                adapter.InsertCommand = insertCourse;
                adapter.UpdateCommand = updateCourse;
                adapter.DeleteCommand = deleteCourse;

                try
                {
                    adapter.Update(DataTable);
                    GetCourses();
                }
                catch
                {
                    MessageBox.Show($"Please add your data correctly and try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
