namespace dll_reporteador.Presentacion
{
    partial class wfReportePaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfReportePaciente));
            this.dtPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPaciente = new dll_reporteador.Presentacion.dsPaciente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtPacienteTA = new dll_reporteador.Presentacion.dsPacienteTableAdapters.dtPacienteTA();
            ((System.ComponentModel.ISupportInitialize)(this.dtPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPacienteBindingSource
            // 
            this.dtPacienteBindingSource.DataMember = "dtPaciente";
            this.dtPacienteBindingSource.DataSource = this.dsPaciente;
            // 
            // dsPaciente
            // 
            this.dsPaciente.DataSetName = "dsPaciente";
            this.dsPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPaciente";
            reportDataSource1.Value = this.dtPacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dll_reporteador.Presentacion.rpPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(727, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtPacienteTA
            // 
            this.dtPacienteTA.ClearBeforeFill = true;
            // 
            // wfReportePaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 343);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfReportePaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Paciente";
            this.Load += new System.EventHandler(this.wfReportePaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPacienteBindingSource;
        private dsPaciente dsPaciente;
        private dsPacienteTableAdapters.dtPacienteTA dtPacienteTA;
    }
}