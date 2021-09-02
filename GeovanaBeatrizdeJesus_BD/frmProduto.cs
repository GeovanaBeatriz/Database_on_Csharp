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
        BdProjetoDataSetTableAdapters.ProdutoTableAdapter TAProdutos = new BdProjetoDataSetTableAdapters.ProdutoTableAdapter();
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

        private void btnIncluirPro_Click(object sender, EventArgs e)
        {
            try
            {
                TAProdutos.inserir_alterarProdutos(int.Parse(txtCod.Text), txtNome.Text, txtDesc.Text, float.Parse(txtPreco.Text), 1);
                MessageBox.Show("Produto Cadastrado", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarPro_Click(object sender, EventArgs e)
        {
            try
            {
                TAProdutos.inserir_alterarProdutos(int.Parse(txtCod.Text), txtNome.Text, txtDesc.Text, float.Parse(txtPreco.Text), 2);
                MessageBox.Show("Dados Alterados", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados do produto\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirPro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este produto?", "Excluir Produto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TAProdutos.Excluir_Produto(int.Parse(txtCod.Text));
                    txtCod.Text = "";
                    txtPreco.Text = "";
                    txtDesc.Text = "";
                    txtNome.Text = "";

                    MessageBox.Show("Produto Excluído", "Confirmação de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFecharPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
