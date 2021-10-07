﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GeovanaBeatrizdeJesus_BD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            frmSplashScreen frmSplashScreen = new frmSplashScreen();
            //Exibindo o SplashScreen
            frmSplashScreen.Show();
            //Tempo que irá aparecer em milisegundos
            Thread.Sleep(7500);
            //Fechando o SplashScreen
            frmSplashScreen.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes(); //Criando instância do formulário Clientes
            frmCli.MdiParent = this; //Esta linha define que o formulário cliente é 'filho' do formulário
            //principal e portanto, deverá abrir dentro dele
            frmCli.Show(); //exibe o formulário cliente
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto(); //Criando instância do formulário Clientes
            frmProd.MdiParent = this; //Esta linha define que o formulário cliente é 'filho' do formulário
            //principal e portanto, deverá abrir dentro dele
            frmProd.Show(); //exibe o formulário cliente
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas(); //Criando instância do formulário Clientes
            frmVendas.MdiParent = this; //Esta linha define que o formulário cliente é 'filho' do formulário
            //principal e portanto, deverá abrir dentro dele
            frmVendas.Show(); //exibe o formulário cliente
        }
    }
}
