﻿namespace MDI_Hospital
{
    partial class wfMDI
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mSMenu = new System.Windows.Forms.MenuStrip();
            this.tlmEstado = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSlblusuario = new System.Windows.Forms.ToolStripLabel();
            this.tllblNombre = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlblCodUsuario = new System.Windows.Forms.ToolStripLabel();
            this.lblTipo = new System.Windows.Forms.ToolStripLabel();
            this.tlblMoneda = new System.Windows.Forms.ToolStripLabel();
            this.tlmEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMenu
            // 
            this.mSMenu.Location = new System.Drawing.Point(0, 0);
            this.mSMenu.Name = "mSMenu";
            this.mSMenu.Size = new System.Drawing.Size(834, 24);
            this.mSMenu.TabIndex = 0;
            this.mSMenu.Text = "Menu";
            // 
            // tlmEstado
            // 
            this.tlmEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlmEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tSlblusuario,
            this.tllblNombre,
            this.toolStripSeparator1,
            this.tlblCodUsuario,
            this.lblTipo,
            this.tlblMoneda});
            this.tlmEstado.Location = new System.Drawing.Point(0, 587);
            this.tlmEstado.Name = "tlmEstado";
            this.tlmEstado.Size = new System.Drawing.Size(834, 25);
            this.tlmEstado.TabIndex = 2;
            this.tlmEstado.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSlblusuario
            // 
            this.tSlblusuario.Name = "tSlblusuario";
            this.tSlblusuario.Size = new System.Drawing.Size(50, 22);
            this.tSlblusuario.Text = "Usuario:";
            // 
            // tllblNombre
            // 
            this.tllblNombre.Name = "tllblNombre";
            this.tllblNombre.Size = new System.Drawing.Size(71, 22);
            this.tllblNombre.Text = "tllblNombre";
            this.tllblNombre.Click += new System.EventHandler(this.tllblNombre_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlblCodUsuario
            // 
            this.tlblCodUsuario.Name = "tlblCodUsuario";
            this.tlblCodUsuario.Size = new System.Drawing.Size(86, 22);
            this.tlblCodUsuario.Text = "tlblCodUsuario";
            this.tlblCodUsuario.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(54, 22);
            this.lblTipo.Text = "Moneda:";
            // 
            // tlblMoneda
            // 
            this.tlblMoneda.Name = "tlblMoneda";
            this.tlblMoneda.Size = new System.Drawing.Size(68, 22);
            this.tlblMoneda.Text = "tlblMoneda";
            // 
            // wfMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.tlmEstado);
            this.Controls.Add(this.mSMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mSMenu;
            this.Name = "wfMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.wfMDI_FormClosed);
            this.Load += new System.EventHandler(this.wfMDI_Load);
            this.tlmEstado.ResumeLayout(false);
            this.tlmEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mSMenu;
        private System.Windows.Forms.ToolStrip tlmEstado;
        private System.Windows.Forms.ToolStripLabel tSlblusuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripLabel tllblNombre;
        private System.Windows.Forms.ToolStripLabel tlblCodUsuario;
        private System.Windows.Forms.ToolStripLabel lblTipo;
        private System.Windows.Forms.ToolStripLabel tlblMoneda;
    }
}

