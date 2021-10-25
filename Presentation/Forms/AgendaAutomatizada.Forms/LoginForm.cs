using AgendaAutomatizada.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAutomatizada.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            Login();
            panel2.Visible = false;
            panel1.Visible = true;
            panel4.Visible = true;
        }

        private void Login()
        {
            var usuario = tbUser.Text;
            var clave = tbContraseña.Text;
            var success = _unitOfWork.Usuarios.Login(usuario, clave);


            if (success)
            {

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            tbContraseña.PasswordChar = '\0';
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            tbContraseña.PasswordChar = '*';
        }
    }
}
