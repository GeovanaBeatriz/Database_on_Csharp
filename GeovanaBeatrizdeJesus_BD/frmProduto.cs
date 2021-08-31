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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnLocalizarPro_Click(object sender, EventArgs e)
        {

            frmPesquisaProduto frmPesqProd = new frmPesquisaProduto(this);// Cria uma instância do formulário 
            //Pesquisa produto
            frmPesqProd.ShowDialog(this); //Exibe o formulário Pesquisa Produto em forma modal, ou seja, 
            //os formulários que ficarem por trás deste somente serão acessíveis quando o formulário
            //pesquisa for fechado.
        }
    }
}
