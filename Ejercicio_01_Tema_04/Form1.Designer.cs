namespace Ejercicio_01_Tema_04
{
    partial class Form1_Ejercicio_01_Tema_04
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(61, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ejercicio_01_Tema_04";
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.Color.DarkGray;
            this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.Location = new System.Drawing.Point(68, 163);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(152, 64);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.Text = "Acción";
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(63, 260);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(191, 29);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "El resultado es...";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(68, 108);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 26);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(324, 108);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 26);
            this.txtNum2.TabIndex = 4;
            // 
            // Form1_Ejercicio_01_Tema_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1_Ejercicio_01_Tema_04";
            this.Text = "Ejercicio_01_Tema_04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

