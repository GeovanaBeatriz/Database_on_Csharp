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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

   

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente frmPesqCli = new frmPesquisaCliente(this);// Cria uma instância do formulário 
            //Pesquisa cliente
            frmPesqCli.ShowDialog(this); //Exibe o formulário Pesquisa Cliente em forma modal, ou seja, 
            //os formulários que ficarem por trás deste somente serão acessíveis quando o formulário
            //pesquisa for fechado.
        }
    }
}
