namespace dll_medico.Presentacion
{
    partial class wfTipoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfTipoExamen));
            this.navegador1 = new Navegador.Navegador();
            this.lblidtipoexamen = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblfechacreacion = new System.Windows.Forms.Label();
            this.lblfechamodificacion = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtIdTipoExamen = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtFechaModificacion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tipo_examen";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            // 
            // lblidtipoexamen
            // 
            this.lblidtipoexamen.AutoSize = true;
            this.lblidtipoexamen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidtipoexamen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblidtipoexamen.Location = new System.Drawing.Point(46, 109);
            this.lblidtipoexamen.Name = "lblidtipoexamen";
            this.lblidtipoexamen.Size = new System.Drawing.Size(105, 17);
            this.lblidtipoexamen.TabIndex = 1;
            this.lblidtipoexamen.Text = "Id Tipo Examen";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnombre.Location = new System.Drawing.Point(46, 152);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(61, 17);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldescripcion.Location = new System.Drawing.Point(46, 193);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(83, 17);
            this.lbldescripcion.TabIndex = 3;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblfechacreacion
            // 
            this.lblfechacreacion.AutoSize = true;
            this.lblfechacreacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechacreacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblfechacreacion.Location = new System.Drawing.Point(292, 148);
            this.lblfechacreacion.Name = "lblfechacreacion";
            this.lblfechacreacion.Size = new System.Drawing.Size(111, 17);
            this.lblfechacreacion.TabIndex = 4;
            this.lblfechacreacion.Text = "Fecha Creacion";
            // 
            // lblfechamodificacion
            // 
            this.lblfechamodificacion.AutoSize = true;
            this.lblfechamodificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechamodificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblfechamodificacion.Location = new System.Drawing.Point(292, 192);
            this.lblfechamodificacion.Name = "lblfechamodificacion";
            this.lblfechamodificacion.Size = new System.Drawing.Size(135, 17);
            this.lblfechamodificacion.TabIndex = 5;
            this.lblfechamodificacion.Text = "Fecha Modificacion";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblestado.Location = new System.Drawing.Point(292, 109);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(52, 17);
            this.lblestado.TabIndex = 6;
            this.lblestado.Text = "Estado";
            // 
            // txtIdTipoExamen
            // 
            this.txtIdTipoExamen.Enabled = false;
            this.txtIdTipoExamen.Location = new System.Drawing.Point(157, 102);
            this.txtIdTipoExamen.Name = "txtIdTipoExamen";
            this.txtIdTipoExamen.Size = new System.Drawing.Size(35, 20);
            this.txtIdTipoExamen.TabIndex = 7;
            this.txtIdTipoExamen.Tag = "id_tipo_examen";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Tag = "nombre_tipo_examen";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(157, 188);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.Tag = "descripcion_examen";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(564, 148);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(30, 20);
            this.txtFechaCreacion.TabIndex = 10;
            this.txtFechaCreacion.Tag = "fecha_creacion";
            this.txtFechaCreacion.Visible = false;
            this.txtFechaCreacion.TextChanged += new System.EventHandler(this.txtFechaCreacion_TextChanged);
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.Location = new System.Drawing.Point(567, 189);
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.Size = new System.Drawing.Size(30, 20);
            this.txtFechaModificacion.TabIndex = 11;
            this.txtFechaModificacion.Tag = "fecha_modificacion";
            this.txtFechaModificacion.Visible = false;
            this.txtFechaModificacion.TextChanged += new System.EventHandler(this.txtFechaModificacion_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(563, 106);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(30, 20);
            this.txtEstado.TabIndex = 12;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Enabled = false;
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(436, 145);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCreacion.TabIndex = 13;
            this.dtpFechaCreacion.ValueChanged += new System.EventHandler(this.dtpFechaCreacion_ValueChanged);
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.Enabled = false;
            this.dtpFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaModificacion.Location = new System.Drawing.Point(435, 187);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaModificacion.TabIndex = 14;
            this.dtpFechaModificacion.ValueChanged += new System.EventHandler(this.dtpFechaModificacion_ValueChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(435, 105);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(101, 21);
            this.cboEstado.TabIndex = 15;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // wfTipoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(621, 289);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dtpFechaModificacion);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFechaModificacion);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdTipoExamen);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblfechamodificacion);
            this.Controls.Add(this.lblfechacreacion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblidtipoexamen);
            this.Controls.Add(this.navegador1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Examen";
            this.Load += new System.EventHandler(this.wfTipoExamen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblidtipoexamen;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblfechacreacion;
        private System.Windows.Forms.Label lblfechamodificacion;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtIdTipoExamen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtFechaModificacion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}