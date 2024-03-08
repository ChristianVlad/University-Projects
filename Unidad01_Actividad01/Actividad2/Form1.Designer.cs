namespace Actividad2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            var_a = new TextBox();
            var_b = new TextBox();
            var_c = new TextBox();
            txtResults1 = new TextBox();
            txtResults2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 67);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
            label1.TabIndex = 0;
            label1.Text = "Formula cuadratica";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 145);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 145);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 145);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 270);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 4;
            label5.Text = "x1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 343);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 5;
            label6.Text = "x2";
            // 
            // var_a
            // 
            var_a.Location = new Point(204, 141);
            var_a.Name = "var_a";
            var_a.Size = new Size(100, 23);
            var_a.TabIndex = 6;
            var_a.TextChanged += var_a_TextChanged;
            // 
            // var_b
            // 
            var_b.Location = new Point(392, 145);
            var_b.Name = "var_b";
            var_b.Size = new Size(100, 23);
            var_b.TabIndex = 7;
            var_b.TextChanged += var_b_TextChanged;
            // 
            // var_c
            // 
            var_c.Location = new Point(561, 145);
            var_c.Name = "var_c";
            var_c.Size = new Size(100, 23);
            var_c.TabIndex = 8;
            var_c.TextChanged += var_c_TextChanged;
            // 
            // txtResults1
            // 
            txtResults1.Location = new Point(204, 267);
            txtResults1.Name = "txtResults1";
            txtResults1.ReadOnly = true;
            txtResults1.Size = new Size(100, 23);
            txtResults1.TabIndex = 9;
            // 
            // txtResults2
            // 
            txtResults2.Location = new Point(204, 343);
            txtResults2.Name = "txtResults2";
            txtResults2.ReadOnly = true;
            txtResults2.Size = new Size(100, 23);
            txtResults2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(519, 331);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtResults2);
            Controls.Add(txtResults1);
            Controls.Add(var_c);
            Controls.Add(var_b);
            Controls.Add(var_a);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox var_a;
        private TextBox var_b;
        private TextBox var_c;
        private TextBox raiz1;
        private TextBox raiz2;
        private Button button1;
        private TextBox txtResults1;
        private TextBox txtResults2;
    }
}
