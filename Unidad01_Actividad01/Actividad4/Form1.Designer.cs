namespace Analisis4
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
            listNumbers = new ListBox();
            ingreseValorlbl = new Label();
            valorTxb = new TextBox();
            ingresarbtn = new Button();
            groupBox1 = new GroupBox();
            btnCalcular = new Button();
            mayorPositivotxb = new TextBox();
            promedioImparestxb = new TextBox();
            porcentajeCerostxb = new TextBox();
            mayorNegativotxb = new TextBox();
            mayorParPositivolbl = new Label();
            promedioImpareslbl = new Label();
            porcentajeCeroslbl = new Label();
            mayorNegativolbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listNumbers
            // 
            listNumbers.FormattingEnabled = true;
            listNumbers.ItemHeight = 15;
            listNumbers.Location = new Point(37, 107);
            listNumbers.Margin = new Padding(2);
            listNumbers.Name = "listNumbers";
            listNumbers.Size = new Size(166, 334);
            listNumbers.TabIndex = 0;
            // 
            // ingreseValorlbl
            // 
            ingreseValorlbl.AutoSize = true;
            ingreseValorlbl.Location = new Point(37, 50);
            ingreseValorlbl.Margin = new Padding(2, 0, 2, 0);
            ingreseValorlbl.Name = "ingreseValorlbl";
            ingreseValorlbl.Size = new Size(143, 15);
            ingreseValorlbl.TabIndex = 1;
            ingreseValorlbl.Text = "Ingrese un valor al arreglo";
            // 
            // valorTxb
            // 
            valorTxb.Location = new Point(201, 47);
            valorTxb.Margin = new Padding(2);
            valorTxb.Name = "valorTxb";
            valorTxb.Size = new Size(88, 23);
            valorTxb.TabIndex = 2;
            // 
            // ingresarbtn
            // 
            ingresarbtn.Location = new Point(336, 47);
            ingresarbtn.Margin = new Padding(2);
            ingresarbtn.Name = "ingresarbtn";
            ingresarbtn.Size = new Size(65, 22);
            ingresarbtn.TabIndex = 3;
            ingresarbtn.Text = "Ingresar";
            ingresarbtn.UseVisualStyleBackColor = true;
            ingresarbtn.Click += ingresarbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(mayorPositivotxb);
            groupBox1.Controls.Add(promedioImparestxb);
            groupBox1.Controls.Add(porcentajeCerostxb);
            groupBox1.Controls.Add(mayorNegativotxb);
            groupBox1.Controls.Add(mayorParPositivolbl);
            groupBox1.Controls.Add(promedioImpareslbl);
            groupBox1.Controls.Add(porcentajeCeroslbl);
            groupBox1.Controls.Add(mayorNegativolbl);
            groupBox1.Location = new Point(250, 107);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(428, 335);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones con arreglo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(177, 273);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(65, 22);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // mayorPositivotxb
            // 
            mayorPositivotxb.Enabled = false;
            mayorPositivotxb.Location = new Point(243, 216);
            mayorPositivotxb.Margin = new Padding(2);
            mayorPositivotxb.Name = "mayorPositivotxb";
            mayorPositivotxb.Size = new Size(88, 23);
            mayorPositivotxb.TabIndex = 7;
            // 
            // promedioImparestxb
            // 
            promedioImparestxb.Enabled = false;
            promedioImparestxb.Location = new Point(243, 163);
            promedioImparestxb.Margin = new Padding(2);
            promedioImparestxb.Name = "promedioImparestxb";
            promedioImparestxb.Size = new Size(88, 23);
            promedioImparestxb.TabIndex = 6;
            // 
            // porcentajeCerostxb
            // 
            porcentajeCerostxb.Enabled = false;
            porcentajeCerostxb.Location = new Point(243, 111);
            porcentajeCerostxb.Margin = new Padding(2);
            porcentajeCerostxb.Name = "porcentajeCerostxb";
            porcentajeCerostxb.Size = new Size(88, 23);
            porcentajeCerostxb.TabIndex = 5;
            // 
            // mayorNegativotxb
            // 
            mayorNegativotxb.Enabled = false;
            mayorNegativotxb.Location = new Point(243, 52);
            mayorNegativotxb.Margin = new Padding(2);
            mayorNegativotxb.Name = "mayorNegativotxb";
            mayorNegativotxb.Size = new Size(88, 23);
            mayorNegativotxb.TabIndex = 4;
            // 
            // mayorParPositivolbl
            // 
            mayorParPositivolbl.AutoSize = true;
            mayorParPositivolbl.Location = new Point(33, 216);
            mayorParPositivolbl.Margin = new Padding(2, 0, 2, 0);
            mayorParPositivolbl.Name = "mayorParPositivolbl";
            mayorParPositivolbl.Size = new Size(156, 15);
            mayorParPositivolbl.TabIndex = 3;
            mayorParPositivolbl.Text = "Mayor de los pares positivos";
            // 
            // promedioImpareslbl
            // 
            promedioImpareslbl.AutoSize = true;
            promedioImpareslbl.Location = new Point(33, 163);
            promedioImpareslbl.Margin = new Padding(2, 0, 2, 0);
            promedioImpareslbl.Name = "promedioImpareslbl";
            promedioImpareslbl.Size = new Size(170, 15);
            promedioImpareslbl.TabIndex = 2;
            promedioImpareslbl.Text = "Promedio de impares positivos";
            // 
            // porcentajeCeroslbl
            // 
            porcentajeCeroslbl.AutoSize = true;
            porcentajeCeroslbl.Location = new Point(33, 111);
            porcentajeCeroslbl.Margin = new Padding(2, 0, 2, 0);
            porcentajeCeroslbl.Name = "porcentajeCeroslbl";
            porcentajeCeroslbl.Size = new Size(178, 15);
            porcentajeCeroslbl.TabIndex = 1;
            porcentajeCeroslbl.Text = "Porcentaje de ceros en el arreglo";
            // 
            // mayorNegativolbl
            // 
            mayorNegativolbl.AutoSize = true;
            mayorNegativolbl.Location = new Point(33, 58);
            mayorNegativolbl.Margin = new Padding(2, 0, 2, 0);
            mayorNegativolbl.Name = "mayorNegativolbl";
            mayorNegativolbl.Size = new Size(189, 15);
            mayorNegativolbl.TabIndex = 0;
            mayorNegativolbl.Text = "Número mayor de pares negativos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 478);
            Controls.Add(groupBox1);
            Controls.Add(ingresarbtn);
            Controls.Add(valorTxb);
            Controls.Add(ingreseValorlbl);
            Controls.Add(listNumbers);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listNumbers;
        private System.Windows.Forms.Label ingreseValorlbl;
        private System.Windows.Forms.TextBox valorTxb;
        private System.Windows.Forms.Button ingresarbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox mayorPositivotxb;
        private System.Windows.Forms.TextBox promedioImparestxb;
        private System.Windows.Forms.TextBox porcentajeCerostxb;
        private System.Windows.Forms.TextBox mayorNegativotxb;
        private System.Windows.Forms.Label mayorParPositivolbl;
        private System.Windows.Forms.Label promedioImpareslbl;
        private System.Windows.Forms.Label porcentajeCeroslbl;
        private System.Windows.Forms.Label mayorNegativolbl;
    }
}

