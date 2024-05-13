namespace PV100521_Guia7
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
            splitContainer1 = new SplitContainer();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            dataGridView2 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha_Nacimiento = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnEliminar);
            splitContainer1.Panel1.Controls.Add(BtnEditar);
            splitContainer1.Panel1.Controls.Add(BtnNuevo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(797, 450);
            splitContainer1.SplitterDistance = 80;
            splitContainer1.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(311, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 74);
            BtnEliminar.TabIndex = 2;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(176, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(112, 74);
            BtnEditar.TabIndex = 1;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(47, 4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(112, 74);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Correo, Fecha_Nacimiento });
            dataGridView2.Location = new Point(31, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(547, 120);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            Correo.HeaderText = "correo";
            Correo.MaxInputLength = 35000;
            Correo.Name = "Correo";
            // 
            // Fecha_Nacimiento
            // 
            Fecha_Nacimiento.HeaderText = "fecha_nacimiento";
            Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(797, 366);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnNuevo;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha_Nacimiento;
    }
}
