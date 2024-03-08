namespace Ejemplo_1
{
    partial class FrmRecibe
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
            this.dgvRecibe = new System.Windows.Forms.DataGridView();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecibe
            // 
            this.dgvRecibe.AllowUserToOrderColumns = true;
            this.dgvRecibe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibe.Location = new System.Drawing.Point(36, 74);
            this.dgvRecibe.Name = "dgvRecibe";
            this.dgvRecibe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibe.Size = new System.Drawing.Size(737, 305);
            this.dgvRecibe.TabIndex = 0;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(359, 409);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(90, 29);
            this.btnLlenar.TabIndex = 1;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFiltro.Location = new System.Drawing.Point(205, 25);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(360, 26);
            this.tbxFiltro.TabIndex = 3;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // FrmRecibe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.dgvRecibe);
            this.Name = "FrmRecibe";
            this.Text = "FrmRecibe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecibe;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFiltro;
    }
}