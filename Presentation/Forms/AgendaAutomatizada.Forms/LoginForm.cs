using AgendaAutomatizada.Domain.Entities;
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
        private int _idUser;
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
        }

        private void Login()
        {
            var usuario = tbUser.Text;
            var clave = tbContraseña.Text;
            var success = _unitOfWork.Usuarios.Login(usuario, clave);
            _idUser = _unitOfWork.Usuarios.GetId(usuario);


            if (success)
            {
               
                panel2.Visible = false;
                panel1.Visible = true;
                panel4.Visible = true;
                LoadAgendas();
                LoadDropDowns();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
        private void LoadDropDowns()
        {
            var Dias = _unitOfWork.ComboBox.DiasComboBox();
            var Tandas = _unitOfWork.ComboBox.TandaComboBox();

            cbDias.Items.Clear();
            Dias.ForEach(data =>
            cbDias.Items.Insert(0, data.Text)
            );
            cbTanda.Items.Clear();
            Tandas.ForEach(data =>
            cbTanda.Items.Insert(0, data.Text)
            );

        }
        private void LoadAgendas()
        {
            var ListAgenda = _unitOfWork.Agendas.ListAgendaById(_idUser);
        }
        private void GuardarDias()
        {
            var Descripcion = tbDescripcionGuardarDias.Text;

            if (tbDescripcionGuardarDias.Text != "")
            {
                _unitOfWork.Dias.addDia(new Dia()
                {
                    Descripcion = Descripcion,
                });
                _unitOfWork.Complete();
                dtgvDiasData();
            }
            else
            {
                MessageBox.Show("Introduzca una descripción.");
            }
        }

        public void SelectDataDiasToEdit()
        {
            tbDescripcionEditarDias.Text = dtgvDias.SelectedRows[0].Cells[0].Value.ToString();
            var estado = (bool)dtgvDias.SelectedRows[0].Cells[5].Value;
            if (estado == true)
            {
                rdbtnActivoDias.Checked = true;
            }
            else
            {
                rdbtnInactivoDias.Checked = true;
            }
        }
        public void SelectDataTandaToEdit()
        {
            tbEditTanda.Text = dtgvTanda.SelectedRows[0].Cells[0].Value.ToString();
            var estado = (bool)dtgvTanda.SelectedRows[0].Cells[5].Value;
            if (estado == true)
            {
                rdbtnActivoTanda.Checked = true;
            }
            else
            {
                rdbtnInactivoTanda.Checked = true;
            }
        }
        private void UpdateDias()
        {
            var Id = int.Parse(dtgvDias.SelectedRows[0].Cells[2].Value.ToString());
            var Descripcion = tbDescripcionEditarDias.Text;
            var Estado = (rdbtnActivoDias.Checked == true) ? true : false;

            if (Descripcion != "")
            {
                _unitOfWork.Dias.Update(new Dia()
                {
                    Id = Id,
                    Descripcion = Descripcion,
                    Estado = Estado

                });
                _unitOfWork.Complete();
                dtgvDiasData();
            }
            else
            {
                MessageBox.Show("Introduzca una descripción.");
            }
        }
        private void UpdateTandas()
        {
            var Id = int.Parse(dtgvTanda.SelectedRows[0].Cells[2].Value.ToString());
            var Descripcion = tbEditTanda.Text;
            var Estado = (rdbtnActivoTanda.Checked == true) ? true : false;

            if (Descripcion != "")
            {
                _unitOfWork.Tandas.Update(new Tandas()
                {
                    Id = Id,
                    Descripcion = Descripcion,
                    Estado = Estado

                });
                _unitOfWork.Complete();
                dtgvTandasData();
            }
            else
            {
                MessageBox.Show("Introduzca una descripción.");
            }
        }

        private void dtgvDiasData()
        {
            var ListDias = _unitOfWork.Dias.GetAll();
            dtgvDias.DataSource = ListDias.ToList();
        }

        private void dtgvTandasData()
        {
            var ListTandas = _unitOfWork.Tandas.GetAll();
            dtgvTanda.DataSource = ListTandas.ToList();
        }

        private void GuardarTandas()
        {
            var Descripcion = tbGuardarTanda.Text;
            _unitOfWork.Tandas.addTanda(new Tandas()
            {
                Descripcion = Descripcion,
            });
            _unitOfWork.Complete();
            dtgvTandasData();
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

        private void BtnGuardarDias_Click(object sender, EventArgs e)
        {
            GuardarDias();
        }

        private void BtnEditDias_Click(object sender, EventArgs e)
        {
            UpdateDias();
        }

        private void btnBackMantenimientoDias_Click(object sender, EventArgs e)
        {
            MantenimientoDias.Visible = false;
            MantenimientoTandas.Visible = false;
            panel1.Visible = true;
            panel4.Visible = true;
            LoadAgendas();
            LoadDropDowns();
        }

        private void OpenDias_Click(object sender, EventArgs e)
        {
            MantenimientoDias.Visible = true;
            MantenimientoTandas.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            dtgvDiasData();
        }

        private void dtgvDias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataDiasToEdit();
        }

        private void btnGuardarTanda_Click(object sender, EventArgs e)
        {
            GuardarTandas();
        }

        private void btnEditTanda_Click(object sender, EventArgs e)
        {
            UpdateTandas();
        }

        private void dtgvTanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataTandaToEdit();
        }

        private void btnBackMantenimientoTanda_Click(object sender, EventArgs e)
        {
            MantenimientoDias.Visible = false;
            MantenimientoTandas.Visible = false;
            panel1.Visible = true;
            panel4.Visible = true;
            LoadAgendas();
            LoadDropDowns();
        }

        private void OpenTandas_Click(object sender, EventArgs e)
        {
            MantenimientoTandas.Visible = true;
            MantenimientoDias.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            dtgvTandasData();
        }
    }
}
