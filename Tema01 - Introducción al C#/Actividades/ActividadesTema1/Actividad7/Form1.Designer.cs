namespace Actividad2
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
            this.btnCambiarColorTexto = new System.Windows.Forms.Button();
            this.lblCambioTextoColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCambiarColorTexto
            // 
            this.btnCambiarColorTexto.Location = new System.Drawing.Point(204, 183);
            this.btnCambiarColorTexto.Name = "btnCambiarColorTexto";
            this.btnCambiarColorTexto.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarColorTexto.TabIndex = 0;
            this.btnCambiarColorTexto.Text = "button1";
            this.btnCambiarColorTexto.UseVisualStyleBackColor = true;
            this.btnCambiarColorTexto.Click += new System.EventHandler(this.btnCambiarColorTexto_Click);
            // 
            // lblCambioTextoColor
            // 
            this.lblCambioTextoColor.AutoSize = true;
            this.lblCambioTextoColor.Location = new System.Drawing.Point(493, 183);
            this.lblCambioTextoColor.Name = "lblCambioTextoColor";
            this.lblCambioTextoColor.Size = new System.Drawing.Size(173, 13);
            this.lblCambioTextoColor.TabIndex = 1;
            this.lblCambioTextoColor.Text = "Voy a cambiar de color y contenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCambioTextoColor);
            this.Controls.Add(this.btnCambiarColorTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarColorTexto;
        private System.Windows.Forms.Label lblCambioTextoColor;
    }
}

