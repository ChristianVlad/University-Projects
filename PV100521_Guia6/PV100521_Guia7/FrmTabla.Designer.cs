namespace PV100521_Guia7
{
    partial class FrmTabla
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
            TxtId = new TextBox();
            TxtNombre = new TextBox();
            TxtCorreo = new TextBox();
            DtpFecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnGuardar = new Button();
            SuspendLayout();
            // 
            // TxtId
            // 
            TxtId.Location = new Point(349, 101);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(200, 23);
            TxtId.TabIndex = 0;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(349, 167);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(200, 23);
            TxtNombre.TabIndex = 1;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(349, 227);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(200, 23);
            TxtCorreo.TabIndex = 2;
            // 
            // DtpFecha
            // 
            DtpFecha.Location = new Point(349, 292);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(200, 23);
            DtpFecha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 104);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 175);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 235);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 300);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(504, 361);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(110, 54);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // FrmTabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DtpFecha);
            Controls.Add(TxtCorreo);
            Controls.Add(TxtNombre);
            Controls.Add(TxtId);
            Name = "FrmTabla";
            Text = "FrmTabla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtId;
        private TextBox TxtNombre;
        private TextBox TxtCorreo;
        private DateTimePicker DtpFecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnGuardar;
    }
}