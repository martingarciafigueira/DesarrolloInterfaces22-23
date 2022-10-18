namespace Ejercicio1
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnMostrarCaracteres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNElementos = new System.Windows.Forms.TextBox();
            this.btnMostrarNCaracteres = new System.Windows.Forms.Button();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtReemplazar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCadena2 = new System.Windows.Forms.TextBox();
            this.btnCompararCadenas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(263, 90);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 22);
            this.txtCadena.TabIndex = 0;
            // 
            // btnMostrarCaracteres
            // 
            this.btnMostrarCaracteres.Location = new System.Drawing.Point(133, 298);
            this.btnMostrarCaracteres.Name = "btnMostrarCaracteres";
            this.btnMostrarCaracteres.Size = new System.Drawing.Size(105, 60);
            this.btnMostrarCaracteres.TabIndex = 1;
            this.btnMostrarCaracteres.Text = "Mostrar número de caracteres";
            this.btnMostrarCaracteres.UseVisualStyleBackColor = true;
            this.btnMostrarCaracteres.Click += new System.EventHandler(this.btnMostrarCaracteres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº elementos";
            // 
            // txtNElementos
            // 
            this.txtNElementos.Location = new System.Drawing.Point(626, 90);
            this.txtNElementos.Name = "txtNElementos";
            this.txtNElementos.Size = new System.Drawing.Size(100, 22);
            this.txtNElementos.TabIndex = 4;
            // 
            // btnMostrarNCaracteres
            // 
            this.btnMostrarNCaracteres.Location = new System.Drawing.Point(268, 298);
            this.btnMostrarNCaracteres.Name = "btnMostrarNCaracteres";
            this.btnMostrarNCaracteres.Size = new System.Drawing.Size(105, 60);
            this.btnMostrarNCaracteres.TabIndex = 5;
            this.btnMostrarNCaracteres.Text = "Mostrar N primeros caracteres";
            this.btnMostrarNCaracteres.UseVisualStyleBackColor = true;
            this.btnMostrarNCaracteres.Click += new System.EventHandler(this.btnMostrarNCaracteres_Click);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(407, 298);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(105, 60);
            this.btnReemplazar.TabIndex = 6;
            this.btnReemplazar.Text = "Reemplazar ";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reemplazar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(626, 165);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 9;
            // 
            // txtReemplazar
            // 
            this.txtReemplazar.Location = new System.Drawing.Point(626, 202);
            this.txtReemplazar.Name = "txtReemplazar";
            this.txtReemplazar.Size = new System.Drawing.Size(100, 22);
            this.txtReemplazar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cadena";
            // 
            // txtCadena2
            // 
            this.txtCadena2.Location = new System.Drawing.Point(263, 163);
            this.txtCadena2.Name = "txtCadena2";
            this.txtCadena2.Size = new System.Drawing.Size(100, 22);
            this.txtCadena2.TabIndex = 11;
            // 
            // btnCompararCadenas
            // 
            this.btnCompararCadenas.Location = new System.Drawing.Point(541, 298);
            this.btnCompararCadenas.Name = "btnCompararCadenas";
            this.btnCompararCadenas.Size = new System.Drawing.Size(105, 60);
            this.btnCompararCadenas.TabIndex = 13;
            this.btnCompararCadenas.Text = "Comparar";
            this.btnCompararCadenas.UseVisualStyleBackColor = true;
            this.btnCompararCadenas.Click += new System.EventHandler(this.btnCompararCadenas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompararCadenas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCadena2);
            this.Controls.Add(this.txtReemplazar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.btnMostrarNCaracteres);
            this.Controls.Add(this.txtNElementos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarCaracteres);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnMostrarCaracteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNElementos;
        private System.Windows.Forms.Button btnMostrarNCaracteres;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtReemplazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCadena2;
        private System.Windows.Forms.Button btnCompararCadenas;
    }
}

