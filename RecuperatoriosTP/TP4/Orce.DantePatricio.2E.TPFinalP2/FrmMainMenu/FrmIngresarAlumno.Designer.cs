
namespace FrmInicio
{
    partial class FrmIngresarAlumno
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbOrientacion = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblOrientacion = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrientacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 329);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese nombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(202, 329);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese apellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(379, 329);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PlaceholderText = "Ingrese edad";
            this.txtEdad.Size = new System.Drawing.Size(134, 23);
            this.txtEdad.TabIndex = 2;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(17, 405);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(90, 23);
            this.cmbGenero.TabIndex = 3;
            // 
            // cmbSector
            // 
            this.cmbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(151, 405);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(90, 23);
            this.cmbSector.TabIndex = 4;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(277, 405);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(90, 23);
            this.cmbTurno.TabIndex = 5;
            // 
            // cmbOrientacion
            // 
            this.cmbOrientacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrientacion.FormattingEnabled = true;
            this.cmbOrientacion.Location = new System.Drawing.Point(413, 405);
            this.cmbOrientacion.Name = "cmbOrientacion";
            this.cmbOrientacion.Size = new System.Drawing.Size(90, 23);
            this.cmbOrientacion.TabIndex = 6;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(17, 384);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 15);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Genero";
            // 
            // txtSector
            // 
            this.txtSector.AutoSize = true;
            this.txtSector.Location = new System.Drawing.Point(151, 384);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(40, 15);
            this.txtSector.TabIndex = 8;
            this.txtSector.Text = "Sector";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(277, 387);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 15);
            this.lblTurno.TabIndex = 9;
            this.lblTurno.Text = "Turno";
            // 
            // lblOrientacion
            // 
            this.lblOrientacion.AutoSize = true;
            this.lblOrientacion.Location = new System.Drawing.Point(413, 387);
            this.lblOrientacion.Name = "lblOrientacion";
            this.lblOrientacion.Size = new System.Drawing.Size(69, 15);
            this.lblOrientacion.TabIndex = 10;
            this.lblOrientacion.Text = "Orientacion";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(575, 343);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(156, 69);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dtgvAlumnos
            // 
            this.dtgvAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colApellido,
            this.colEdad,
            this.colGenero,
            this.colSector,
            this.colTurno,
            this.colOrientacion});
            this.dtgvAlumnos.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvAlumnos.Location = new System.Drawing.Point(13, 12);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.RowTemplate.Height = 25;
            this.dtgvAlumnos.Size = new System.Drawing.Size(744, 291);
            this.dtgvAlumnos.TabIndex = 13;
            // 
            // colName
            // 
            this.colName.Frozen = true;
            this.colName.HeaderText = "Nombre";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.Frozen = true;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colEdad
            // 
            this.colEdad.Frozen = true;
            this.colEdad.HeaderText = "Edad";
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.Frozen = true;
            this.colGenero.HeaderText = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            // 
            // colSector
            // 
            this.colSector.Frozen = true;
            this.colSector.HeaderText = "Sector";
            this.colSector.Name = "colSector";
            this.colSector.ReadOnly = true;
            // 
            // colTurno
            // 
            this.colTurno.Frozen = true;
            this.colTurno.HeaderText = "Turno";
            this.colTurno.Name = "colTurno";
            this.colTurno.ReadOnly = true;
            // 
            // colOrientacion
            // 
            this.colOrientacion.Frozen = true;
            this.colOrientacion.HeaderText = "Orientacion";
            this.colOrientacion.Name = "colOrientacion";
            this.colOrientacion.ReadOnly = true;
            // 
            // FrmIngresarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.dtgvAlumnos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblOrientacion);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbOrientacion);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmIngresarAlumno";
            this.Text = "FrmIngresarAlumno";
            this.Load += new System.EventHandler(this.FrmIngresarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbOrientacion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label txtSector;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblOrientacion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dtgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrientacion;
    }
}