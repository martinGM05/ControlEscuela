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
            this.gridViewEmpleados.DataSource = db.Empleado.Select(x => new
            {
                Id = x.Id,
                Nombre_Completo = x.Nombre + " " + x.Apellido,
                Cedula = x.Cedula,
                Rol = x.Roles.tipo,
                Salon_Encargado = x.Salon.Grupo
            }).ToList();

        }

        private void gridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idEmpleado = Convert.ToInt32(gridViewEmpleados[0, gridViewEmpleados.CurrentCell.RowIndex].Value);
                Empleado emp = db.Empleado.Find(idEmpleado);
                this.txtId.Text = emp.Id.ToString();
                this.txtNombre.Text = emp.Nombre.ToString();
                this.txtApellidos.Text = emp.Apellido.ToString();
                this.txtCedula.Text = emp.Cedula.ToString();
                this.cmbRol.SelectedValue = emp.RolesId;
                this.cmbGradoGrupo.SelectedValue = emp.SalonId;

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
