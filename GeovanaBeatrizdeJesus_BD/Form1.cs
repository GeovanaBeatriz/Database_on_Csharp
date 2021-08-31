using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeovanaBeatrizdeJesus_BD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes(); //Criando instância do formulário Clientes
            frmCli.MdiParent = this; //Esta linha define que o formulário cliente é 'filho' do formulário
            //principal e portanto, deverá abrir dentro dele
            frmCli.Show(); //exibe o formulário cliente
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto(); //Criando instância do formulário Clientes
            frmProd.MdiParent = this; //Esta linha define que o formulário cliente é 'filho' do formulário
            //principal e portanto, deverá abrir dentro dele
            frmProd.Show(); //exibe o formulário cliente
        }
    }
}
