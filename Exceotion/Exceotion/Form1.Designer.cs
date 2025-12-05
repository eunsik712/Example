namespace Exceotion
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
            textInput = new TextBox();
            button1 = new Button();
            textResult = new TextBox();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.Location = new Point(33, 53);
            textInput.Name = "textInput";
            textInput.Size = new Size(191, 23);
            textInput.TabIndex = 0;
            textInput.Text = "회원 닉네임을 입력하세요.";
            // 
            // button1
            // 
            button1.Location = new Point(244, 53);
            button1.Name = "button1";
            button1.Size = new Size(71, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textResult
            // 
            textResult.Location = new Point(33, 106);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(282, 163);
            textResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 320);
            Controls.Add(textResult);
            Controls.Add(button1);
            Controls.Add(textInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textInput;
        private Button button1;
        private TextBox textResult;
    }
}
