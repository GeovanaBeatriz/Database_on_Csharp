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
    public partial class RelatórioProduto : Form
    {
        public RelatórioProduto()
        {
            InitializeComponent();
        }

        private void RelatórioProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdProjetoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.ProdutoTableAdapter.Fill(this.BdProjetoDataSet.Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
