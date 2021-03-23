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
    public partial class updateDeleteAlumn : Form
    {
        ControlDBContext db;
        validacion v = new validacion();
        public updateDeleteAlumn()
        {
            InitializeComponent();
            db = new ControlDBContext();
            llenarGradoGrupo();
            llenarAlumnos();
        }

        private void llenarAlumnos()
        {
            this.gridViewAlumnos.DataSource = db.Alumno.Select(x => new
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Promedio = x.promedio,
                Salon = x.Grupo.Grupo
            }).ToList();
        }
        private void llenarGradoGrupo()
        {
            this.cmbGradoGrupo.ValueMember = "Id";
            this.cmbGradoGrupo.DisplayMember = "Grupo";
            this.cmbGradoGrupo.DataSource = db.Grupos.ToList();
        }


        private void gridViewAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idAlumno = Convert.ToInt32(gridViewAlumnos[0, gridViewAlumnos.CurrentCell.RowIndex].Value);
                Alumno alum = db.Alumno.Find(idAlumno);
                this.txtId.Text = alum.Id.ToString();
                this.txtNombre.Text = alum.Nombre.ToString();
                this.txtApellidos.Text = alum.Apellido.ToString();
                this.dateIngreso.Value = alum.Fecha_Ingreso;
                this.cmbGradoGrupo.SelectedValue = alum.GrupoId;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0 || txtApellidos.Text.Trim().Length == 0 || txtEspanol.Text.Trim().Length == 0 || txtMate.Text.Trim().Length == 0 || txtQuimica.Text.Trim().Length == 0 || txtHistoria.Text.Trim().Length == 0 || txtGeografia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                Alumno alum = db.Alumno.Find(id);
                alum.Nombre = txtNombre.Text;
                alum.Apellido = txtApellidos.Text;
                alum.Fecha_Ingreso = dateIngreso.Value;
                alum.promedio = (decimal.Parse(txtEspanol.Text) + decimal.Parse(txtMate.Text) + decimal.Parse(txtHistoria.Text) + decimal.Parse(txtGeografia.Text) + decimal.Parse(txtQuimica.Text)) / 5;
                alum.GrupoId = Convert.ToInt32(cmbGradoGrupo.SelectedValue);
                db.Entry(alum).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Alumno Actualizado");
                llenarAlumnos();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea dar de baja?", "¿Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text);
                Alumno alum = db.Alumno.Find(id);
                db.Alumno.Remove(alum);
                db.SaveChanges();
                MessageBox.Show("Dado de baja");
                llenarAlumnos();
            }
        }

        private void validarNumeros(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void validarLetras(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }
    }
}
