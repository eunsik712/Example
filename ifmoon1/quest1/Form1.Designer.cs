namespace quest1
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
            text_result = new TextBox();
            textBox2 = new TextBox();
            radioButtonFalse = new RadioButton();
            radioButtonTrue = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // text_result
            // 
            text_result.BackColor = SystemColors.ControlLightLight;
            text_result.Location = new Point(12, 89);
            text_result.Multiline = true;
            text_result.Name = "text_result";
            text_result.ReadOnly = true;
            text_result.Size = new Size(547, 349);
            text_result.TabIndex = 2;
            text_result.TextChanged += text_result_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(547, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Location = new Point(153, 62);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new Size(49, 19);
            radioButtonFalse.TabIndex = 4;
            radioButtonFalse.TabStop = true;
            radioButtonFalse.Text = "false";
            radioButtonFalse.UseVisualStyleBackColor = true;
            radioButtonFalse.CheckedChanged += radioButtonFalse_CheckedChanged;
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Location = new Point(25, 62);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new Size(48, 19);
            radioButtonTrue.TabIndex = 5;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "True";
            radioButtonTrue.UseVisualStyleBackColor = true;
            radioButtonTrue.CheckedChanged += radioButtonTrue_CheckedChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(620, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "input";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(radioButtonTrue);
            Controls.Add(radioButtonFalse);
            Controls.Add(textBox2);
            Controls.Add(text_result);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_result;
        private TextBox textBox2;
        //private RadioButton radioButton1;
        private RadioButton radioButtonFalse;
        private RadioButton radioButtonTrue;
        private Button button1;
    }
}
