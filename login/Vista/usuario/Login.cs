using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

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
        }//Cerrar aplicacion

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        { 
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        { 
        }
         
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void button1_Click_2(object sender, EventArgs e)
        {
            Model.Usuarios user = new Model.Usuarios();
            if (user.Login(textBox1.Text, maskedTextBox1.Text))
            {
                GUI gui = new GUI();
                this.Hide();
                gui.Show();
            }
        }//Boton para enviar formulario

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(maskedTextBox1.PasswordChar == '*')
            {
                maskedTextBox1.PasswordChar = '\0';
            } 
            else
            {
                maskedTextBox1.PasswordChar = '*';
            }
        }//Mostrar contraseña
         
        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        { 
            WindowState = FormWindowState.Minimized;
        }//Boton para minimizar ventana

        //Eventos para mover la ventana con el mouse
        int m, mx, my;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        { 
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI form1 = new GUI();
            this.Hide();
            form1.Show();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {  
            if(m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        { 
            m = 0;
        }
    }
}