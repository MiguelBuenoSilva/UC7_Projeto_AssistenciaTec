namespace Projeto_AssistenciaTec.View
{
    partial class FrmTecnicos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTecnicos));
            panel2 = new Panel();
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
            groupBox1 = new GroupBox();
            DatagridViewTecnicos = new DataGridView();
            BtnBuscar = new Button();
            TxtBuscarPorNome = new TextBox();
            LblBuscarTecnicoPorNome = new Label();
            GroupBoxDadosCliente = new GroupBox();
            TxtEspecialidadeTecnico = new TextBox();
            LblEspecialidade = new Label();
            TxtTelefoneTecnico = new TextBox();
            LblTelefoneTecnico = new Label();
            TxtEmailTecnico = new TextBox();
            LblEmailTecnico = new Label();
            TxtNomeTecnico = new TextBox();
            LblNomeTecnico = new Label();
            LabelId = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewTecnicos).BeginInit();
            GroupBoxDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(toolStrip1);
            panel2.Location = new Point(-3, 619);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 43);
            panel2.TabIndex = 9;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNovo, toolStripButtonEditar, toolStripButtonDeletar, toolStripSeparator1, toolStripButtonCancelar, toolStripButtonSalvar });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 10);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(189, 31);
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
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = (Image)resources.GetObject("toolStripButtonEditar.Image");
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(28, 28);
            toolStripButtonEditar.Text = "Editar";
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
            // 
            // toolStripButtonSalvar
            // 
            toolStripButtonSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSalvar.Image = (Image)resources.GetObject("toolStripButtonSalvar.Image");
            toolStripButtonSalvar.ImageTransparentColor = Color.Magenta;
            toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            toolStripButtonSalvar.Size = new Size(28, 28);
            toolStripButtonSalvar.Text = "Salvar";
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 89);
            panel1.TabIndex = 8;
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
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(129, 22);
            label6.Name = "label6";
            label6.Size = new Size(410, 44);
            label6.TabIndex = 0;
            label6.Text = "Cadastro de Técnicos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DatagridViewTecnicos);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(TxtBuscarPorNome);
            groupBox1.Controls.Add(LblBuscarTecnicoPorNome);
            groupBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(336, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 488);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de técnicos cadastrados:";
            // 
            // DatagridViewTecnicos
            // 
            DatagridViewTecnicos.AllowUserToResizeColumns = false;
            DatagridViewTecnicos.AllowUserToResizeRows = false;
            DatagridViewTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatagridViewTecnicos.Location = new Point(3, 98);
            DatagridViewTecnicos.Name = "DatagridViewTecnicos";
            DatagridViewTecnicos.ReadOnly = true;
            DatagridViewTecnicos.Size = new Size(671, 382);
            DatagridViewTecnicos.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Image = (Image)resources.GetObject("BtnBuscar.Image");
            BtnBuscar.Location = new Point(565, 45);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(47, 42);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarPorNome
            // 
            TxtBuscarPorNome.Location = new Point(6, 55);
            TxtBuscarPorNome.Name = "TxtBuscarPorNome";
            TxtBuscarPorNome.Size = new Size(553, 26);
            TxtBuscarPorNome.TabIndex = 3;
            // 
            // LblBuscarTecnicoPorNome
            // 
            LblBuscarTecnicoPorNome.AutoSize = true;
            LblBuscarTecnicoPorNome.Location = new Point(6, 32);
            LblBuscarTecnicoPorNome.Name = "LblBuscarTecnicoPorNome";
            LblBuscarTecnicoPorNome.Size = new Size(202, 20);
            LblBuscarTecnicoPorNome.TabIndex = 2;
            LblBuscarTecnicoPorNome.Text = "Buscar técnico por nome :";
            // 
            // GroupBoxDadosCliente
            // 
            GroupBoxDadosCliente.Controls.Add(TxtEspecialidadeTecnico);
            GroupBoxDadosCliente.Controls.Add(LblEspecialidade);
            GroupBoxDadosCliente.Controls.Add(TxtTelefoneTecnico);
            GroupBoxDadosCliente.Controls.Add(LblTelefoneTecnico);
            GroupBoxDadosCliente.Controls.Add(TxtEmailTecnico);
            GroupBoxDadosCliente.Controls.Add(LblEmailTecnico);
            GroupBoxDadosCliente.Controls.Add(TxtNomeTecnico);
            GroupBoxDadosCliente.Controls.Add(LblNomeTecnico);
            GroupBoxDadosCliente.Controls.Add(LabelId);
            GroupBoxDadosCliente.Controls.Add(label1);
            GroupBoxDadosCliente.Enabled = false;
            GroupBoxDadosCliente.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxDadosCliente.Location = new Point(11, 105);
            GroupBoxDadosCliente.Name = "GroupBoxDadosCliente";
            GroupBoxDadosCliente.Size = new Size(319, 488);
            GroupBoxDadosCliente.TabIndex = 6;
            GroupBoxDadosCliente.TabStop = false;
            GroupBoxDadosCliente.Text = "Dados do técnico:";
            // 
            // TxtEspecialidadeTecnico
            // 
            TxtEspecialidadeTecnico.Location = new Point(6, 317);
            TxtEspecialidadeTecnico.Multiline = true;
            TxtEspecialidadeTecnico.Name = "TxtEspecialidadeTecnico";
            TxtEspecialidadeTecnico.Size = new Size(298, 163);
            TxtEspecialidadeTecnico.TabIndex = 9;
            // 
            // LblEspecialidade
            // 
            LblEspecialidade.AutoSize = true;
            LblEspecialidade.Location = new Point(0, 294);
            LblEspecialidade.Name = "LblEspecialidade";
            LblEspecialidade.Size = new Size(201, 20);
            LblEspecialidade.TabIndex = 8;
            LblEspecialidade.Text = "Especialidade do técnico:";
            // 
            // TxtTelefoneTecnico
            // 
            TxtTelefoneTecnico.Location = new Point(6, 255);
            TxtTelefoneTecnico.Name = "TxtTelefoneTecnico";
            TxtTelefoneTecnico.Size = new Size(157, 26);
            TxtTelefoneTecnico.TabIndex = 7;
            // 
            // LblTelefoneTecnico
            // 
            LblTelefoneTecnico.AutoSize = true;
            LblTelefoneTecnico.Location = new Point(6, 232);
            LblTelefoneTecnico.Name = "LblTelefoneTecnico";
            LblTelefoneTecnico.Size = new Size(160, 20);
            LblTelefoneTecnico.TabIndex = 6;
            LblTelefoneTecnico.Text = "Telefone do técnico:";
            // 
            // TxtEmailTecnico
            // 
            TxtEmailTecnico.Location = new Point(9, 191);
            TxtEmailTecnico.Name = "TxtEmailTecnico";
            TxtEmailTecnico.Size = new Size(276, 26);
            TxtEmailTecnico.TabIndex = 5;
            // 
            // LblEmailTecnico
            // 
            LblEmailTecnico.AutoSize = true;
            LblEmailTecnico.Location = new Point(6, 168);
            LblEmailTecnico.Name = "LblEmailTecnico";
            LblEmailTecnico.Size = new Size(140, 20);
            LblEmailTecnico.TabIndex = 4;
            LblEmailTecnico.Text = "E-mail do técnico:";
            // 
            // TxtNomeTecnico
            // 
            TxtNomeTecnico.Location = new Point(9, 118);
            TxtNomeTecnico.Name = "TxtNomeTecnico";
            TxtNomeTecnico.Size = new Size(276, 26);
            TxtNomeTecnico.TabIndex = 3;
            // 
            // LblNomeTecnico
            // 
            LblNomeTecnico.AutoSize = true;
            LblNomeTecnico.Location = new Point(6, 91);
            LblNomeTecnico.Name = "LblNomeTecnico";
            LblNomeTecnico.Size = new Size(138, 20);
            LblNomeTecnico.TabIndex = 2;
            LblNomeTecnico.Text = "Nome do técnico";
            // 
            // LabelId
            // 
            LabelId.BackColor = Color.SpringGreen;
            LabelId.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelId.Location = new Point(145, 45);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(59, 26);
            LabelId.TabIndex = 1;
            LabelId.Text = "49";
            LabelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "ID do técnico:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmTecnicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 662);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxDadosCliente);
            MaximizeBox = false;
            Name = "FrmTecnicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tecnicos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewTecnicos).EndInit();
            GroupBoxDadosCliente.ResumeLayout(false);
            GroupBoxDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNovo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonDeletar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonCancelar;
        private ToolStripButton toolStripButtonSalvar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private GroupBox groupBox1;
        private DataGridView DatagridViewTecnicos;
        private Button BtnBuscar;
        private TextBox TxtBuscarPorNome;
        private Label LblBuscarTecnicoPorNome;
        private GroupBox GroupBoxDadosCliente;
        private TextBox TxtEspecialidadeTecnico;
        private Label LblEspecialidade;
        private TextBox TxtTelefoneTecnico;
        private Label LblTelefoneTecnico;
        private TextBox TxtEmailTecnico;
        private Label LblEmailTecnico;
        private TextBox TxtNomeTecnico;
        private Label LblNomeTecnico;
        private Label LabelId;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}