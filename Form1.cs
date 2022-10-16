namespace csharp_tutoruial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int result = 0;
            int a = int.Parse(txt_a.Text);
            int b = int.Parse(txt_b.Text);
            result = a + b;
            lbl_result.Text = result.ToString();
        }
    }
}