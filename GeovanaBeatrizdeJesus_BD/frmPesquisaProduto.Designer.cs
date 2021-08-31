namespace GeovanaBeatrizdeJesus_BD
{
    partial class frmPesquisaProduto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNomePro = new System.Windows.Forms.RadioButton();
            this.rdbCod = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisaPro = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnOKPro = new System.Windows.Forms.Button();
            this.btnCancelarPro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNomePro);
            this.groupBox1.Controls.Add(this.rdbCod);
            this.groupBox1.Location = new System.Drawing.Point(30, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critério de Busca";
            // 
            // rdbNomePro
            // 
            this.rdbNomePro.AutoSize = true;
            this.rdbNomePro.Location = new System.Drawing.Point(115, 40);
            this.rdbNomePro.Name = "rdbNomePro";
            this.rdbNomePro.Size = new System.Drawing.Size(53, 17);
            this.rdbNomePro.TabIndex = 1;
            this.rdbNomePro.TabStop = true;
            this.rdbNomePro.Text = "Nome";
            this.rdbNomePro.UseVisualStyleBackColor = true;
            // 
            // rdbCod
            // 
            this.rdbCod.AutoSize = true;
            this.rdbCod.Location = new System.Drawing.Point(21, 40);
            this.rdbCod.Name = "rdbCod";
            this.rdbCod.Size = new System.Drawing.Size(58, 17);
            this.rdbCod.TabIndex = 0;
            this.rdbCod.TabStop = true;
            this.rdbCod.Text = "Código";
            this.rdbCod.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisaPro);
            this.groupBox2.Location = new System.Drawing.Point(268, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe o Nome ou o Código do Produto";
            // 
            // txtPesquisaPro
            // 
            this.txtPesquisaPro.Location = new System.Drawing.Point(20, 37);
            this.txtPesquisaPro.Name = "txtPesquisaPro";
            this.txtPesquisaPro.Size = new System.Drawing.Size(291, 20);
            this.txtPesquisaPro.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(30, 174);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(586, 150);
            this.dgvProdutos.TabIndex = 2;
            // 
            // btnOKPro
            // 
            this.btnOKPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKPro.Location = new System.Drawing.Point(422, 349);
            this.btnOKPro.Name = "btnOKPro";
            this.btnOKPro.Size = new System.Drawing.Size(75, 23);
            this.btnOKPro.TabIndex = 3;
            this.btnOKPro.Text = "OK";
            this.btnOKPro.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPro
            // 
            this.btnCancelarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPro.Location = new System.Drawing.Point(541, 349);
            this.btnCancelarPro.Name = "btnCancelarPro";
            this.btnCancelarPro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPro.TabIndex = 4;
            this.btnCancelarPro.Text = "Cancelar";
            this.btnCancelarPro.UseVisualStyleBackColor = true;
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 401);
            this.Controls.Add(this.btnCancelarPro);
            this.Controls.Add(this.btnOKPro);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPesquisaProduto";
            this.Text = "Pesquisa de Produtos";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNomePro;
        private System.Windows.Forms.RadioButton rdbCod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesquisaPro;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnOKPro;
        private System.Windows.Forms.Button btnCancelarPro;
    }
}