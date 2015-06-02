namespace dll_medico.Presentacion
{
    partial class wfCitaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCitaMedica));
            this.navegador1 = new Navegador.Navegador();
            this.lblcitamedica = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblmedico = new System.Windows.Forms.Label();
            this.lblpacientes = new System.Windows.Forms.Label();
            this.lblfechacita = new System.Windows.Forms.Label();
            this.lbltipocita = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtIdCitaMedica = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.txtIdPacientes = new System.Windows.Forms.TextBox();
            this.txtFechaCita = new System.Windows.Forms.TextBox();
            this.txtTipoCita = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.tbccitamedica = new System.Windows.Forms.TabControl();
            this.tbpusuario = new System.Windows.Forms.TabPage();
            this.dgvusuario = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbpmedico = new System.Windows.Forms.TabPage();
            this.dgvmedico = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbppaciente = new System.Windows.Forms.TabPage();
            this.dgvpaciente = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbccitamedica.SuspendLayout();
            this.tbpusuario.SuspendLayout();
            this.tbpmedico.SuspendLayout();
            this.tbppaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(24, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "cita_medi";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "";
            this.navegador1.btnNuevo_BeforeClick += new System.EventHandler(this.navegador1_btnNuevo_BeforeClick);
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            this.navegador1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navegador1_MouseMove);
            // 
            // lblcitamedica
            // 
            this.lblcitamedica.AutoSize = true;
            this.lblcitamedica.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcitamedica.ForeColor = System.Drawing.Color.White;
            this.lblcitamedica.Location = new System.Drawing.Point(70, 98);
            this.lblcitamedica.Name = "lblcitamedica";
            this.lblcitamedica.Size = new System.Drawing.Size(104, 17);
            this.lblcitamedica.TabIndex = 1;
            this.lblcitamedica.Text = "Id Cita Medica";
            this.lblcitamedica.Click += new System.EventHandler(this.lblcitamedico_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(232, 98);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(70, 17);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Id Usuario";
            // 
            // lblmedico
            // 
            this.lblmedico.AutoSize = true;
            this.lblmedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedico.ForeColor = System.Drawing.Color.White;
            this.lblmedico.Location = new System.Drawing.Point(232, 133);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(72, 17);
            this.lblmedico.TabIndex = 3;
            this.lblmedico.Text = "Id Medico";
            // 
            // lblpacientes
            // 
            this.lblpacientes.AutoSize = true;
            this.lblpacientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpacientes.ForeColor = System.Drawing.Color.White;
            this.lblpacientes.Location = new System.Drawing.Point(70, 138);
            this.lblpacientes.Name = "lblpacientes";
            this.lblpacientes.Size = new System.Drawing.Size(86, 17);
            this.lblpacientes.TabIndex = 4;
            this.lblpacientes.Text = "Id Pacientes";
            // 
            // lblfechacita
            // 
            this.lblfechacita.AutoSize = true;
            this.lblfechacita.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechacita.ForeColor = System.Drawing.Color.White;
            this.lblfechacita.Location = new System.Drawing.Point(376, 168);
            this.lblfechacita.Name = "lblfechacita";
            this.lblfechacita.Size = new System.Drawing.Size(76, 17);
            this.lblfechacita.TabIndex = 5;
            this.lblfechacita.Text = "Fecha cita";
            // 
            // lbltipocita
            // 
            this.lbltipocita.AutoSize = true;
            this.lbltipocita.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipocita.ForeColor = System.Drawing.Color.White;
            this.lbltipocita.Location = new System.Drawing.Point(376, 133);
            this.lbltipocita.Name = "lbltipocita";
            this.lbltipocita.Size = new System.Drawing.Size(63, 17);
            this.lbltipocita.TabIndex = 6;
            this.lbltipocita.Text = "Tipo cita";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.White;
            this.lblestado.Location = new System.Drawing.Point(376, 98);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(52, 17);
            this.lblestado.TabIndex = 7;
            this.lblestado.Text = "Estado";
            // 
            // txtIdCitaMedica
            // 
            this.txtIdCitaMedica.Enabled = false;
            this.txtIdCitaMedica.Location = new System.Drawing.Point(179, 95);
            this.txtIdCitaMedica.Name = "txtIdCitaMedica";
            this.txtIdCitaMedica.Size = new System.Drawing.Size(30, 20);
            this.txtIdCitaMedica.TabIndex = 8;
            this.txtIdCitaMedica.Tag = "id_cita_medi";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(308, 95);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(30, 20);
            this.txtIdUsuario.TabIndex = 9;
            this.txtIdUsuario.Tag = "id_usuario";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Enabled = false;
            this.txtIdMedico.Location = new System.Drawing.Point(308, 129);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(30, 20);
            this.txtIdMedico.TabIndex = 10;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // txtIdPacientes
            // 
            this.txtIdPacientes.Enabled = false;
            this.txtIdPacientes.Location = new System.Drawing.Point(179, 132);
            this.txtIdPacientes.Name = "txtIdPacientes";
            this.txtIdPacientes.Size = new System.Drawing.Size(30, 20);
            this.txtIdPacientes.TabIndex = 11;
            this.txtIdPacientes.Tag = "id_pacientes";
            // 
            // txtFechaCita
            // 
            this.txtFechaCita.Location = new System.Drawing.Point(564, 168);
            this.txtFechaCita.Name = "txtFechaCita";
            this.txtFechaCita.Size = new System.Drawing.Size(24, 20);
            this.txtFechaCita.TabIndex = 12;
            this.txtFechaCita.Tag = "fecha_cita";
            this.txtFechaCita.Visible = false;
            this.txtFechaCita.TextChanged += new System.EventHandler(this.txtFechaCita_TextChanged);
            // 
            // txtTipoCita
            // 
            this.txtTipoCita.Location = new System.Drawing.Point(458, 129);
            this.txtTipoCita.Name = "txtTipoCita";
            this.txtTipoCita.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCita.TabIndex = 13;
            this.txtTipoCita.Tag = "tipo_cita";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(564, 95);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(24, 20);
            this.txtEstado.TabIndex = 14;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(458, 95);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(100, 21);
            this.cboEstado.TabIndex = 15;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Enabled = false;
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(458, 168);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCita.TabIndex = 16;
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // tbccitamedica
            // 
            this.tbccitamedica.Controls.Add(this.tbpusuario);
            this.tbccitamedica.Controls.Add(this.tbpmedico);
            this.tbccitamedica.Controls.Add(this.tbppaciente);
            this.tbccitamedica.Location = new System.Drawing.Point(55, 205);
            this.tbccitamedica.Name = "tbccitamedica";
            this.tbccitamedica.SelectedIndex = 0;
            this.tbccitamedica.Size = new System.Drawing.Size(543, 176);
            this.tbccitamedica.TabIndex = 17;
            // 
            // tbpusuario
            // 
            this.tbpusuario.Controls.Add(this.dgvusuario);
            this.tbpusuario.Location = new System.Drawing.Point(4, 22);
            this.tbpusuario.Name = "tbpusuario";
            this.tbpusuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpusuario.Size = new System.Drawing.Size(535, 150);
            this.tbpusuario.TabIndex = 0;
            this.tbpusuario.Text = "Usuario";
            this.tbpusuario.UseVisualStyleBackColor = true;
            // 
            // dgvusuario
            // 
            this.dgvusuario.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvusuario.AlDatosEntrada")));
            this.dgvusuario.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvusuario.alObtenerCampos")));
            this.dgvusuario.AutoSize = true;
            this.dgvusuario.BackColor = System.Drawing.Color.DarkGray;
            this.dgvusuario.ICampo = 0;
            this.dgvusuario.Location = new System.Drawing.Point(-4, 3);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.Size = new System.Drawing.Size(543, 151);
            this.dgvusuario.STabla = "usuario";
            this.dgvusuario.TabIndex = 0;
            this.dgvusuario.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tbpmedico
            // 
            this.tbpmedico.Controls.Add(this.dgvmedico);
            this.tbpmedico.Location = new System.Drawing.Point(4, 22);
            this.tbpmedico.Name = "tbpmedico";
            this.tbpmedico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpmedico.Size = new System.Drawing.Size(535, 150);
            this.tbpmedico.TabIndex = 1;
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
            this.dgvmedico.Location = new System.Drawing.Point(-4, 3);
            this.dgvmedico.Name = "dgvmedico";
            this.dgvmedico.Size = new System.Drawing.Size(543, 151);
            this.dgvmedico.STabla = "medico";
            this.dgvmedico.TabIndex = 0;
            this.dgvmedico.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // tbppaciente
            // 
            this.tbppaciente.Controls.Add(this.dgvpaciente);
            this.tbppaciente.Location = new System.Drawing.Point(4, 22);
            this.tbppaciente.Name = "tbppaciente";
            this.tbppaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbppaciente.Size = new System.Drawing.Size(535, 150);
            this.tbppaciente.TabIndex = 2;
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
            this.dgvpaciente.Size = new System.Drawing.Size(543, 154);
            this.dgvpaciente.STabla = "paciente";
            this.dgvpaciente.TabIndex = 0;
            this.dgvpaciente.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD3_sdgv_CellClick);
            // 
            // wfCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(643, 414);
            this.Controls.Add(this.tbccitamedica);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtTipoCita);
            this.Controls.Add(this.txtFechaCita);
            this.Controls.Add(this.txtIdPacientes);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtIdCitaMedica);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lbltipocita);
            this.Controls.Add(this.lblfechacita);
            this.Controls.Add(this.lblpacientes);
            this.Controls.Add(this.lblmedico);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcitamedica);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCitaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita Medica";
            this.Load += new System.EventHandler(this.wfCitaMedica_Load);
            this.tbccitamedica.ResumeLayout(false);
            this.tbpusuario.ResumeLayout(false);
            this.tbpusuario.PerformLayout();
            this.tbpmedico.ResumeLayout(false);
            this.tbpmedico.PerformLayout();
            this.tbppaciente.ResumeLayout(false);
            this.tbppaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblcitamedica;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblmedico;
        private System.Windows.Forms.Label lblpacientes;
        private System.Windows.Forms.Label lblfechacita;
        private System.Windows.Forms.Label lbltipocita;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtIdCitaMedica;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.TextBox txtIdPacientes;
        private System.Windows.Forms.TextBox txtFechaCita;
        private System.Windows.Forms.TextBox txtTipoCita;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TabControl tbccitamedica;
        private System.Windows.Forms.TabPage tbpusuario;
        private System.Windows.Forms.TabPage tbpmedico;
        private System.Windows.Forms.TabPage tbppaciente;
        private dll_bitacora.Presentacion.cuDataGridD dgvusuario;
        private dll_bitacora.Presentacion.cuDataGridD dgvmedico;
        private dll_bitacora.Presentacion.cuDataGridD dgvpaciente;
    }
}