namespace LoginAndCRUD
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
            text_userName = new TextBox();
            text_pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_logIn = new Button();
            SuspendLayout();
            // 
            // text_userName
            // 
            text_userName.Location = new Point(264, 111);
            text_userName.Name = "text_userName";
            text_userName.Size = new Size(263, 23);
            text_userName.TabIndex = 0;
            // 
            // text_pass
            // 
            text_pass.Location = new Point(264, 203);
            text_pass.Name = "text_pass";
            text_pass.PasswordChar = '*';
            text_pass.Size = new Size(263, 23);
            text_pass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 109);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 203);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 3;
            label2.Text = "Passward";
            // 
            // btn_logIn
            // 
            btn_logIn.BackColor = Color.FromArgb(8, 129, 120);
            btn_logIn.FlatStyle = FlatStyle.Flat;
            btn_logIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logIn.ForeColor = Color.White;
            btn_logIn.Location = new Point(336, 284);
            btn_logIn.Name = "btn_logIn";
            btn_logIn.Size = new Size(114, 31);
            btn_logIn.TabIndex = 4;
            btn_logIn.Text = "Log in";
            btn_logIn.UseVisualStyleBackColor = false;
            btn_logIn.Click += btn_logIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 230, 243);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_logIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_pass);
            Controls.Add(text_userName);
            Name = "Form1";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_userName;
        private TextBox text_pass;
        private Label label1;
        private Label label2;
        private Button btn_logIn;
    }
}
