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
    public partial class RelatórioCliente : Form
    {
        public RelatórioCliente()
        {
            InitializeComponent();
        }

        private void RelatórioCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdProjetoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteTableAdapter.Fill(this.BdProjetoDataSet.Cliente);

            this.reportViewer2.RefreshReport();
        }
    }
}
