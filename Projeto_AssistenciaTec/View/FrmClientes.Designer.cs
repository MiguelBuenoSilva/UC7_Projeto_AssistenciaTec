namespace Projeto_AssistenciaTec.View
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            GroupBoxDadosCliente = new GroupBox();
            TxtEndereco = new TextBox();
            label5 = new Label();
            TxtTelefone = new TextBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            label2 = new Label();
            TxtNome = new TextBox();
            label3 = new Label();
            LabelId = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            DatagridViewClientes = new DataGridView();
            BtnBuscar = new Button();
            TxtBuscarNome = new TextBox();
            label9 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButtonNovo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonCancelar = new ToolStripButton();
            toolStripButtonSalvar = new ToolStripButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            GroupBoxDadosCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewClientes).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxDadosCliente
            // 
            GroupBoxDadosCliente.Controls.Add(TxtEndereco);
            GroupBoxDadosCliente.Controls.Add(label5);
            GroupBoxDadosCliente.Controls.Add(TxtTelefone);
            GroupBoxDadosCliente.Controls.Add(label4);
            GroupBoxDadosCliente.Controls.Add(TxtEmail);
            GroupBoxDadosCliente.Controls.Add(label2);
            GroupBoxDadosCliente.Controls.Add(TxtNome);
            GroupBoxDadosCliente.Controls.Add(label3);
            GroupBoxDadosCliente.Controls.Add(LabelId);
            GroupBoxDadosCliente.Controls.Add(label1);
            GroupBoxDadosCliente.Enabled = false;
            GroupBoxDadosCliente.Location = new Point(12, 105);
            GroupBoxDadosCliente.Name = "GroupBoxDadosCliente";
            GroupBoxDadosCliente.Size = new Size(319, 488);
            GroupBoxDadosCliente.TabIndex = 1;
            GroupBoxDadosCliente.TabStop = false;
            GroupBoxDadosCliente.Text = "Dados do cliente:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(6, 317);
            TxtEndereco.Multiline = true;
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(298, 163);
            TxtEndereco.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 294);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 8;
            label5.Text = "Endereço do cliente:";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(6, 255);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(157, 26);
            TxtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 232);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefone do cliente:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(9, 191);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(298, 26);
            TxtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 168);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 4;
            label2.Text = "E-mail do cliente:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(9, 118);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(298, 26);
            TxtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome do cliente:";
            // 
            // LabelId
            // 
            LabelId.BackColor = Color.SpringGreen;
            LabelId.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelId.Location = new Point(145, 45);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(59, 26);
            LabelId.TabIndex = 1;
            LabelId.Text = "496";
            LabelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "ID do cliente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DatagridViewClientes);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(TxtBuscarNome);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(337, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 488);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de clientes cadastrados:";
            // 
            // DatagridViewClientes
            // 
            DatagridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatagridViewClientes.Location = new Point(3, 98);
            DatagridViewClientes.Name = "DatagridViewClientes";
            DatagridViewClientes.Size = new Size(671, 382);
            DatagridViewClientes.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Image = (Image)resources.GetObject("BtnBuscar.Image");
            BtnBuscar.Location = new Point(578, 51);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(47, 42);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarNome
            // 
            TxtBuscarNome.Location = new Point(6, 67);
            TxtBuscarNome.Name = "TxtBuscarNome";
            TxtBuscarNome.Size = new Size(553, 26);
            TxtBuscarNome.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 44);
            label9.Name = "label9";
            label9.Size = new Size(195, 20);
            label9.TabIndex = 2;
            label9.Text = "Buscar cliente por nome :";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNovo, toolStripButtonEditar, toolStripButtonDeletar, toolStripSeparator1, toolStripButtonCancelar, toolStripButtonSalvar });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 10);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(158, 31);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            toolStripButtonNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNovo.Image = (Image)resources.GetObject("toolStripButtonNovo.Image");
            toolStripButtonNovo.ImageTransparentColor = Color.Magenta;
            toolStripButtonNovo.Name = "toolStripButtonNovo";
            toolStripButtonNovo.Size = new Size(28, 28);
            toolStripButtonNovo.Text = "Novo Cliente";
            toolStripButtonNovo.Click += toolStripButtonNovo_Click;
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = (Image)resources.GetObject("toolStripButtonEditar.Image");
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(28, 28);
            toolStripButtonEditar.Text = "Editar";
            toolStripButtonEditar.Click += toolStripButtonEditar_Click;
            // 
            // toolStripButtonDeletar
            // 
            toolStripButtonDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeletar.Image = (Image)resources.GetObject("toolStripButtonDeletar.Image");
            toolStripButtonDeletar.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeletar.Name = "toolStripButtonDeletar";
            toolStripButtonDeletar.Size = new Size(28, 28);
            toolStripButtonDeletar.Text = "Deletar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripButtonCancelar
            // 
            toolStripButtonCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCancelar.Image = (Image)resources.GetObject("toolStripButtonCancelar.Image");
            toolStripButtonCancelar.ImageTransparentColor = Color.Magenta;
            toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            toolStripButtonCancelar.Size = new Size(28, 28);
            toolStripButtonCancelar.Text = "Cancelar";
            toolStripButtonCancelar.Click += toolStripButtonCancelar_Click;
            // 
            // toolStripButtonSalvar
            // 
            toolStripButtonSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSalvar.Image = (Image)resources.GetObject("toolStripButtonSalvar.Image");
            toolStripButtonSalvar.ImageTransparentColor = Color.Magenta;
            toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            toolStripButtonSalvar.Size = new Size(28, 28);
            toolStripButtonSalvar.Text = "Salvar";
            toolStripButtonSalvar.Click += toolStripButtonSalvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 89);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(129, 22);
            label6.Name = "label6";
            label6.Size = new Size(395, 44);
            label6.TabIndex = 0;
            label6.Text = "Cadastro de Clientes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(toolStrip1);
            panel2.Location = new Point(-2, 619);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 43);
            panel2.TabIndex = 5;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 662);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxDadosCliente);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            GroupBoxDadosCliente.ResumeLayout(false);
            GroupBoxDadosCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewClientes).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxDadosCliente;
        private Label label3;
        private Label LabelId;
        private Label label1;
        private TextBox TxtEndereco;
        private Label label5;
        private TextBox TxtTelefone;
        private Label label4;
        private TextBox TxtEmail;
        private Label label2;
        private TextBox TxtNome;
        private GroupBox groupBox1;
        private TextBox TxtBuscarNome;
        private Label label9;
        private Button BtnBuscar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNovo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonDeletar;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonCancelar;
        private ToolStripButton toolStripButtonSalvar;
        private DataGridView DatagridViewClientes;
    }
}