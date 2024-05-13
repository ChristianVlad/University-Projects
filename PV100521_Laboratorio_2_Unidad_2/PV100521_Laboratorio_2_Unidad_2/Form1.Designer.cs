namespace PV100521_Laboratorio_2_Unidad_2
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            Modificar = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(519, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(29, 259);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 48);
            button2.TabIndex = 2;
            button2.Text = "Recargar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(121, 259);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 48);
            button1.TabIndex = 3;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Modificar
            // 
            Modificar.Location = new Point(216, 259);
            Modificar.Margin = new Padding(3, 4, 3, 4);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(86, 48);
            Modificar.TabIndex = 4;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(308, 259);
            button3.Name = "button3";
            button3.Size = new Size(86, 48);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 401);
            Controls.Add(button3);
            Controls.Add(Modificar);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Unidad 2 - Laboratorio 2 - Christian Vladimir Peña Valladares - PV100521";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Button Modificar;
        private Button button3;
    }
}
