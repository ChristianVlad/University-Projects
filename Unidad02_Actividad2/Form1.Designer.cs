namespace Guia2_Unidad2
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
            this.lblNumPunto = new System.Windows.Forms.Label();
            this.lblLetras = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbNumPunto = new System.Windows.Forms.TextBox();
            this.txtbLetras = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumPunto
            // 
            this.lblNumPunto.AutoSize = true;
            this.lblNumPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPunto.Location = new System.Drawing.Point(55, 60);
            this.lblNumPunto.Name = "lblNumPunto";
            this.lblNumPunto.Size = new System.Drawing.Size(138, 20);
            this.lblNumPunto.TabIndex = 0;
            this.lblNumPunto.Text = "Números y Punto";
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras.Location = new System.Drawing.Point(55, 160);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(57, 20);
            this.lblLetras.TabIndex = 1;
            this.lblLetras.Text = "Letras";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(55, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtbNumPunto
            // 
            this.txtbNumPunto.Location = new System.Drawing.Point(255, 60);
            this.txtbNumPunto.Name = "txtbNumPunto";
            this.txtbNumPunto.Size = new System.Drawing.Size(242, 22);
            this.txtbNumPunto.TabIndex = 3;
            this.txtbNumPunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumPunto_KeyPress);
            // 
            // txtbLetras
            // 
            this.txtbLetras.Location = new System.Drawing.Point(255, 160);
            this.txtbLetras.Name = "txtbLetras";
            this.txtbLetras.Size = new System.Drawing.Size(242, 22);
            this.txtbLetras.TabIndex = 4;
            this.txtbLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbLetras_KeyPress);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(255, 260);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(242, 22);
            this.txtbEmail.TabIndex = 5;
            this.txtbEmail.Leave += new System.EventHandler(this.txtbEmail_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 353);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbLetras);
            this.Controls.Add(this.txtbNumPunto);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLetras);
            this.Controls.Add(this.lblNumPunto);
            this.Name = "Form1";
            this.Text = "Validad TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumPunto;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbNumPunto;
        private System.Windows.Forms.TextBox txtbLetras;
        private System.Windows.Forms.TextBox txtbEmail;
    }
}

