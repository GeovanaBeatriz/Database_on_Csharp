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
    public partial class frmPesquisaProduto : Form
    {
        BdProjetoDataSet.ProdutoDataTable DTProdutos = new BdProjetoDataSet.ProdutoDataTable();
        BdProjetoDataSetTableAdapters.ProdutoTableAdapter TAProdutos = new BdProjetoDataSetTableAdapters.ProdutoTableAdapter();

        frmProduto frmProd;
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        public frmPesquisaProduto(frmProduto formularioProduto)
        {
            InitializeComponent();
            frmProd = formularioProduto;
        }

        private void txtPesquisaPro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbNomePro.Checked == true)
                {
                    TAProdutos.Busca2(DTProdutos, txtPesquisaPro.Text);
                    dgvProdutos.DataSource = DTProdutos;
                }

                else
                {
                    TAProdutos.Busca3(DTProdutos,int.Parse(txtPesquisaPro.Text));
                    dgvProdutos.DataSource = DTProdutos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao localizar produto\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOKPro_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow linha;
                linha = dgvProdutos.CurrentRow;
                frmProd.txtNome.Text = linha.Cells["Nome"].Value.ToString();
                frmProd.txtDesc.Text = linha.Cells["Descrição"].Value.ToString();
                frmProd.txtCod.Text = linha.Cells["Código"].Value.ToString();
                frmProd.txtPreco.Text = linha.Cells["Preço"].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Selecione um produto!" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
