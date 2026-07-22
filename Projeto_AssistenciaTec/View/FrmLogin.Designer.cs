namespace Projeto_AssistenciaTec.View
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            LblLogin = new Label();
            LblTexto = new Label();
            LblUsuario = new Label();
            LblSenhaUsuario = new Label();
            TxtLogin = new TextBox();
            TxtSenha = new TextBox();
            BtnLogin = new Button();
            BtnSair = new Button();
            SuspendLayout();
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.BackColor = Color.Transparent;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLogin.ForeColor = Color.White;
            LblLogin.Location = new Point(35, 53);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(155, 65);
            LblLogin.TabIndex = 0;
            LblLogin.Text = "Login";
            // 
            // LblTexto
            // 
            LblTexto.AutoSize = true;
            LblTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTexto.ForeColor = Color.White;
            LblTexto.Location = new Point(47, 118);
            LblTexto.Name = "LblTexto";
            LblTexto.Size = new Size(238, 15);
            LblTexto.TabIndex = 1;
            LblTexto.Text = "Forneça seus dados para acessar o sistema";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.White;
            LblUsuario.Location = new Point(35, 191);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(100, 15);
            LblUsuario.TabIndex = 2;
            LblUsuario.Text = "Login de usuário:";
            // 
            // LblSenhaUsuario
            // 
            LblSenhaUsuario.AutoSize = true;
            LblSenhaUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSenhaUsuario.ForeColor = Color.White;
            LblSenhaUsuario.Location = new Point(35, 256);
            LblSenhaUsuario.Name = "LblSenhaUsuario";
            LblSenhaUsuario.Size = new Size(104, 15);
            LblSenhaUsuario.TabIndex = 3;
            LblSenhaUsuario.Text = "Senha do usuário:";
            // 
            // TxtLogin
            // 
            TxtLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtLogin.Location = new Point(35, 209);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.PlaceholderText = "Digite o seu e-mail aqui";
            TxtLogin.Size = new Size(275, 33);
            TxtLogin.TabIndex = 4;
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSenha.Location = new Point(35, 274);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PlaceholderText = "Digite sua senha aqui";
            TxtSenha.Size = new Size(275, 33);
            TxtSenha.TabIndex = 5;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Image = (Image)resources.GetObject("BtnLogin.Image");
            BtnLogin.Location = new Point(270, 382);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(71, 57);
            BtnLogin.TabIndex = 6;
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnSair
            // 
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.Location = new Point(171, 382);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(73, 57);
            BtnSair.TabIndex = 7;
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(378, 479);
            Controls.Add(BtnSair);
            Controls.Add(BtnLogin);
            Controls.Add(TxtSenha);
            Controls.Add(TxtLogin);
            Controls.Add(LblSenhaUsuario);
            Controls.Add(LblUsuario);
            Controls.Add(LblTexto);
            Controls.Add(LblLogin);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblLogin;
        private Label LblTexto;
        private Label LblUsuario;
        private Label LblSenhaUsuario;
        private TextBox TxtLogin;
        private TextBox TxtSenha;
        private Button BtnLogin;
        private Button BtnSair;
    }
}