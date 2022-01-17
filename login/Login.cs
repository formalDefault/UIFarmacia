namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.DeepSkyBlue;
            panel4.BackColor = Color.RoyalBlue;
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.DeepSkyBlue;
            panel3.BackColor = Color.RoyalBlue;
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        { 
            this.Hide();
            SingUp registro = new SingUp();
            registro.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}