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

       
    }
}
