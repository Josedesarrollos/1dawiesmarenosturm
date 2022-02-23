
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aluNota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.aluNota)).BeginInit();
            this.SuspendLayout();
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(204, 198);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(294, 78);
            this.listaAlumnos.TabIndex = 0;
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(111, 118);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(100, 20);
            this.aluNombre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(419, 118);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(120, 20);
            this.aluNota.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.listaAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.aluNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listaAlumnos;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown aluNota;
    }
}

