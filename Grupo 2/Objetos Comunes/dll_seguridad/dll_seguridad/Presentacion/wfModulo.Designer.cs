namespace dll_seguridad.Presentacion
{
    partial class wfModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfModulo));
            this.lblcodmod = new System.Windows.Forms.Label();
            this.lblnommodulo = new System.Windows.Forms.Label();
            this.txtIDModulo = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.lblnomdll = new System.Windows.Forms.Label();
            this.txtNombreDLL = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblfechcreacion = new System.Windows.Forms.Label();
            this.lblfechmodificacion = new System.Windows.Forms.Label();
            this.txtfecc = new System.Windows.Forms.TextBox();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcodmod
            // 
            this.lblcodmod.AutoSize = true;
            this.lblcodmod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodmod.ForeColor = System.Drawing.Color.White;
            this.lblcodmod.Location = new System.Drawing.Point(29, 110);
            this.lblcodmod.Name = "lblcodmod";
            this.lblcodmod.Size = new System.Drawing.Size(113, 17);
            this.lblcodmod.TabIndex = 0;
            this.lblcodmod.Text = "Código módulo";
            // 
            // lblnommodulo
            // 
            this.lblnommodulo.AutoSize = true;
            this.lblnommodulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnommodulo.ForeColor = System.Drawing.Color.White;
            this.lblnommodulo.Location = new System.Drawing.Point(32, 150);
            this.lblnommodulo.Name = "lblnommodulo";
            this.lblnommodulo.Size = new System.Drawing.Size(116, 17);
            this.lblnommodulo.TabIndex = 1;
            this.lblnommodulo.Text = "Nombre módulo";
            // 
            // txtIDModulo
            // 
            this.txtIDModulo.Location = new System.Drawing.Point(148, 105);
            this.txtIDModulo.Name = "txtIDModulo";
            this.txtIDModulo.Size = new System.Drawing.Size(31, 20);
            this.txtIDModulo.TabIndex = 1;
            this.txtIDModulo.Tag = "id_modulo";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(148, 143);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMod.TabIndex = 3;
            this.txtNombreMod.Tag = "nombre_modulo";
            // 
            // lblnomdll
            // 
            this.lblnomdll.AutoSize = true;
            this.lblnomdll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomdll.ForeColor = System.Drawing.Color.White;
            this.lblnomdll.Location = new System.Drawing.Point(256, 108);
            this.lblnomdll.Name = "lblnomdll";
            this.lblnomdll.Size = new System.Drawing.Size(87, 17);
            this.lblnomdll.TabIndex = 4;
            this.lblnomdll.Text = "Nombre DLL";
            // 
            // txtNombreDLL
            // 
            this.txtNombreDLL.Location = new System.Drawing.Point(388, 105);
            this.txtNombreDLL.Name = "txtNombreDLL";
            this.txtNombreDLL.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDLL.TabIndex = 2;
            this.txtNombreDLL.Tag = "nombre_dll";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.White;
            this.lblestado.Location = new System.Drawing.Point(504, 108);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(52, 17);
            this.lblestado.TabIndex = 6;
            this.lblestado.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(745, 105);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(19, 20);
            this.txtestado.TabIndex = 6;
            this.txtestado.Tag = "estado";
            this.txtestado.Visible = false;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(77, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "modulo";
            this.navegador1.TabIndex = 8;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.navegador1_btnBuscar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(644, 107);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // lblfechcreacion
            // 
            this.lblfechcreacion.AutoSize = true;
            this.lblfechcreacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechcreacion.ForeColor = System.Drawing.Color.White;
            this.lblfechcreacion.Location = new System.Drawing.Point(256, 146);
            this.lblfechcreacion.Name = "lblfechcreacion";
            this.lblfechcreacion.Size = new System.Drawing.Size(108, 17);
            this.lblfechcreacion.TabIndex = 9;
            this.lblfechcreacion.Text = "Fecha creación";
            // 
            // lblfechmodificacion
            // 
            this.lblfechmodificacion.AutoSize = true;
            this.lblfechmodificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechmodificacion.ForeColor = System.Drawing.Color.White;
            this.lblfechmodificacion.Location = new System.Drawing.Point(504, 147);
            this.lblfechmodificacion.Name = "lblfechmodificacion";
            this.lblfechmodificacion.Size = new System.Drawing.Size(137, 17);
            this.lblfechmodificacion.TabIndex = 10;
            this.lblfechmodificacion.Text = "Fecha modificación";
            // 
            // txtfecc
            // 
            this.txtfecc.Location = new System.Drawing.Point(388, 142);
            this.txtfecc.Name = "txtfecc";
            this.txtfecc.Size = new System.Drawing.Size(100, 20);
            this.txtfecc.TabIndex = 11;
            this.txtfecc.Tag = "fecha_creacion";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(644, 142);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 12;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // wfModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(759, 217);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.txtfecc);
            this.Controls.Add(this.lblfechmodificacion);
            this.Controls.Add(this.lblfechcreacion);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtNombreDLL);
            this.Controls.Add(this.lblnomdll);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.txtIDModulo);
            this.Controls.Add(this.lblnommodulo);
            this.Controls.Add(this.lblcodmod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Modulo";
            this.Load += new System.EventHandler(this.wfModulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodmod;
        private System.Windows.Forms.Label lblnommodulo;
        private System.Windows.Forms.TextBox txtIDModulo;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label lblnomdll;
        private System.Windows.Forms.TextBox txtNombreDLL;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblfechcreacion;
        private System.Windows.Forms.Label lblfechmodificacion;
        private System.Windows.Forms.TextBox txtfecc;
        private System.Windows.Forms.TextBox txtfecm;
    }
}