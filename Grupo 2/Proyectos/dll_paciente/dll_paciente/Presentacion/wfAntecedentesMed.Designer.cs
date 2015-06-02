namespace dll_paciente.Presentacion
{
    partial class wfAntecedentesMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAntecedentesMed));
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblidenfermedad = new System.Windows.Forms.Label();
            this.lblidPaciente = new System.Windows.Forms.Label();
            this.lblidAnte = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtidenfermedad = new System.Windows.Forms.TextBox();
            this.txtidpaciente = new System.Windows.Forms.TextBox();
            this.txtidantecedente = new System.Windows.Forms.TextBox();
            this.tbcantecedentesmedicos = new System.Windows.Forms.TabControl();
            this.tbppaciente = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbpemfermedad = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.navegador1 = new Navegador.Navegador();
            this.tbcantecedentesmedicos.SuspendLayout();
            this.tbppaciente.SuspendLayout();
            this.tbpemfermedad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.White;
            this.lbldescripcion.Location = new System.Drawing.Point(40, 120);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(83, 17);
            this.lbldescripcion.TabIndex = 26;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblidenfermedad
            // 
            this.lblidenfermedad.AutoSize = true;
            this.lblidenfermedad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidenfermedad.ForeColor = System.Drawing.Color.White;
            this.lblidenfermedad.Location = new System.Drawing.Point(473, 84);
            this.lblidenfermedad.Name = "lblidenfermedad";
            this.lblidenfermedad.Size = new System.Drawing.Size(105, 17);
            this.lblidenfermedad.TabIndex = 25;
            this.lblidenfermedad.Text = "ID enfermedad";
            // 
            // lblidPaciente
            // 
            this.lblidPaciente.AutoSize = true;
            this.lblidPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidPaciente.ForeColor = System.Drawing.Color.White;
            this.lblidPaciente.Location = new System.Drawing.Point(276, 84);
            this.lblidPaciente.Name = "lblidPaciente";
            this.lblidPaciente.Size = new System.Drawing.Size(83, 17);
            this.lblidPaciente.TabIndex = 24;
            this.lblidPaciente.Text = "ID paciente";
            // 
            // lblidAnte
            // 
            this.lblidAnte.AutoSize = true;
            this.lblidAnte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidAnte.ForeColor = System.Drawing.Color.White;
            this.lblidAnte.Location = new System.Drawing.Point(40, 84);
            this.lblidAnte.Name = "lblidAnte";
            this.lblidAnte.Size = new System.Drawing.Size(114, 17);
            this.lblidAnte.TabIndex = 23;
            this.lblidAnte.Text = "ID antecedentes";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(160, 119);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(477, 75);
            this.txtdescripcion.TabIndex = 22;
            this.txtdescripcion.Tag = "Descripcion";
            // 
            // txtidenfermedad
            // 
            this.txtidenfermedad.Location = new System.Drawing.Point(595, 81);
            this.txtidenfermedad.Name = "txtidenfermedad";
            this.txtidenfermedad.Size = new System.Drawing.Size(42, 20);
            this.txtidenfermedad.TabIndex = 21;
            this.txtidenfermedad.Tag = "id_enfermedad";
            // 
            // txtidpaciente
            // 
            this.txtidpaciente.Location = new System.Drawing.Point(376, 83);
            this.txtidpaciente.Name = "txtidpaciente";
            this.txtidpaciente.Size = new System.Drawing.Size(35, 20);
            this.txtidpaciente.TabIndex = 20;
            this.txtidpaciente.Tag = "id_pacientes";
            // 
            // txtidantecedente
            // 
            this.txtidantecedente.Location = new System.Drawing.Point(160, 83);
            this.txtidantecedente.Name = "txtidantecedente";
            this.txtidantecedente.Size = new System.Drawing.Size(34, 20);
            this.txtidantecedente.TabIndex = 19;
            this.txtidantecedente.Tag = "id_antecente_medico";
            // 
            // tbcantecedentesmedicos
            // 
            this.tbcantecedentesmedicos.Controls.Add(this.tbppaciente);
            this.tbcantecedentesmedicos.Controls.Add(this.tbpemfermedad);
            this.tbcantecedentesmedicos.Location = new System.Drawing.Point(39, 201);
            this.tbcantecedentesmedicos.Name = "tbcantecedentesmedicos";
            this.tbcantecedentesmedicos.SelectedIndex = 0;
            this.tbcantecedentesmedicos.Size = new System.Drawing.Size(598, 247);
            this.tbcantecedentesmedicos.TabIndex = 18;
            // 
            // tbppaciente
            // 
            this.tbppaciente.Controls.Add(this.cuDataGridD1);
            this.tbppaciente.Location = new System.Drawing.Point(4, 22);
            this.tbppaciente.Name = "tbppaciente";
            this.tbppaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbppaciente.Size = new System.Drawing.Size(590, 221);
            this.tbppaciente.TabIndex = 0;
            this.tbppaciente.Text = "Paciente";
            this.tbppaciente.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.alObtenerCampos")));
            this.cuDataGridD1.AutoSize = true;
            this.cuDataGridD1.BackColor = System.Drawing.Color.DarkGray;
            this.cuDataGridD1.ICampo = 0;
            this.cuDataGridD1.Location = new System.Drawing.Point(3, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.Size = new System.Drawing.Size(581, 272);
            this.cuDataGridD1.STabla = "paciente";
            this.cuDataGridD1.TabIndex = 1;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tbpemfermedad
            // 
            this.tbpemfermedad.Controls.Add(this.cuDataGridD2);
            this.tbpemfermedad.Location = new System.Drawing.Point(4, 22);
            this.tbpemfermedad.Name = "tbpemfermedad";
            this.tbpemfermedad.Padding = new System.Windows.Forms.Padding(3);
            this.tbpemfermedad.Size = new System.Drawing.Size(590, 221);
            this.tbpemfermedad.TabIndex = 1;
            this.tbpemfermedad.Text = "Enfermedad";
            this.tbpemfermedad.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.alObtenerCampos")));
            this.cuDataGridD2.AutoSize = true;
            this.cuDataGridD2.BackColor = System.Drawing.Color.DarkGray;
            this.cuDataGridD2.ICampo = 0;
            this.cuDataGridD2.Location = new System.Drawing.Point(0, 6);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.Size = new System.Drawing.Size(584, 183);
            this.cuDataGridD2.STabla = "enfermedades_antecedentes";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(39, 7);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "antecedentes_medicos";
            this.navegador1.TabIndex = 17;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // wfAntecedentesMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(703, 507);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblidenfermedad);
            this.Controls.Add(this.lblidPaciente);
            this.Controls.Add(this.lblidAnte);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtidenfermedad);
            this.Controls.Add(this.txtidpaciente);
            this.Controls.Add(this.txtidantecedente);
            this.Controls.Add(this.tbcantecedentesmedicos);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfAntecedentesMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antecedentes médicos";
            this.Load += new System.EventHandler(this.wfAntecedentesMed_Load);
            this.tbcantecedentesmedicos.ResumeLayout(false);
            this.tbppaciente.ResumeLayout(false);
            this.tbppaciente.PerformLayout();
            this.tbpemfermedad.ResumeLayout(false);
            this.tbpemfermedad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblidenfermedad;
        private System.Windows.Forms.Label lblidPaciente;
        private System.Windows.Forms.Label lblidAnte;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtidenfermedad;
        private System.Windows.Forms.TextBox txtidpaciente;
        private System.Windows.Forms.TextBox txtidantecedente;
        private System.Windows.Forms.TabControl tbcantecedentesmedicos;
        private System.Windows.Forms.TabPage tbppaciente;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tbpemfermedad;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private Navegador.Navegador navegador1;
    }
}