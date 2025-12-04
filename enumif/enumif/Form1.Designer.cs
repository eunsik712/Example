namespace enumif
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
            roButton = new Button();
            ppButton = new Button();
            ssButton = new Button();
            textResult = new TextBox();
            pyLabel = new Label();
            bsLabel = new Label();
            countBox1 = new TextBox();
            countBox2 = new TextBox();
            SuspendLayout();
            // 
            // roButton
            // 
            roButton.Font = new Font("맑은 고딕", 25F);
            roButton.Location = new Point(305, 372);
            roButton.Name = "roButton";
            roButton.Size = new Size(217, 150);
            roButton.TabIndex = 1;
            roButton.Text = "바위";
            roButton.UseVisualStyleBackColor = true;
            roButton.Click += roButton_Click;
            // 
            // ppButton
            // 
            ppButton.Font = new Font("맑은 고딕", 25F);
            ppButton.Location = new Point(597, 372);
            ppButton.Name = "ppButton";
            ppButton.Size = new Size(217, 150);
            ppButton.TabIndex = 2;
            ppButton.Text = "보";
            ppButton.UseVisualStyleBackColor = true;
            ppButton.Click += ppButton_Click;
            // 
            // ssButton
            // 
            ssButton.Font = new Font("맑은 고딕", 25F);
            ssButton.Location = new Point(12, 372);
            ssButton.Name = "ssButton";
            ssButton.Size = new Size(217, 150);
            ssButton.TabIndex = 3;
            ssButton.Text = "가위";
            ssButton.UseVisualStyleBackColor = true;
            ssButton.Click += ssButton_Click;
            // 
            // textResult
            // 
            textResult.Location = new Point(12, 12);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(802, 257);
            textResult.TabIndex = 4;
            textResult.TextChanged += textResult_TextChanged;
            // 
            // pyLabel
            // 
            pyLabel.AutoSize = true;
            pyLabel.Font = new Font("맑은 고딕", 20F);
            pyLabel.Location = new Point(79, 282);
            pyLabel.Name = "pyLabel";
            pyLabel.Size = new Size(71, 37);
            pyLabel.TabIndex = 5;
            pyLabel.Text = "용사";
            // 
            // bsLabel
            // 
            bsLabel.AutoSize = true;
            bsLabel.Font = new Font("맑은 고딕", 20F);
            bsLabel.Location = new Point(671, 282);
            bsLabel.Name = "bsLabel";
            bsLabel.Size = new Size(71, 37);
            bsLabel.TabIndex = 6;
            bsLabel.Text = "마왕";
            // 
            // countBox1
            // 
            countBox1.Font = new Font("맑은 고딕", 15F);
            countBox1.Location = new Point(62, 322);
            countBox1.Name = "countBox1";
            countBox1.Size = new Size(100, 34);
            countBox1.TabIndex = 7;
            countBox1.Text = "0";
            countBox1.TextChanged += countBox1_TextChanged;
            // 
            // countBox2
            // 
            countBox2.Font = new Font("맑은 고딕", 15F);
            countBox2.Location = new Point(654, 322);
            countBox2.Name = "countBox2";
            countBox2.Size = new Size(100, 34);
            countBox2.TabIndex = 8;
            countBox2.Text = "0";
            countBox2.TextChanged += countBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 534);
            Controls.Add(countBox2);
            Controls.Add(countBox1);
            Controls.Add(bsLabel);
            Controls.Add(pyLabel);
            Controls.Add(textResult);
            Controls.Add(ssButton);
            Controls.Add(roButton);
            Controls.Add(ppButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Button roButton;
        private Button ppButton;
        private Button ssButton;
        private TextBox textResult;
        private Label pyLabel;
        private Label bsLabel;
        private TextBox countBox1;
        private TextBox countBox2;
    }
}
