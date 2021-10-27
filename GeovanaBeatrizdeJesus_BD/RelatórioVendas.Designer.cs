namespace GeovanaBeatrizdeJesus_BD
{
    partial class RelatórioVendas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BdProjetoDataSet = new GeovanaBeatrizdeJesus_BD.BdProjetoDataSet();
            this.Itens_PedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Itens_PedidoTableAdapter = new GeovanaBeatrizdeJesus_BD.BdProjetoDataSetTableAdapters.Itens_PedidoTableAdapter();
            this.itensPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BdProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Itens_PedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.itensPedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GeovanaBeatrizdeJesus_BD.ReportVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BdProjetoDataSet
            // 
            this.BdProjetoDataSet.DataSetName = "BdProjetoDataSet";
            this.BdProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Itens_PedidoBindingSource
            // 
            this.Itens_PedidoBindingSource.DataMember = "Itens_Pedido";
            this.Itens_PedidoBindingSource.DataSource = this.BdProjetoDataSet;
            // 
            // Itens_PedidoTableAdapter
            // 
            this.Itens_PedidoTableAdapter.ClearBeforeFill = true;
            // 
            // itensPedidoBindingSource
            // 
            this.itensPedidoBindingSource.DataMember = "Itens_Pedido";
            this.itensPedidoBindingSource.DataSource = this.BdProjetoDataSet;
            // 
            // RelatórioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatórioVendas";
            this.Text = "RelatórioVendas";
            this.Load += new System.EventHandler(this.RelatórioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Itens_PedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Itens_PedidoBindingSource;
        private BdProjetoDataSet BdProjetoDataSet;
        private BdProjetoDataSetTableAdapters.Itens_PedidoTableAdapter Itens_PedidoTableAdapter;
        private System.Windows.Forms.BindingSource itensPedidoBindingSource;
    }
}