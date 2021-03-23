using EscuelaPeñaNieto.Class;
using EscuelaPeñaNieto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaPeñaNieto.Forms
{
    public partial class addPersonal : Form
    {
        ControlDBContext db;
        validacion v = new validacion();
        public addPersonal()
        {
            InitializeComponent();
            db = new ControlDBContext();
            llenarGradoGrupo();
            llenarRol();
        }

        private void llenarGradoGrupo()
        {
            this.cmbGradoGrupo.ValueMember = "Id";
            this.cmbGradoGrupo.DisplayMember = "Grupo";
            this.cmbGradoGrupo.DataSource = db.Grupos.ToList();
        }

        private void llenarRol()
        {
            this.cmbRol.ValueMember = "Id";
            this.cmbRol.DisplayMember = "tipo";
            this.cmbRol.DataSource = db.Roles.ToList();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0 || txtApellidos.Text.Trim().Length == 0 || txtCedula.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                Empleado personal = new Empleado
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,
                    Cedula = txtCedula.Text,
                    RolesId = Convert.ToInt32(cmbRol.SelectedValue),
                    SalonId = Convert.ToInt32(cmbGradoGrupo.SelectedValue)
                };
                db.Empleado.Add(personal);
                db.SaveChanges();
                MessageBox.Show("Personal Contratado Correctamente");
                foreach (var textBox in panelDesktop.Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
            }
        }
    }
}
