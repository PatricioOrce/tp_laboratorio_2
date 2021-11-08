
namespace FrmInicio
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.lblInicioText = new System.Windows.Forms.Label();
            this.btnNewAlumno = new System.Windows.Forms.Button();
            this.studentIMG = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnData = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicioText
            // 
            this.lblInicioText.AutoSize = true;
            this.lblInicioText.BackColor = System.Drawing.Color.Transparent;
            this.lblInicioText.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInicioText.ForeColor = System.Drawing.Color.White;
            this.lblInicioText.Location = new System.Drawing.Point(100, 32);
            this.lblInicioText.Name = "lblInicioText";
            this.lblInicioText.Size = new System.Drawing.Size(333, 24);
            this.lblInicioText.TabIndex = 0;
            this.lblInicioText.Text = "Hey! Bienvenido, Que deseas hacer?";
            // 
            // btnNewAlumno
            // 
            this.btnNewAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnNewAlumno.Location = new System.Drawing.Point(23, 199);
            this.btnNewAlumno.Name = "btnNewAlumno";
            this.btnNewAlumno.Size = new System.Drawing.Size(160, 50);
            this.btnNewAlumno.TabIndex = 1;
            this.btnNewAlumno.Text = "Ingresar Alumno";
            this.btnNewAlumno.UseVisualStyleBackColor = false;
            this.btnNewAlumno.Click += new System.EventHandler(this.btnNewAlumno_Click);
            // 
            // studentIMG
            // 
            this.studentIMG.BackColor = System.Drawing.Color.Transparent;
            this.studentIMG.Image = ((System.Drawing.Image)(resources.GetObject("studentIMG.Image")));
            this.studentIMG.Location = new System.Drawing.Point(42, 88);
            this.studentIMG.Name = "studentIMG";
            this.studentIMG.Size = new System.Drawing.Size(125, 95);
            this.studentIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentIMG.TabIndex = 2;
            this.studentIMG.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.Location = new System.Drawing.Point(350, 198);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(160, 50);
            this.btnData.TabIndex = 4;
            this.btnData.Text = "Analisar Datos";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(235, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 66);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 269);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentIMG);
            this.Controls.Add(this.btnNewAlumno);
            this.Controls.Add(this.lblInicioText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicioText;
        private System.Windows.Forms.Button btnNewAlumno;
        private System.Windows.Forms.PictureBox studentIMG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}

