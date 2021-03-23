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
    public partial class addAlumn : Form
    {
        ControlDBContext db;
        validacion v = new validacion();
        public addAlumn()
        {
            InitializeComponent();
            db = new ControlDBContext();
            llenarGradoGrupo();
        }

        private void llenarGradoGrupo()
        {
            this.cmbGradoGrupo.ValueMember = "Id";
            this.cmbGradoGrupo.DisplayMember = "Grupo";
            this.cmbGradoGrupo.DataSource = db.Grupos.ToList();
        }

        private void validacionNumeros(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void validacionLetras(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0 || txtApellidos.Text.Trim().Length == 0 || txtEspanol.Text.Trim().Length == 0 || txtMate.Text.Trim().Length == 0 || txtQuimica.Text.Trim().Length == 0 || txtHistoria.Text.Trim().Length == 0 || txtGeografia.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                Alumno alumn = new Alumno
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,
                    Fecha_Ingreso = dateIngreso.Value,
                    promedio = (decimal.Parse(txtEspanol.Text) + decimal.Parse(txtMate.Text) + decimal.Parse(txtHistoria.Text) + decimal.Parse(txtGeografia.Text) + decimal.Parse(txtQuimica.Text)) /5,
                    GrupoId = Convert.ToInt32(cmbGradoGrupo.SelectedValue)
                };
                db.Alumno.Add(alumn);
                db.SaveChanges();
                MessageBox.Show("Alumno agregado correctamente");
                foreach (var textBox  in panelDesktop.Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
                foreach (var textBox in groupBox1.Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
            }
        }
    }
}
