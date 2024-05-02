namespace Disconnected_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_course = new DataGridView();
            txt_courseName = new TextBox();
            nud_courseDuration = new NumericUpDown();
            cb_topic = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_course).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_courseDuration).BeginInit();
            SuspendLayout();
            // 
            // dgv_course
            // 
            dgv_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_course.Location = new Point(469, 12);
            dgv_course.Name = "dgv_course";
            dgv_course.Size = new Size(319, 426);
            dgv_course.TabIndex = 0;
            dgv_course.RowHeaderMouseDoubleClick += dgv_course_RowHeaderMouseDoubleClick;
            // 
            // txt_courseName
            // 
            txt_courseName.Location = new Point(95, 71);
            txt_courseName.Name = "txt_courseName";
            txt_courseName.Size = new Size(120, 23);
            txt_courseName.TabIndex = 2;
            // 
            // nud_courseDuration
            // 
            nud_courseDuration.Location = new Point(95, 140);
            nud_courseDuration.Name = "nud_courseDuration";
            nud_courseDuration.Size = new Size(120, 23);
            nud_courseDuration.TabIndex = 3;
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(331, 71);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(121, 23);
            cb_topic.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Topic Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 142);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 7;
            label3.Text = "Course Duration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 74);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Course Name";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(49, 254);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 8;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(198, 254);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 9;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(362, 254);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(174, 334);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(123, 36);
            btn_save.TabIndex = 11;
            btn_save.Text = "Save Changes";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_topic);
            Controls.Add(nud_courseDuration);
            Controls.Add(txt_courseName);
            Controls.Add(dgv_course);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_course).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_courseDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_course;
        private TextBox txt_courseName;
        private NumericUpDown nud_courseDuration;
        private ComboBox cb_topic;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_save;
    }
}
