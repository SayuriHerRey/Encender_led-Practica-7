namespace Encender_led_Practica_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.Encender = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encender led";
            // 
            // Encender
            // 
            this.Encender.BackColor = System.Drawing.Color.Pink;
            this.Encender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encender.ForeColor = System.Drawing.Color.Crimson;
            this.Encender.Location = new System.Drawing.Point(78, 130);
            this.Encender.Name = "Encender";
            this.Encender.Size = new System.Drawing.Size(157, 52);
            this.Encender.TabIndex = 1;
            this.Encender.Text = "Apagar";
            this.Encender.UseVisualStyleBackColor = false;
            this.Encender.Click += new System.EventHandler(this.Encender_Click);
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.Color.PaleGreen;
            this.Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagar.ForeColor = System.Drawing.Color.DarkGreen;
            this.Apagar.Location = new System.Drawing.Point(78, 62);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(157, 46);
            this.Apagar.TabIndex = 2;
            this.Apagar.Text = "Encender";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(304, 284);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.Encender);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Led_Arduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Encender;
        private System.Windows.Forms.Button Apagar;
    }
}

