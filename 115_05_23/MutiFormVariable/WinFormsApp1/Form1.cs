namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNext_Click(object? sender, System.EventArgs e)
        {
            // Generate a Label showing the name 날촧랙
            var label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(20, 60);
            label.Text = "날촧랙";
            this.Controls.Add(label);
        }
    }
}
