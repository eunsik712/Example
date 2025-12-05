namespace Gr_Dict
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
            button1 = new Button();
            idBox = new TextBox();
            pwBox = new TextBox();
            phoneBox = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(65, 206);
            button1.Name = "button1";
            button1.Size = new Size(132, 41);
            button1.TabIndex = 0;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(65, 74);
            idBox.Name = "idBox";
            idBox.Size = new Size(132, 23);
            idBox.TabIndex = 1;
            idBox.Text = "아이디";
            // 
            // pwBox
            // 
            pwBox.Location = new Point(65, 145);
            pwBox.Name = "pwBox";
            pwBox.Size = new Size(132, 23);
            pwBox.TabIndex = 2;
            pwBox.Text = "비밀번호";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(65, 24);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(132, 23);
            phoneBox.TabIndex = 3;
            phoneBox.Text = "번호";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(65, 261);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(132, 41);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "회원가입";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 314);
            Controls.Add(btnRegister);
            Controls.Add(phoneBox);
            Controls.Add(pwBox);
            Controls.Add(idBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox idBox;
        private TextBox pwBox;
        private TextBox phoneBox;
        private Button btnRegister;
    }
}
