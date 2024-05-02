namespace LoginAndCRUD
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dg_courses = new DataGridView();
            text_courseName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cb_topic = new ComboBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            nud_courseDuration = new NumericUpDown();
            lab = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_courses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_courseDuration).BeginInit();
            SuspendLayout();
            // 
            // dg_courses
            // 
            dg_courses.BackgroundColor = SystemColors.ButtonFace;
            dg_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_courses.Location = new Point(12, 260);
            dg_courses.Name = "dg_courses";
            dg_courses.Size = new Size(776, 178);
            dg_courses.TabIndex = 0;
            dg_courses.RowHeaderMouseDoubleClick += dg_courses_RowHeaderMouseDoubleClick;
            // 
            // text_courseName
            // 
            text_courseName.Location = new Point(217, 30);
            text_courseName.Name = "text_courseName";
            text_courseName.Size = new Size(124, 23);
            text_courseName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 4;
            label1.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 28);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 6;
            label3.Text = "Topic Name";
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(536, 28);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(121, 23);
            cb_topic.TabIndex = 7;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(8, 129, 120);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(194, 189);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(84, 33);
            btn_add.TabIndex = 10;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(8, 129, 120);
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(387, 189);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(84, 33);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(8, 129, 120);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(564, 189);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(84, 33);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // nud_courseDuration
            // 
            nud_courseDuration.Location = new Point(409, 109);
            nud_courseDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_courseDuration.Name = "nud_courseDuration";
            nud_courseDuration.Size = new Size(124, 23);
            nud_courseDuration.TabIndex = 15;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab.Location = new Point(279, 109);
            lab.Name = "lab";
            lab.Size = new Size(124, 21);
            lab.TabIndex = 14;
            lab.Text = "Course Duration";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 230, 243);
            ClientSize = new Size(800, 450);
            Controls.Add(nud_courseDuration);
            Controls.Add(lab);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(cb_topic);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(text_courseName);
            Controls.Add(dg_courses);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dg_courses).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_courseDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg_courses;
        private TextBox text_courseName;
        private Label label1;
        private Label label3;
        private ComboBox cb_topic;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private NumericUpDown nud_courseDuration;
        private Label lab;
    }
}