namespace switch1;

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
        textResult = new TextBox();
        btInput = new Button();
        SuspendLayout();
        // 
        // textInput
        // 
        textInput.Location = new Point(12, 12);
        textInput.Multiline = true;
        textInput.Name = "textInput";
        textInput.Size = new Size(644, 36);
        textInput.TabIndex = 0;
        textInput.TextChanged += textInput_TextChanged;
        // 
        // textResult
        // 
        textResult.Location = new Point(12, 75);
        textResult.Multiline = true;
        textResult.Name = "textResult";
        textResult.Size = new Size(644, 363);
        textResult.TabIndex = 1;
        textResult.TextChanged += textResult_TextChanged;
        // 
        // btInput
        // 
        btInput.Font = new Font("맑은 고딕", 20F);
        btInput.Location = new Point(682, 12);
        btInput.Name = "btInput";
        btInput.Size = new Size(106, 48);
        btInput.TabIndex = 2;
        btInput.Text = "추가";
        btInput.UseVisualStyleBackColor = true;
        btInput.Click += btInput_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btInput);
        Controls.Add(textResult);
        Controls.Add(textInput);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textInput;
    private TextBox textResult;
    private Button btInput;
}
