namespace LocalizationForm;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        button2 = new System.Windows.Forms.Button();
        richTextBox2 = new System.Windows.Forms.RichTextBox();
        comboBox1 = new System.Windows.Forms.ComboBox();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(12, 46);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(105, 38);
        button1.TabIndex = 0;
        button1.Text = "Choose .json file\r\n\r\n";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new System.Drawing.Point(123, 46);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(311, 415);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(457, 46);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(105, 38);
        button2.TabIndex = 2;
        button2.Text = "Translate\r\n\r\n\r\n";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // richTextBox2
        // 
        richTextBox2.Location = new System.Drawing.Point(574, 46);
        richTextBox2.Name = "richTextBox2";
        richTextBox2.Size = new System.Drawing.Size(311, 415);
        richTextBox2.TabIndex = 3;
        richTextBox2.Text = "";
        // 
        // comboBox1
        // 
        comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "en", "be" });
        comboBox1.Location = new System.Drawing.Point(457, 90);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(104, 23);
        comboBox1.TabIndex = 5;
        comboBox1.Text = "Language";
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(780, 510);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(105, 38);
        button3.TabIndex = 6;
        button3.Text = "Save\r\n\r\n\r\n\r\n\r\n";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click_1;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(12, 510);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(105, 38);
        button4.TabIndex = 7;
        button4.Text = "Clear";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(896, 603);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(comboBox1);
        Controls.Add(richTextBox2);
        Controls.Add(button2);
        Controls.Add(richTextBox1);
        Controls.Add(button1);
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.RichTextBox richTextBox2;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.RichTextBox richTextBox1;

    #endregion
}