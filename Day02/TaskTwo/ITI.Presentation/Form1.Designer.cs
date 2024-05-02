namespace ITI.Presentation
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
            txt_crsName = new TextBox();
            cb_topic = new ComboBox();
            nup_crsDur = new NumericUpDown();
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgv_crs = new DataGridView();
            btn_edit = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)nup_crsDur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_crs).BeginInit();
            SuspendLayout();
            // 
            // txt_crsName
            // 
            txt_crsName.Location = new Point(97, 36);
            txt_crsName.Name = "txt_crsName";
            txt_crsName.Size = new Size(120, 23);
            txt_crsName.TabIndex = 0;
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(302, 36);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(121, 23);
            cb_topic.TabIndex = 1;
            // 
            // nup_crsDur
            // 
            nup_crsDur.Location = new Point(187, 119);
            nup_crsDur.Name = "nup_crsDur";
            nup_crsDur.Size = new Size(120, 23);
            nup_crsDur.TabIndex = 2;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(194, 192);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(102, 33);
            btn_add.TabIndex = 3;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 39);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Topic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 121);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 8;
            label3.Text = "Course Duration";
            // 
            // dgv_crs
            // 
            dgv_crs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_crs.Location = new Point(444, 12);
            dgv_crs.Name = "dgv_crs";
            dgv_crs.Size = new Size(344, 426);
            dgv_crs.TabIndex = 9;
            dgv_crs.RowHeaderMouseDoubleClick += dgv_crs_RowHeaderMouseDoubleClick;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(194, 246);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(102, 33);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(194, 300);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(102, 33);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(dgv_crs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(nup_crsDur);
            Controls.Add(cb_topic);
            Controls.Add(txt_crsName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nup_crsDur).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_crs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_crsName;
        private ComboBox cb_topic;
        private NumericUpDown nup_crsDur;
        private Button btn_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgv_crs;
        private Button btn_edit;
        private Button btn_delete;
    }
}
