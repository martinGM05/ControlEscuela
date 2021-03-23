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
    public partial class updateDeleteEmpleado : Form
    {
        ControlDBContext db;
        validacion v = new validacion();
        public updateDeleteEmpleado()
        {
            InitializeComponent();
            db = new ControlDBContext();
            llenarRol();
            llenarEmpleado();
            llenarGradoGrupo();
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

        private void llenarEmpleado()
        {
            this.gridViewAlumnos.DataSource = db.Grupos.Join(
                db.Empleado,
                Grupos => Grupos.Id,
                Empleado => Empleado.SalonId,
                (Grupos, Empleado) => new { Grupos, Empleado })
                .Join(db.Roles,
                emp => emp.Empleado.RolesId,
                rol => rol.Id,
                (Empleado1, rol) => new { Empleado1, rol })
                .Select(z => new
                {
                    Id = z.Empleado1.Empleado.Id,
                    Nombre = z.Empleado1.Empleado.Nombre,
                    Apellido = z.Empleado1.Empleado.Apellido,
                    Cedula = z.Empleado1.Empleado.Cedula,
                    Rol = z.rol.tipo,
                    Salon = z.Empleado1.Grupos.Grupo,
                    RolId = z.rol.Id,
                    SalonId = z.Empleado1.Grupos.Id
                }).ToList();
                
        }

        private void gridViewAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = gridViewAlumnos[0, gridViewAlumnos.CurrentCell.RowIndex].Value.ToString();
                this.txtNombre.Text = gridViewAlumnos[1, gridViewAlumnos.CurrentCell.RowIndex].Value.ToString();
                this.txtApellidos.Text = gridViewAlumnos[2, gridViewAlumnos.CurrentCell.RowIndex].Value.ToString();
                this.txtCedula.Text = gridViewAlumnos[3, gridViewAlumnos.CurrentCell.RowIndex].Value.ToString();
                this.cmbRol.SelectedValue = gridViewAlumnos[6, gridViewAlumnos.CurrentCell.RowIndex].Value;
                this.cmbGradoGrupo.SelectedValue = gridViewAlumnos[7, gridViewAlumnos.CurrentCell.RowIndex].Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0 || txtApellidos.Text.Trim().Length == 0 || txtCedula.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                Empleado personal = db.Empleado.Find(id);
                personal.Nombre = txtNombre.Text;
                personal.Apellido = txtApellidos.Text;
                personal.Cedula = txtCedula.Text;
                personal.RolesId = Convert.ToInt32(cmbRol.SelectedValue);
                personal.SalonId= Convert.ToInt32(cmbGradoGrupo.SelectedValue);
                db.Entry(personal).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Empleado Actualizado");
                llenarEmpleado();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea despedir?", "¿Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text);
                Empleado personal = db.Empleado.Find(id);
                db.Empleado.Remove(personal);
                db.SaveChanges();
                MessageBox.Show("Despedido");
                llenarEmpleado();
            }
        }
    }
}
