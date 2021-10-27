namespace GeovanaBeatrizdeJesus_BD
{
    partial class RelatórioCliente
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
            this.BdProjetoDataSet = new GeovanaBeatrizdeJesus_BD.BdProjetoDataSet();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteTableAdapter = new GeovanaBeatrizdeJesus_BD.BdProjetoDataSetTableAdapters.ClienteTableAdapter();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BdProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // BdProjetoDataSet
            // 
            this.BdProjetoDataSet.DataSetName = "BdProjetoDataSet";
            this.BdProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.BdProjetoDataSet;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.BdProjetoDataSet;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.BdProjetoDataSet;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelCliente";
            reportDataSource1.Value = this.clienteBindingSource3;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "GeovanaBeatrizdeJesus_BD.ReportCli.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 450);
            this.reportViewer2.TabIndex = 0;
            // 
            // clienteBindingSource3
            // 
            this.clienteBindingSource3.DataMember = "Cliente";
            this.clienteBindingSource3.DataSource = this.BdProjetoDataSet;
            // 
            // RelatórioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Name = "RelatórioCliente";
            this.Text = "RelatórioCliente";
            this.Load += new System.EventHandler(this.RelatórioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private BdProjetoDataSet BdProjetoDataSet;
        private BdProjetoDataSetTableAdapters.ClienteTableAdapter ClienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
    }
}