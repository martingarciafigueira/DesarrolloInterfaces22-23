﻿namespace Ejercicio8
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
            this.txtGradosCelsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGradosFahrenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGradosCelsius
            // 
            this.txtGradosCelsius.Location = new System.Drawing.Point(159, 108);
            this.txtGradosCelsius.Name = "txtGradosCelsius";
            this.txtGradosCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtGradosCelsius.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grados Celsius:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convertir a Fahrenheit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ºF";
            // 
            // lblGradosFahrenheit
            // 
            this.lblGradosFahrenheit.AutoSize = true;
            this.lblGradosFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosFahrenheit.Location = new System.Drawing.Point(580, 106);
            this.lblGradosFahrenheit.Name = "lblGradosFahrenheit";
            this.lblGradosFahrenheit.Size = new System.Drawing.Size(24, 25);
            this.lblGradosFahrenheit.TabIndex = 4;
            this.lblGradosFahrenheit.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGradosFahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGradosCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGradosCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGradosFahrenheit;
    }
}

