﻿namespace LocalizationForm;

partial class JsonLocalizator
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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        button1.Font = new System.Drawing.Font("Segoe UI", 10F);
        button1.Location = new System.Drawing.Point(3, 13);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(120, 52);
        button1.TabIndex = 0;
        button1.Text = "Выбрать файл";
        button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // richTextBox1
        // 
        richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        richTextBox1.Location = new System.Drawing.Point(129, 71);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(500, 543);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // button2
        // 
        button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        button2.Font = new System.Drawing.Font("Segoe UI", 10F);
        button2.Location = new System.Drawing.Point(635, 13);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(120, 52);
        button2.TabIndex = 2;
        button2.Text = "Перевести";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // richTextBox2
        // 
        richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        richTextBox2.Location = new System.Drawing.Point(761, 71);
        richTextBox2.Name = "richTextBox2";
        richTextBox2.Size = new System.Drawing.Size(502, 543);
        richTextBox2.TabIndex = 3;
        richTextBox2.Text = "";
        // 
        // comboBox1
        // 
        comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Английский", "Белорусский" });
        comboBox1.Location = new System.Drawing.Point(635, 71);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(120, 23);
        comboBox1.TabIndex = 5;
        comboBox1.Text = "Язык";
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // button3
        // 
        button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        button3.Font = new System.Drawing.Font("Segoe UI", 10F);
        button3.Location = new System.Drawing.Point(635, 620);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(120, 45);
        button3.TabIndex = 6;
        button3.Text = "Сохранить";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click_1;
        // 
        // button4
        // 
        button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        button4.Font = new System.Drawing.Font("Segoe UI", 10F);
        button4.Location = new System.Drawing.Point(3, 620);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(120, 45);
        button4.TabIndex = 7;
        button4.Text = "Очистить";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel1.Controls.Add(button1, 0, 0);
        tableLayoutPanel1.Controls.Add(button4, 0, 2);
        tableLayoutPanel1.Controls.Add(richTextBox1, 1, 1);
        tableLayoutPanel1.Controls.Add(richTextBox2, 3, 1);
        tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
        tableLayoutPanel1.Controls.Add(button2, 2, 0);
        tableLayoutPanel1.Controls.Add(button3, 2, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1266, 687);
        tableLayoutPanel1.TabIndex = 8;
        // 
        // JsonLocalizator
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
        AutoScroll = true;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        ClientSize = new System.Drawing.Size(1266, 687);
        Controls.Add(tableLayoutPanel1);
        KeyPreview = true;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Json Translator";
        WindowState = System.Windows.Forms.FormWindowState.Minimized;
        Load += JsonTranslator_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;


    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.RichTextBox richTextBox2;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.RichTextBox richTextBox1;

    #endregion
}