using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GeovanaBeatrizdeJesus_BD

{
    public partial class frmClientes : Form
    {

        BdProjetoDataSetTableAdapters.ClienteTableAdapter TAClientes = new BdProjetoDataSetTableAdapters.ClienteTableAdapter();

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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                TAClientes.inserir_alterar_Cliente(mskCPF.Text, txtNome.Text, txtEndereco.Text, mskTelefone.Text, 1);
                MessageBox.Show("Cliente Cadastrado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir cliente\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                TAClientes.inserir_alterar_Cliente(mskCPF.Text, txtNome.Text, txtEndereco.Text, mskTelefone.Text, 2);
                MessageBox.Show("Dados Alterados", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados do cliente\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir este cliente?", "Excluir Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TAClientes.Excluir_Cliente(mskCPF.Text);
                    mskCPF.Text = "";
                    mskTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtNome.Text = "";

                    MessageBox.Show("Cliente Excluído", "Confirmação de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
