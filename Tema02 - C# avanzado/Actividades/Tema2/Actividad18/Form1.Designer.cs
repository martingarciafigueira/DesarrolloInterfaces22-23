namespace Actividad6
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
            this.dtpDiaElegido = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularDias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDiaElegido
            // 
            this.dtpDiaElegido.Location = new System.Drawing.Point(296, 159);
            this.dtpDiaElegido.Name = "dtpDiaElegido";
            this.dtpDiaElegido.Size = new System.Drawing.Size(200, 20);
            this.dtpDiaElegido.TabIndex = 0;
            // 
            // btnCalcularDias
            // 
            this.btnCalcularDias.Location = new System.Drawing.Point(322, 235);
            this.btnCalcularDias.Name = "btnCalcularDias";
            this.btnCalcularDias.Size = new System.Drawing.Size(141, 23);
            this.btnCalcularDias.TabIndex = 1;
            this.btnCalcularDias.Text = "Calcular días de diferencia";
            this.btnCalcularDias.UseVisualStyleBackColor = true;
            this.btnCalcularDias.Click += new System.EventHandler(this.btnCalcularDias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularDias);
            this.Controls.Add(this.dtpDiaElegido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDiaElegido;
        private System.Windows.Forms.Button btnCalcularDias;
    }
}

