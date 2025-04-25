namespace SenacFoods
{
    partial class FrmLogin
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
            panel1 = new Panel();
            panel2 = new Panel();
            textSenha = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnEntrar = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 740);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(textSenha);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(487, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 740);
            panel2.TabIndex = 1;
            // 
            // textSenha
            // 
            textSenha.BackColor = Color.Black;
            textSenha.BorderStyle = BorderStyle.None;
            textSenha.Font = new Font("Century Gothic", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSenha.ForeColor = Color.White;
            textSenha.Location = new Point(155, 276);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(426, 47);
            textSenha.TabIndex = 1;
            textSenha.Text = "SENHA";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Black;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Century Gothic", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(155, 203);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(426, 47);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(149, 301);
            label2.Name = "label2";
            label2.Size = new Size(432, 25);
            label2.TabIndex = 3;
            label2.Text = "____________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 228);
            label3.Name = "label3";
            label3.Size = new Size(432, 25);
            label3.TabIndex = 4;
            label3.Text = "____________________________________________________________";
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(149, 355);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(432, 70);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1318, 740);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLogin;
        private TextBox textSenha;
        private Label label3;
        private Label label2;
        private Button btnEntrar;
    }
}
