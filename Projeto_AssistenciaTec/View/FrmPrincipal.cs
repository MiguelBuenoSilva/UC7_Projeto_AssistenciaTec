using Projeto_AssistenciaTec.Data;
using Projeto_AssistenciaTec.View;

namespace Projeto_AssistenciaTec
{
    public partial class FrmPrincipal : Form
    {

        private FrmClientes frmClientes = null;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemConectar_Click(object sender, EventArgs e)
        {
            Conexao.GetConexao();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmClientes == null || frmClientes.IsDisposed)
            {
                frmClientes = new FrmClientes();
                frmClientes.MdiParent = this;
                frmClientes.Show();
            }
            else
            {
                if (frmClientes.WindowState == FormWindowState.Minimized)
                {
                    frmClientes.WindowState = FormWindowState.Normal;
                }
            }
               
        }
    }
}
