
namespace FrmMainMenu
{
    partial class FrmEstadisticas
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
            this.lstEstadisticas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstEstadisticas
            // 
            this.lstEstadisticas.FormattingEnabled = true;
            this.lstEstadisticas.ItemHeight = 15;
            this.lstEstadisticas.Location = new System.Drawing.Point(-2, -3);
            this.lstEstadisticas.Name = "lstEstadisticas";
            this.lstEstadisticas.Size = new System.Drawing.Size(725, 214);
            this.lstEstadisticas.TabIndex = 0;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(722, 210);
            this.Controls.Add(this.lstEstadisticas);
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEstadisticas;
    }
}