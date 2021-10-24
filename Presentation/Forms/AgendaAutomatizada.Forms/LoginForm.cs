using AgendaAutomatizada.Forms.Agenda;
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

        public LoginForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var usuario = tbUser.Text;
            var clave = tbContraseña.Text;
            var success = _unitOfWork.Usuarios.Login(usuario, clave);


            if (success)
            {
                var index = new IndexForm();
                index.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
    }
}
