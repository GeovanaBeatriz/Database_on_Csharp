namespace GeovanaBeatrizdeJesus_BD
{
    partial class frmProduto
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnIncluirPro = new System.Windows.Forms.Button();
            this.btnAlterarPro = new System.Windows.Forms.Button();
            this.btnExcluirPro = new System.Windows.Forms.Button();
            this.btnFecharPro = new System.Windows.Forms.Button();
            this.btnLocalizarPro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(120, 49);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(119, 20);
            this.txtCod.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(430, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(120, 110);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(430, 20);
            this.txtDesc.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(120, 139);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(430, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // btnIncluirPro
            // 
            this.btnIncluirPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPro.Location = new System.Drawing.Point(49, 201);
            this.btnIncluirPro.Name = "btnIncluirPro";
            this.btnIncluirPro.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirPro.TabIndex = 8;
            this.btnIncluirPro.Text = "Incluir";
            this.btnIncluirPro.UseVisualStyleBackColor = true;
            this.btnIncluirPro.Click += new System.EventHandler(this.btnIncluirPro_Click);
            // 
            // btnAlterarPro
            // 
            this.btnAlterarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPro.Location = new System.Drawing.Point(164, 201);
            this.btnAlterarPro.Name = "btnAlterarPro";
            this.btnAlterarPro.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPro.TabIndex = 9;
            this.btnAlterarPro.Text = "Alterar";
            this.btnAlterarPro.UseVisualStyleBackColor = true;
            this.btnAlterarPro.Click += new System.EventHandler(this.btnAlterarPro_Click);
            // 
            // btnExcluirPro
            // 
            this.btnExcluirPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPro.Location = new System.Drawing.Point(276, 201);
            this.btnExcluirPro.Name = "btnExcluirPro";
            this.btnExcluirPro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPro.TabIndex = 10;
            this.btnExcluirPro.Text = "Excluir";
            this.btnExcluirPro.UseVisualStyleBackColor = true;
            this.btnExcluirPro.Click += new System.EventHandler(this.btnExcluirPro_Click);
            // 
            // btnFecharPro
            // 
            this.btnFecharPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharPro.Location = new System.Drawing.Point(475, 201);
            this.btnFecharPro.Name = "btnFecharPro";
            this.btnFecharPro.Size = new System.Drawing.Size(75, 23);
            this.btnFecharPro.TabIndex = 11;
            this.btnFecharPro.Text = "Fechar";
            this.btnFecharPro.UseVisualStyleBackColor = true;
            this.btnFecharPro.Click += new System.EventHandler(this.btnFecharPro_Click);
            // 
            // btnLocalizarPro
            // 
            this.btnLocalizarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarPro.Location = new System.Drawing.Point(254, 47);
            this.btnLocalizarPro.Name = "btnLocalizarPro";
            this.btnLocalizarPro.Size = new System.Drawing.Size(32, 23);
            this.btnLocalizarPro.TabIndex = 12;
            this.btnLocalizarPro.Text = "...";
            this.btnLocalizarPro.UseVisualStyleBackColor = true;
            this.btnLocalizarPro.Click += new System.EventHandler(this.btnLocalizarPro_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 263);
            this.Controls.Add(this.btnLocalizarPro);
            this.Controls.Add(this.btnFecharPro);
            this.Controls.Add(this.btnExcluirPro);
            this.Controls.Add(this.btnAlterarPro);
            this.Controls.Add(this.btnIncluirPro);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProduto";
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnIncluirPro;
        private System.Windows.Forms.Button btnAlterarPro;
        private System.Windows.Forms.Button btnExcluirPro;
        private System.Windows.Forms.Button btnFecharPro;
        private System.Windows.Forms.Button btnLocalizarPro;
    }
}