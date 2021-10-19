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
    public partial class frmVendas : Form
    {
        BdProjetoDataSetTableAdapters.ClienteTableAdapter TAClientes = new BdProjetoDataSetTableAdapters.ClienteTableAdapter();
        BdProjetoDataSet.ClienteDataTable DTClientes = new BdProjetoDataSet.ClienteDataTable();

        BdProjetoDataSetTableAdapters.ProdutoTableAdapter TAProduto = new BdProjetoDataSetTableAdapters.ProdutoTableAdapter();
        BdProjetoDataSet.ProdutoDataTable DTProduto = new BdProjetoDataSet.ProdutoDataTable();

        BdProjetoDataSetTableAdapters.PedidoTableAdapter TAPedido = new BdProjetoDataSetTableAdapters.PedidoTableAdapter();
        BdProjetoDataSet.PedidoDataTable DTPedido = new BdProjetoDataSet.PedidoDataTable();

        BdProjetoDataSetTableAdapters.Itens_PedidoTableAdapter TAItens = new BdProjetoDataSetTableAdapters.Itens_PedidoTableAdapter();
        BdProjetoDataSet.Itens_PedidoDataTable DTItens = new BdProjetoDataSet.Itens_PedidoDataTable();

        double valorTotal;
        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            valorTotal = 0;
            TAClientes.Fill(DTClientes);
            cmbCliente.DataSource = DTClientes;
            cmbCliente.DisplayMember = "Nome";

            TAProduto.Fill(DTProduto);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView ClienteSelecionado;
            ClienteSelecionado = (DataRowView)cmbCliente.SelectedItem;
            txtCodCli.Text = ClienteSelecionado.Row["CPF"].ToString();
        }

        private void txtCodCli_TextChanged(object sender, EventArgs e)
        {
            DataRow[] ClienteSelecionado;
            ClienteSelecionado = DTClientes.Select("CPF='" + txtCodCli.Text + "'");

            if(ClienteSelecionado.Length > 0)
            {
                cmbCliente.Text = ClienteSelecionado[0]["Nome"].ToString();
            }
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

            if(txtCodProduto.Text != "")
            {
                DataRow[] Produto;
                Produto = DTProduto.Select("Codigo=" + Convert.ToInt16(txtCodProduto.Text));

                if(Produto.Length > 0)
                {
                    txtProdName.Text = Produto[0]["Nome"].ToString();
                    txtValor.Text = Produto[0]["Preco"].ToString();

                }

                else
                {
                    txtProdName.Text = "";
                    txtValor.Text = "";
                    txtQtde.Text = "";
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double ValorProduto = Convert.ToDouble(txtValor.Text);
            double qtde = Convert.ToDouble(txtQtde.Text);
            double total = ValorProduto * qtde;


            string[] Produto = { txtCodProduto.Text, txtProdName.Text, qtde.ToString(), ValorProduto.ToString(), total.ToString() };

            dgvVendas.Rows.Add(Produto);

            valorTotal += total;
            txtTotal.Text = valorTotal.ToString();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt16(TAPedido.InsereVenda(txtCodCli.Text, DateTime.Now));
                txtCodVenda.Text = codigo.ToString();

                try
                {
                    for(int cont = 0; cont <= dgvVendas.Rows.Count -2; cont++)
                    {
                        BdProjetoDataSet.Itens_PedidoRow linha;

                        linha = (BdProjetoDataSet.Itens_PedidoRow)DTItens.NewRow();
                        linha.BeginEdit();

                        linha.CodPedido = Convert.ToInt16(txtCodVenda.Text);
                        linha.CodProduto = Convert.ToInt16(dgvVendas.Rows
                            [cont].Cells["clmCodProd"].Value);
                        linha.Quantidade = Convert.ToDouble(dgvVendas.Rows[cont].Cells["clmQtde"].Value);
                        linha.Preco = Convert.ToDouble(dgvVendas.Rows[cont].Cells["clmValorUnit"].Value);
                        linha.EndEdit();

                        DTItens.Rows.Add(linha);

                    }

                    TAItens.Update(DTItens);
                    MessageBox.Show("Venda realizada com sucesso", "Venda realizada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar item do pedido\n" + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TAPedido.ExcluirVenda(Convert.ToInt16(txtCodVenda.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar pedido\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
