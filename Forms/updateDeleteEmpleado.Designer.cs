
namespace EscuelaPeñaNieto.Forms
{
    partial class updateDeleteEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnBaja = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGradoGrupo = new System.Windows.Forms.ComboBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.cmbRol);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.txtCedula);
            this.panelDesktop.Controls.Add(this.txtId);
            this.panelDesktop.Controls.Add(this.iconPictureBox1);
            this.panelDesktop.Controls.Add(this.btnBaja);
            this.panelDesktop.Controls.Add(this.btnModificar);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.cmbGradoGrupo);
            this.panelDesktop.Controls.Add(this.txtApellidos);
            this.panelDesktop.Controls.Add(this.txtNombre);
            this.panelDesktop.Controls.Add(this.groupBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(916, 569);
            this.panelDesktop.TabIndex = 6;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(716, 361);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(142, 27);
            this.cmbRol.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(526, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "Rol:";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtCedula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.White;
            this.txtCedula.Location = new System.Drawing.Point(269, 421);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(204, 27);
            this.txtCedula.TabIndex = 40;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(742, 212);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 22);
            this.txtId.TabIndex = 39;
            this.txtId.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 75;
            this.iconPictureBox1.Location = new System.Drawing.Point(477, 201);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(75, 82);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 38;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnBaja
            // 
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.Red;
            this.btnBaja.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.btnBaja.IconColor = System.Drawing.Color.Red;
            this.btnBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaja.IconSize = 30;
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.Location = new System.Drawing.Point(716, 515);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(183, 42);
            this.btnBaja.TabIndex = 37;
            this.btnBaja.Text = "Despedir";
            this.btnBaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnModificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(561, 515);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 42);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(106, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(106, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(106, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(526, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Grado y Grupo:";
            // 
            // cmbGradoGrupo
            // 
            this.cmbGradoGrupo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradoGrupo.FormattingEnabled = true;
            this.cmbGradoGrupo.Location = new System.Drawing.Point(716, 421);
            this.cmbGradoGrupo.Name = "cmbGradoGrupo";
            this.cmbGradoGrupo.Size = new System.Drawing.Size(142, 27);
            this.cmbGradoGrupo.TabIndex = 29;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtApellidos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(269, 370);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(204, 27);
            this.txtApellidos.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(269, 327);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 27);
            this.txtNombre.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridViewAlumnos);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 172);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // gridViewAlumnos
            // 
            this.gridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridViewAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.gridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewAlumnos.Location = new System.Drawing.Point(3, 29);
            this.gridViewAlumnos.Name = "gridViewAlumnos";
            this.gridViewAlumnos.RowHeadersWidth = 51;
            this.gridViewAlumnos.RowTemplate.Height = 24;
            this.gridViewAlumnos.Size = new System.Drawing.Size(876, 140);
            this.gridViewAlumnos.TabIndex = 0;
            this.gridViewAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAlumnos_CellClick);
            // 
            // updateDeleteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 569);
            this.Controls.Add(this.panelDesktop);
            this.Name = "updateDeleteEmpleado";
            this.Text = "updateDeleteEmpleado";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnBaja;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGradoGrupo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridViewAlumnos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label5;
    }
}