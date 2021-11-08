
namespace FrmInicio
{
    partial class FrmFiltradoGeneral
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
            this.lblInitTExt = new System.Windows.Forms.Label();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrientacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnShowInBoth = new System.Windows.Forms.RadioButton();
            this.rbtnShowInFile = new System.Windows.Forms.RadioButton();
            this.rbtnShowInScreen = new System.Windows.Forms.RadioButton();
            this.cmbOrientacion = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxXML = new System.Windows.Forms.CheckBox();
            this.cboxJson = new System.Windows.Forms.CheckBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInitTExt
            // 
            this.lblInitTExt.AutoSize = true;
            this.lblInitTExt.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInitTExt.Location = new System.Drawing.Point(12, 9);
            this.lblInitTExt.Name = "lblInitTExt";
            this.lblInitTExt.Size = new System.Drawing.Size(94, 23);
            this.lblInitTExt.TabIndex = 6;
            this.lblInitTExt.Text = "Filtrar por:";
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
            this.dtgvAlumnos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvAlumnos.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvAlumnos.Location = new System.Drawing.Point(0, 221);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.RowTemplate.Height = 25;
            this.dtgvAlumnos.Size = new System.Drawing.Size(747, 194);
            this.dtgvAlumnos.TabIndex = 14;
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
            // rbtnShowInBoth
            // 
            this.rbtnShowInBoth.AutoSize = true;
            this.rbtnShowInBoth.Location = new System.Drawing.Point(8, 189);
            this.rbtnShowInBoth.Name = "rbtnShowInBoth";
            this.rbtnShowInBoth.Size = new System.Drawing.Size(63, 19);
            this.rbtnShowInBoth.TabIndex = 15;
            this.rbtnShowInBoth.TabStop = true;
            this.rbtnShowInBoth.Text = "Ambos";
            this.rbtnShowInBoth.UseVisualStyleBackColor = true;
            this.rbtnShowInBoth.CheckedChanged += new System.EventHandler(this.rbtnShowInBoth_CheckedChanged);
            // 
            // rbtnShowInFile
            // 
            this.rbtnShowInFile.AutoSize = true;
            this.rbtnShowInFile.Location = new System.Drawing.Point(8, 170);
            this.rbtnShowInFile.Name = "rbtnShowInFile";
            this.rbtnShowInFile.Size = new System.Drawing.Size(66, 19);
            this.rbtnShowInFile.TabIndex = 16;
            this.rbtnShowInFile.TabStop = true;
            this.rbtnShowInFile.Text = "Archivo";
            this.rbtnShowInFile.UseVisualStyleBackColor = true;
            this.rbtnShowInFile.CheckedChanged += new System.EventHandler(this.rbtnShowInFile_CheckedChanged);
            // 
            // rbtnShowInScreen
            // 
            this.rbtnShowInScreen.AutoSize = true;
            this.rbtnShowInScreen.Location = new System.Drawing.Point(8, 151);
            this.rbtnShowInScreen.Name = "rbtnShowInScreen";
            this.rbtnShowInScreen.Size = new System.Drawing.Size(67, 19);
            this.rbtnShowInScreen.TabIndex = 17;
            this.rbtnShowInScreen.TabStop = true;
            this.rbtnShowInScreen.Text = "Pantalla";
            this.rbtnShowInScreen.UseVisualStyleBackColor = true;
            this.rbtnShowInScreen.CheckedChanged += new System.EventHandler(this.rbtnShowInScreen_CheckedChanged);
            // 
            // cmbOrientacion
            // 
            this.cmbOrientacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrientacion.FormattingEnabled = true;
            this.cmbOrientacion.Location = new System.Drawing.Point(467, 79);
            this.cmbOrientacion.Name = "cmbOrientacion";
            this.cmbOrientacion.Size = new System.Drawing.Size(108, 23);
            this.cmbOrientacion.TabIndex = 19;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(316, 79);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(108, 23);
            this.cmbTurno.TabIndex = 20;
            // 
            // cmbSector
            // 
            this.cmbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(165, 79);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(108, 23);
            this.cmbSector.TabIndex = 21;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(660, 184);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 22;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(12, 79);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(108, 23);
            this.cmbGenero.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Turno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Orientacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mostrar en:";
            // 
            // cboxXML
            // 
            this.cboxXML.AutoSize = true;
            this.cboxXML.Location = new System.Drawing.Point(119, 170);
            this.cboxXML.Name = "cboxXML";
            this.cboxXML.Size = new System.Drawing.Size(136, 19);
            this.cboxXML.TabIndex = 30;
            this.cboxXML.Text = "Generar archivo XML";
            this.cboxXML.UseVisualStyleBackColor = true;
            // 
            // cboxJson
            // 
            this.cboxJson.AutoSize = true;
            this.cboxJson.Location = new System.Drawing.Point(119, 190);
            this.cboxJson.Name = "cboxJson";
            this.cboxJson.Size = new System.Drawing.Size(140, 19);
            this.cboxJson.TabIndex = 31;
            this.cboxJson.Text = "Generar archivo JSON";
            this.cboxJson.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(298, 185);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(277, 23);
            this.txtPath.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Inserte ruta de guardado:(Opcional)";
            // 
            // FrmFiltradoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.cboxJson);
            this.Controls.Add(this.cboxXML);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbOrientacion);
            this.Controls.Add(this.rbtnShowInScreen);
            this.Controls.Add(this.rbtnShowInFile);
            this.Controls.Add(this.rbtnShowInBoth);
            this.Controls.Add(this.dtgvAlumnos);
            this.Controls.Add(this.lblInitTExt);
            this.Name = "FrmFiltradoGeneral";
            this.Text = "FrmFiltradoGeneral";
            this.Load += new System.EventHandler(this.FrmFiltradoGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInitTExt;
        private System.Windows.Forms.DataGridView dtgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrientacion;
        private System.Windows.Forms.RadioButton rbtnShowInBoth;
        private System.Windows.Forms.RadioButton rbtnShowInFile;
        private System.Windows.Forms.RadioButton rbtnShowInScreen;
        private System.Windows.Forms.ComboBox cmbOrientacion;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cboxXML;
        private System.Windows.Forms.CheckBox cboxJson;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
    }
}