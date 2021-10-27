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
    public partial class RelatórioVendas : Form
    {
        public RelatórioVendas()
        {
            InitializeComponent();
        }

        private void RelatórioVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdProjetoDataSet.Itens_Pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.Itens_PedidoTableAdapter.Fill(this.BdProjetoDataSet.Itens_Pedido);

            this.reportViewer1.RefreshReport();
        }
    }
}
