namespace dll_medico.Presentacion
{
    partial class wfDetalleExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetalleExamen));
            this.navegador1 = new Navegador.Navegador();
            this.txtIdDetalleExamen = new System.Windows.Forms.TextBox();
            this.txtIdPacientes = new System.Windows.Forms.TextBox();
            this.txtIdTipoExamen = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.lbldetalleexamen = new System.Windows.Forms.Label();
            this.lblidpacientes = new System.Windows.Forms.Label();
            this.lbltipoexamen = new System.Windows.Forms.Label();
            this.lblidmedico = new System.Windows.Forms.Label();
            this.tbcdetalleexamen = new System.Windows.Forms.TabControl();
            this.tbppaciente = new System.Windows.Forms.TabPage();
            this.dgvpaciente = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbptipoexamen = new System.Windows.Forms.TabPage();
            this.dgvtipoexamen = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbpmedico = new System.Windows.Forms.TabPage();
            this.dgvmedico = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbcdetalleexamen.SuspendLayout();
            this.tbppaciente.SuspendLayout();
            this.tbptipoexamen.SuspendLayout();
            this.tbpmedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "det_examen";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // txtIdDetalleExamen
            // 
            this.txtIdDetalleExamen.Enabled = false;
            this.txtIdDetalleExamen.Location = new System.Drawing.Point(236, 91);
            this.txtIdDetalleExamen.Name = "txtIdDetalleExamen";
            this.txtIdDetalleExamen.Size = new System.Drawing.Size(31, 20);
            this.txtIdDetalleExamen.TabIndex = 1;
            this.txtIdDetalleExamen.Tag = "id_det_examen";
            // 
            // txtIdPacientes
            // 
            this.txtIdPacientes.Enabled = false;
            this.txtIdPacientes.Location = new System.Drawing.Point(454, 91);
            this.txtIdPacientes.Name = "txtIdPacientes";
            this.txtIdPacientes.Size = new System.Drawing.Size(31, 20);
            this.txtIdPacientes.TabIndex = 2;
            this.txtIdPacientes.Tag = "id_pacientes";
            // 
            // txtIdTipoExamen
            // 
            this.txtIdTipoExamen.Enabled = false;
            this.txtIdTipoExamen.Location = new System.Drawing.Point(236, 123);
            this.txtIdTipoExamen.Name = "txtIdTipoExamen";
            this.txtIdTipoExamen.Size = new System.Drawing.Size(31, 20);
            this.txtIdTipoExamen.TabIndex = 3;
            this.txtIdTipoExamen.Tag = "id_tipo_examen";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Enabled = false;
            this.txtIdMedico.Location = new System.Drawing.Point(454, 123);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(31, 20);
            this.txtIdMedico.TabIndex = 4;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // lbldetalleexamen
            // 
            this.lbldetalleexamen.AutoSize = true;
            this.lbldetalleexamen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalleexamen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldetalleexamen.Location = new System.Drawing.Point(95, 92);
            this.lbldetalleexamen.Name = "lbldetalleexamen";
            this.lbldetalleexamen.Size = new System.Drawing.Size(125, 17);
            this.lbldetalleexamen.TabIndex = 5;
            this.lbldetalleexamen.Text = "Id Detalle Examen";
            // 
            // lblidpacientes
            // 
            this.lblidpacientes.AutoSize = true;
            this.lblidpacientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidpacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblidpacientes.Location = new System.Drawing.Point(366, 94);
            this.lblidpacientes.Name = "lblidpacientes";
            this.lblidpacientes.Size = new System.Drawing.Size(86, 17);
            this.lblidpacientes.TabIndex = 6;
            this.lblidpacientes.Text = "Id Pacientes";
            // 
            // lbltipoexamen
            // 
            this.lbltipoexamen.AutoSize = true;
            this.lbltipoexamen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoexamen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltipoexamen.Location = new System.Drawing.Point(95, 124);
            this.lbltipoexamen.Name = "lbltipoexamen";
            this.lbltipoexamen.Size = new System.Drawing.Size(105, 17);
            this.lbltipoexamen.TabIndex = 7;
            this.lbltipoexamen.Text = "Id Tipo Examen";
            // 
            // lblidmedico
            // 
            this.lblidmedico.AutoSize = true;
            this.lblidmedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidmedico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblidmedico.Location = new System.Drawing.Point(366, 123);
            this.lblidmedico.Name = "lblidmedico";
            this.lblidmedico.Size = new System.Drawing.Size(74, 17);
            this.lblidmedico.TabIndex = 8;
            this.lblidmedico.Text = "Id medico";
            // 
            // tbcdetalleexamen
            // 
            this.tbcdetalleexamen.Controls.Add(this.tbppaciente);
            this.tbcdetalleexamen.Controls.Add(this.tbptipoexamen);
            this.tbcdetalleexamen.Controls.Add(this.tbpmedico);
            this.tbcdetalleexamen.Location = new System.Drawing.Point(59, 174);
            this.tbcdetalleexamen.Name = "tbcdetalleexamen";
            this.tbcdetalleexamen.SelectedIndex = 0;
            this.tbcdetalleexamen.Size = new System.Drawing.Size(534, 173);
            this.tbcdetalleexamen.TabIndex = 9;
            // 
            // tbppaciente
            // 
            this.tbppaciente.Controls.Add(this.dgvpaciente);
            this.tbppaciente.Location = new System.Drawing.Point(4, 22);
            this.tbppaciente.Name = "tbppaciente";
            this.tbppaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbppaciente.Size = new System.Drawing.Size(526, 147);
            this.tbppaciente.TabIndex = 0;
            this.tbppaciente.Text = "Pacientes";
            this.tbppaciente.UseVisualStyleBackColor = true;
            // 
            // dgvpaciente
            // 
            this.dgvpaciente.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvpaciente.AlDatosEntrada")));
            this.dgvpaciente.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvpaciente.alObtenerCampos")));
            this.dgvpaciente.AutoSize = true;
            this.dgvpaciente.BackColor = System.Drawing.Color.DarkGray;
            this.dgvpaciente.ICampo = 0;
            this.dgvpaciente.Location = new System.Drawing.Point(-4, 0);
            this.dgvpaciente.Name = "dgvpaciente";
            this.dgvpaciente.Size = new System.Drawing.Size(534, 151);
            this.dgvpaciente.STabla = "paciente";
            this.dgvpaciente.TabIndex = 0;
            this.dgvpaciente.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tbptipoexamen
            // 
            this.tbptipoexamen.Controls.Add(this.dgvtipoexamen);
            this.tbptipoexamen.Location = new System.Drawing.Point(4, 22);
            this.tbptipoexamen.Name = "tbptipoexamen";
            this.tbptipoexamen.Padding = new System.Windows.Forms.Padding(3);
            this.tbptipoexamen.Size = new System.Drawing.Size(526, 147);
            this.tbptipoexamen.TabIndex = 1;
            this.tbptipoexamen.Text = "Tipo Examen";
            this.tbptipoexamen.UseVisualStyleBackColor = true;
            // 
            // dgvtipoexamen
            // 
            this.dgvtipoexamen.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvtipoexamen.AlDatosEntrada")));
            this.dgvtipoexamen.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvtipoexamen.alObtenerCampos")));
            this.dgvtipoexamen.AutoSize = true;
            this.dgvtipoexamen.BackColor = System.Drawing.Color.DarkGray;
            this.dgvtipoexamen.ICampo = 0;
            this.dgvtipoexamen.Location = new System.Drawing.Point(-4, 0);
            this.dgvtipoexamen.Name = "dgvtipoexamen";
            this.dgvtipoexamen.Size = new System.Drawing.Size(534, 151);
            this.dgvtipoexamen.STabla = "tipo_examen";
            this.dgvtipoexamen.TabIndex = 0;
            this.dgvtipoexamen.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // tbpmedico
            // 
            this.tbpmedico.Controls.Add(this.dgvmedico);
            this.tbpmedico.Location = new System.Drawing.Point(4, 22);
            this.tbpmedico.Name = "tbpmedico";
            this.tbpmedico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpmedico.Size = new System.Drawing.Size(526, 147);
            this.tbpmedico.TabIndex = 2;
            this.tbpmedico.Text = "Medico";
            this.tbpmedico.UseVisualStyleBackColor = true;
            // 
            // dgvmedico
            // 
            this.dgvmedico.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvmedico.AlDatosEntrada")));
            this.dgvmedico.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvmedico.alObtenerCampos")));
            this.dgvmedico.AutoSize = true;
            this.dgvmedico.BackColor = System.Drawing.Color.DarkGray;
            this.dgvmedico.ICampo = 0;
            this.dgvmedico.Location = new System.Drawing.Point(-4, 0);
            this.dgvmedico.Name = "dgvmedico";
            this.dgvmedico.Size = new System.Drawing.Size(534, 151);
            this.dgvmedico.STabla = "medico";
            this.dgvmedico.TabIndex = 0;
            this.dgvmedico.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD3_sdgv_CellClick);
            // 
            // wfDetalleExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.tbcdetalleexamen);
            this.Controls.Add(this.lblidmedico);
            this.Controls.Add(this.lbltipoexamen);
            this.Controls.Add(this.lblidpacientes);
            this.Controls.Add(this.lbldetalleexamen);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.txtIdTipoExamen);
            this.Controls.Add(this.txtIdPacientes);
            this.Controls.Add(this.txtIdDetalleExamen);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDetalleExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Examen";
            this.Load += new System.EventHandler(this.wfDetalleExamen_Load);
            this.tbcdetalleexamen.ResumeLayout(false);
            this.tbppaciente.ResumeLayout(false);
            this.tbppaciente.PerformLayout();
            this.tbptipoexamen.ResumeLayout(false);
            this.tbptipoexamen.PerformLayout();
            this.tbpmedico.ResumeLayout(false);
            this.tbpmedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtIdDetalleExamen;
        private System.Windows.Forms.TextBox txtIdPacientes;
        private System.Windows.Forms.TextBox txtIdTipoExamen;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label lbldetalleexamen;
        private System.Windows.Forms.Label lblidpacientes;
        private System.Windows.Forms.Label lbltipoexamen;
        private System.Windows.Forms.Label lblidmedico;
        private System.Windows.Forms.TabControl tbcdetalleexamen;
        private System.Windows.Forms.TabPage tbppaciente;
        private System.Windows.Forms.TabPage tbptipoexamen;
        private System.Windows.Forms.TabPage tbpmedico;
        private dll_bitacora.Presentacion.cuDataGridD dgvpaciente;
        private dll_bitacora.Presentacion.cuDataGridD dgvtipoexamen;
        private dll_bitacora.Presentacion.cuDataGridD dgvmedico;
    }
}