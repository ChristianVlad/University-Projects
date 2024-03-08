namespace Ejercicio2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.plazos = new System.Windows.Forms.RadioButton();
            this.ahorros = new System.Windows.Forms.RadioButton();
            this.corriente = new System.Windows.Forms.RadioButton();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Inscribir = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.checkSanSalvador = new System.Windows.Forms.CheckBox();
            this.checkSoyapango = new System.Windows.Forms.CheckBox();
            this.checkLourdes = new System.Windows.Forms.CheckBox();
            this.checkMejicanos = new System.Windows.Forms.CheckBox();
            this.checkSonsonate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero de cuenta";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(77, 123);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(182, 22);
            this.txtnombre.TabIndex = 11;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(77, 197);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(182, 22);
            this.txtapellido.TabIndex = 12;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(77, 268);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(182, 22);
            this.txtDUI.TabIndex = 13;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(77, 335);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(182, 22);
            this.txtNIT.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de cuenta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // plazos
            // 
            this.plazos.AutoSize = true;
            this.plazos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plazos.Location = new System.Drawing.Point(423, 196);
            this.plazos.Name = "plazos";
            this.plazos.Size = new System.Drawing.Size(140, 22);
            this.plazos.TabIndex = 20;
            this.plazos.TabStop = true;
            this.plazos.Text = " Cuenta a plazos";
            this.plazos.UseVisualStyleBackColor = true;
            // 
            // ahorros
            // 
            this.ahorros.AutoSize = true;
            this.ahorros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ahorros.Location = new System.Drawing.Point(423, 161);
            this.ahorros.Name = "ahorros";
            this.ahorros.Size = new System.Drawing.Size(152, 22);
            this.ahorros.TabIndex = 19;
            this.ahorros.TabStop = true;
            this.ahorros.Text = "Cuenta de ahorros";
            this.ahorros.UseVisualStyleBackColor = true;
            // 
            // corriente
            // 
            this.corriente.AutoSize = true;
            this.corriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corriente.Location = new System.Drawing.Point(423, 130);
            this.corriente.Name = "corriente";
            this.corriente.Size = new System.Drawing.Size(142, 22);
            this.corriente.TabIndex = 18;
            this.corriente.TabStop = true;
            this.corriente.Text = " Cuenta corriente";
            this.corriente.UseVisualStyleBackColor = true;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(423, 284);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroCuenta.TabIndex = 21;
            this.txtNumeroCuenta.TextChanged += new System.EventHandler(this.txtNumeroCuenta_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Surcursal";
            // 
            // Inscribir
            // 
            this.Inscribir.AutoSize = true;
            this.Inscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inscribir.Location = new System.Drawing.Point(380, 25);
            this.Inscribir.Name = "Inscribir";
            this.Inscribir.Size = new System.Drawing.Size(221, 29);
            this.Inscribir.TabIndex = 28;
            this.Inscribir.Text = "Nueva Inscripcion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(277, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 40);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(549, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 40);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // checkSanSalvador
            // 
            this.checkSanSalvador.AutoSize = true;
            this.checkSanSalvador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSanSalvador.Location = new System.Drawing.Point(698, 131);
            this.checkSanSalvador.Name = "checkSanSalvador";
            this.checkSanSalvador.Size = new System.Drawing.Size(118, 22);
            this.checkSanSalvador.TabIndex = 31;
            this.checkSanSalvador.Text = "San Salvador";
            this.checkSanSalvador.UseVisualStyleBackColor = true;
            // 
            // checkSoyapango
            // 
            this.checkSoyapango.AutoSize = true;
            this.checkSoyapango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSoyapango.Location = new System.Drawing.Point(699, 173);
            this.checkSoyapango.Name = "checkSoyapango";
            this.checkSoyapango.Size = new System.Drawing.Size(105, 22);
            this.checkSoyapango.TabIndex = 32;
            this.checkSoyapango.Text = "Soyapango";
            this.checkSoyapango.UseVisualStyleBackColor = true;
            // 
            // checkLourdes
            // 
            this.checkLourdes.AutoSize = true;
            this.checkLourdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLourdes.Location = new System.Drawing.Point(698, 211);
            this.checkLourdes.Name = "checkLourdes";
            this.checkLourdes.Size = new System.Drawing.Size(84, 22);
            this.checkLourdes.TabIndex = 33;
            this.checkLourdes.Text = "Lourdes";
            this.checkLourdes.UseVisualStyleBackColor = true;
            // 
            // checkMejicanos
            // 
            this.checkMejicanos.AutoSize = true;
            this.checkMejicanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMejicanos.Location = new System.Drawing.Point(698, 250);
            this.checkMejicanos.Name = "checkMejicanos";
            this.checkMejicanos.Size = new System.Drawing.Size(98, 22);
            this.checkMejicanos.TabIndex = 34;
            this.checkMejicanos.Text = "Mejicanos";
            this.checkMejicanos.UseVisualStyleBackColor = true;
            // 
            // checkSonsonate
            // 
            this.checkSonsonate.AutoSize = true;
            this.checkSonsonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSonsonate.Location = new System.Drawing.Point(699, 286);
            this.checkSonsonate.Name = "checkSonsonate";
            this.checkSonsonate.Size = new System.Drawing.Size(102, 22);
            this.checkSonsonate.TabIndex = 35;
            this.checkSonsonate.Text = "Sonsonate";
            this.checkSonsonate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(942, 521);
            this.Controls.Add(this.checkSonsonate);
            this.Controls.Add(this.checkMejicanos);
            this.Controls.Add(this.checkLourdes);
            this.Controls.Add(this.checkSoyapango);
            this.Controls.Add(this.checkSanSalvador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Inscribir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.plazos);
            this.Controls.Add(this.ahorros);
            this.Controls.Add(this.corriente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton plazos;
        private System.Windows.Forms.RadioButton ahorros;
        private System.Windows.Forms.RadioButton corriente;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Inscribir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox checkSanSalvador;
        private System.Windows.Forms.CheckBox checkSoyapango;
        private System.Windows.Forms.CheckBox checkLourdes;
        private System.Windows.Forms.CheckBox checkMejicanos;
        private System.Windows.Forms.CheckBox checkSonsonate;
    }
}

