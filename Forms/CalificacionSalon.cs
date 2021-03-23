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
    public partial class CalificacionSalon : Form
    {
        ControlDBContext db;
        public CalificacionSalon()
        {
            InitializeComponent();
            db = new ControlDBContext();
            llenarGrupoA();
            llenarGrupoB();
        }

        private void llenarGrupoA()
        {
            this.gridViewA.DataSource = db.Grupos.Join(
                db.Alumno,
                Grupos => Grupos.Id,
                Alumno => Alumno.GrupoId,
                (Grupos, Alumno) => new { Grupos, Alumno })
                .Where(a => a.Grupos.Grupo == "4-A")
                .Select(z => new
                {
                    Id = z.Alumno.Id,
                    Alumno = z.Alumno.Nombre+" "+ z.Alumno.Apellido,
                    Promedio = z.Alumno.promedio
                }).ToList();
        }

        private void llenarGrupoB()
        {
            this.gridViewB.DataSource = db.Grupos.Join(
                db.Alumno,
                Grupos => Grupos.Id,
                Alumno => Alumno.GrupoId,
                (Grupos, Alumno) => new { Grupos, Alumno })
                .Where(a => a.Grupos.Grupo == "4-B")
                .Select(z => new
                {
                    Id = z.Alumno.Id,
                    Alumno = z.Alumno.Nombre + " " + z.Alumno.Apellido,
                    Promedio = z.Alumno.promedio
                }).ToList();
        }

    }
}
