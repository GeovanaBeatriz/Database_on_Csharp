namespace GeovanaBeatrizdeJesus_BD
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.clmCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Produto:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(43, 64);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(93, 20);
            this.txtCodCli.TabIndex = 2;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(43, 132);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(93, 20);
            this.txtCodProduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(172, 64);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(313, 21);
            this.cmbCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome do Produto:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(172, 132);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(313, 20);
            this.txtProdName.TabIndex = 7;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(513, 132);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(66, 20);
            this.txtQtde.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(599, 132);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(63, 20);
            this.txtValor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(668, 129);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Código da venda:";
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Location = new System.Drawing.Point(668, 21);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.ReadOnly = true;
            this.txtCodVenda.Size = new System.Drawing.Size(72, 20);
            this.txtCodVenda.TabIndex = 14;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodProd,
            this.clmProduto,
            this.clmQtde,
            this.clmValorUnit,
            this.clmValorTotal});
            this.dgvVendas.Location = new System.Drawing.Point(43, 172);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(700, 189);
            this.dgvVendas.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total da venda:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(598, 379);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(142, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(599, 405);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(141, 23);
            this.btnFinalizar.TabIndex = 18;
            this.btnFinalizar.Text = "Finalizar a venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // clmCodProd
            // 
            this.clmCodProd.HeaderText = "Código do produto";
            this.clmCodProd.Name = "clmCodProd";
            this.clmCodProd.Width = 109;
            // 
            // clmProduto
            // 
            this.clmProduto.HeaderText = "Produto";
            this.clmProduto.Name = "clmProduto";
            this.clmProduto.Width = 69;
            // 
            // clmQtde
            // 
            this.clmQtde.HeaderText = "Quantidade";
            this.clmQtde.Name = "clmQtde";
            this.clmQtde.Width = 87;
            // 
            // clmValorUnit
            // 
            this.clmValorUnit.HeaderText = "Valor Unitário";
            this.clmValorUnit.Name = "clmValorUnit";
            this.clmValorUnit.Width = 87;
            // 
            // clmValorTotal
            // 
            this.clmValorTotal.HeaderText = "Valor Total";
            this.clmValorTotal.Name = "clmValorTotal";
            this.clmValorTotal.Width = 77;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 435);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.txtCodVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValorTotal;
    }
}