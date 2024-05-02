using ITI.Business;
using System.Data;

namespace ITI.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_crs.DataSource = InstructorCoursesService.GetCourses(1);
            dgv_crs.Columns["Crs_Id"].Visible = false;
            dgv_crs.Columns["Top_Id"].Visible = false;

            cb_topic.DataSource = TopicService.GetTopics();
            cb_topic.DisplayMember = "Top_Name";
            cb_topic.ValueMember = "Top_Id";
            cb_topic.SelectedIndex = -1;

            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Course crs = new Course() { Name = txt_crsName.Text, Duration = (int)nup_crsDur.Value, TopId = (int)cb_topic.SelectedValue };

                int rowsAffected1 = InstructorCoursesService.InsertIntoCourse(crs);
                int rowsAffected2 = InstructorCoursesService.InsertIntoIns_Crs(1, InstructorCoursesService.GetCourseId(crs));

                if (rowsAffected1 > 0 && rowsAffected2 > 0)
                {
                    MessageBox.Show("Data added successfully", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgv_crs.DataSource = InstructorCoursesService.GetCourses(1);
                    nup_crsDur.Value = 0;
                    txt_crsName.Text = "";
                    cb_topic.SelectedIndex = -1;
                }
            }
            catch
            {
                MessageBox.Show($"Please check your data and try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int crsId = 0;
        private void dgv_crs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewCellCollection cells = dgv_crs.SelectedRows[0].Cells;
            crsId = (int)cells["Crs_Id"].Value;
            txt_crsName.Text = cells["Crs_Name"].Value.ToString();
            cb_topic.SelectedValue = (int)cells["Top_Id"].Value;
            nup_crsDur.Value = (int)cells["Crs_Duration"].Value;


            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_edit.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            try
            {
                Course crs = new Course()
                {
                    Name = txt_crsName.Text,
                    Id = crsId,
                    TopId = (int)cb_topic.SelectedValue,
                    Duration = (int)nup_crsDur.Value
                };
                int rowAffected = InstructorCoursesService.UpdateCourse(crs);

                if (rowAffected > 0)
                {
                    MessageBox.Show("Data is Updated successfully", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_crs.DataSource = InstructorCoursesService.GetCourses(1);

                    nup_crsDur.Value = 0;
                    txt_crsName.Text = "";
                    cb_topic.SelectedIndex = -1;
                }

                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_edit.Visible = false;
            }
            catch
            {
                MessageBox.Show($"Please check your data and try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowAffected1 = InstructorCoursesService.DeleteIns_Crs(crsId);
                int rowAffected2 = InstructorCoursesService.DeleteCourse(crsId);

                if (rowAffected1 > 0 && rowAffected2 > 0)
                {
                    MessageBox.Show("Data is deleted successfully", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_crs.DataSource = InstructorCoursesService.GetCourses(1);

                    nup_crsDur.Value = 0;
                    txt_crsName.Text = "";
                    cb_topic.SelectedIndex = -1; ;
                }

                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_edit.Visible = false;
            }
            catch
            {
                MessageBox.Show($"Please check your data and try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
