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


        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            TAClientes.Fill(DTClientes);
            cmbCliente.DataSource = DTClientes;
            cmbCliente.DisplayMember = "Nome";
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
    }
}
