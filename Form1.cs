namespace Label_text_box_and_button_controls_demo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Resize += Form1_Resize;
        CenterPanel();
    }

    private void Form1_Resize(object? sender, EventArgs e)
    {
        CenterPanel();
    }

    private void CenterPanel()
    {
        panel1.Left = (ClientSize.Width - panel1.Width) / 2;
        panel1.Top = (ClientSize.Height - panel1.Height) / 2;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var name = textBox1.Text;

        if (name == "")
        {
            MessageBox.Show("Please enter your name");
            return;
        }

        MessageBox.Show($"Hello, {name}");
    }
}