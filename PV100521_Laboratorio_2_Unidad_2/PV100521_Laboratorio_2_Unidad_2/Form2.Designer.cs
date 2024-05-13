namespace PV100521_Laboratorio_2_Unidad_2
{
    partial class Nuevos_Registros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Codigo_txt = new TextBox();
            label2 = new Label();
            Producto_txt = new TextBox();
            Precio_txt = new TextBox();
            Unidades_txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Guardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 59);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de Producto";
            // 
            // Codigo_txt
            // 
            Codigo_txt.Location = new Point(209, 51);
            Codigo_txt.Name = "Codigo_txt";
            Codigo_txt.Size = new Size(151, 23);
            Codigo_txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 119);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Producto";
            // 
            // Producto_txt
            // 
            Producto_txt.Location = new Point(209, 111);
            Producto_txt.Name = "Producto_txt";
            Producto_txt.Size = new Size(151, 23);
            Producto_txt.TabIndex = 3;
            // 
            // Precio_txt
            // 
            Precio_txt.Location = new Point(209, 176);
            Precio_txt.Name = "Precio_txt";
            Precio_txt.Size = new Size(151, 23);
            Precio_txt.TabIndex = 4;
            // 
            // Unidades_txt
            // 
            Unidades_txt.Location = new Point(209, 229);
            Unidades_txt.Name = "Unidades_txt";
            Unidades_txt.Size = new Size(151, 23);
            Unidades_txt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 184);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio Unitario";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 237);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Unidades";
            // 
            // Guardar
            // 
            Guardar.Location = new Point(285, 333);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(75, 42);
            Guardar.TabIndex = 8;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // Nuevos_Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 431);
            Controls.Add(Guardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Unidades_txt);
            Controls.Add(Precio_txt);
            Controls.Add(Producto_txt);
            Controls.Add(label2);
            Controls.Add(Codigo_txt);
            Controls.Add(label1);
            Name = "Nuevos_Registros";
            Text = "Nuevos Registros";
            Load += Nuevos_Registros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Codigo_txt;
        private Label label2;
        private TextBox Producto_txt;
        private TextBox Precio_txt;
        private TextBox Unidades_txt;
        private Label label3;
        private Label label4;
        private Button Guardar;
    }
}