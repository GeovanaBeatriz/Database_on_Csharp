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
    public partial class frmPesquisaCliente : Form
    {
        BdProjetoDataSet.ClienteDataTable DTClientes = new BdProjetoDataSet.ClienteDataTable ();
        BdProjetoDataSetTableAdapters.ClienteTableAdapter TAClientes = new BdProjetoDataSetTableAdapters.ClienteTableAdapter();

        frmClientes frmCli;

        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        public frmPesquisaCliente(frmClientes formularioClientes)
        {
            InitializeComponent();
            frmCli = formularioClientes;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha;
                linha = dgvClientes.CurrentRow;
                frmCli.txtNome.Text = linha.Cells["Nome"].Value.ToString();
                frmCli.txtEndereco.Text = linha.Cells["Endereço"].Value.ToString();
                frmCli.mskCPF.Text = linha.Cells["CPF"].Value.ToString();
                frmCli.mskTelefone.Text = linha.Cells["Telefone"].Value.ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Selecione um cliente!" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(rdbCPF.Checked == true)
                {
                    TAClientes.FillBy1(DTClientes, txtPesquisa.Text);
                    dgvClientes.DataSource = DTClientes;
                }

                else
                {
                    TAClientes.FillBy(DTClientes, txtPesquisa.Text);
                    dgvClientes.DataSource = DTClientes;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao localizar cliente\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
