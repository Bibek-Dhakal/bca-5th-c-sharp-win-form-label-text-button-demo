namespace Label_text_box_and_button_controls_demo;

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
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(21, 107);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(306, 27);
        textBox1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(119, 73);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(64, 22);
        label1.TabIndex = 1;
        label1.Text = "Name";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(101, 161);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(101, 35);
        button1.TabIndex = 2;
        button1.Text = "Submit";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(textBox1);
        panel1.Location = new System.Drawing.Point(110, 88);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(346, 246);
        panel1.TabIndex = 3;
        // 
        // Form1
        // 
        ClientSize = new System.Drawing.Size(578, 431);
        Controls.Add(panel1);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;

    #endregion
}
