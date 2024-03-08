namespace Actividad1
{
    partial class Actividad1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtsalario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textDescuentos = new TextBox();
            textNeto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            radioGerente = new RadioButton();
            RadioSub = new RadioButton();
            radioSecretaria = new RadioButton();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(181, 107);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(163, 23);
            txtnombre.TabIndex = 1;
            txtnombre.TextChanged += textBox2_TextChanged;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(483, 107);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(163, 23);
            txtapellido.TabIndex = 2;
            txtapellido.TextChanged += textBox3_TextChanged;
            // 
            // txtsalario
            // 
            txtsalario.Location = new Point(218, 192);
            txtsalario.Name = "txtsalario";
            txtsalario.Size = new Size(163, 23);
            txtsalario.TabIndex = 3;
            txtsalario.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 115);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 110);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 200);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Salario";
            // 
            // textDescuentos
            // 
            textDescuentos.Location = new Point(218, 264);
            textDescuentos.Name = "textDescuentos";
            textDescuentos.ReadOnly = true;
            textDescuentos.Size = new Size(163, 23);
            textDescuentos.TabIndex = 7;
            textDescuentos.TextChanged += textBox5_TextChanged;
            // 
            // textNeto
            // 
            textNeto.Location = new Point(218, 309);
            textNeto.Name = "textNeto";
            textNeto.ReadOnly = true;
            textNeto.Size = new Size(163, 23);
            textNeto.TabIndex = 8;
            textNeto.TextChanged += textBox6_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 272);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Descuento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 317);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Salario Neto";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(390, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioGerente
            // 
            radioGerente.AutoSize = true;
            radioGerente.Location = new Point(540, 200);
            radioGerente.Name = "radioGerente";
            radioGerente.Size = new Size(66, 19);
            radioGerente.TabIndex = 12;
            radioGerente.TabStop = true;
            radioGerente.Text = "Gerente";
            radioGerente.UseVisualStyleBackColor = true;
            radioGerente.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // RadioSub
            // 
            RadioSub.AutoSize = true;
            RadioSub.Location = new Point(540, 245);
            RadioSub.Name = "RadioSub";
            RadioSub.Size = new Size(89, 19);
            RadioSub.TabIndex = 13;
            RadioSub.TabStop = true;
            RadioSub.Text = "Sub Gerente";
            RadioSub.UseVisualStyleBackColor = true;
            RadioSub.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioSecretaria
            // 
            radioSecretaria.AutoSize = true;
            radioSecretaria.Location = new Point(540, 292);
            radioSecretaria.Name = "radioSecretaria";
            radioSecretaria.Size = new Size(76, 19);
            radioSecretaria.TabIndex = 14;
            radioSecretaria.TabStop = true;
            radioSecretaria.Text = "Secretaria";
            radioSecretaria.UseVisualStyleBackColor = true;
            radioSecretaria.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(285, 49);
            label6.Name = "label6";
            label6.Size = new Size(229, 21);
            label6.TabIndex = 15;
            label6.Text = "CALCULADORA DE SALARIOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 508);
            Controls.Add(label6);
            Controls.Add(radioSecretaria);
            Controls.Add(RadioSub);
            Controls.Add(radioGerente);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textNeto);
            Controls.Add(textDescuentos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsalario);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Name = "Form1";
            Text = "Ventana de Empleados";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtsalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textDescuentos;
        private TextBox textNeto;
        private Label label4;
        private Label label5;
        private Button button1;
        private RadioButton radioGerente;
        private RadioButton RadioSub;
        private RadioButton radioSecretaria;
        private Label label6;
    }
}
