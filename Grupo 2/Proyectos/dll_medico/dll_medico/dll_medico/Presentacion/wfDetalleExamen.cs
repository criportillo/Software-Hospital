﻿/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 18-05-2015
 * Autor: Jessica Marisol Castellanos Martínez 
 * Descripcion: Este es el formulario de Detalle Examen
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_medico.Presentacion
{
    public partial class wfDetalleExamen : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfDetalleExamen()
        {
            InitializeComponent();
            String[,] ScadenaPacientes = {
                                             {"id_pacientes","Codigo","true"},
                                             {"nombre_paciente","Nombre","true"},                                            
                                             {"primer_apellido","Apellido","true"},
                                             {"segundo_apellido","Segundo_Apellido","false"},
                                             {"direccion_paciente","Direccion","false"},
                                             {"telefono_paciente","Telefono","false"},
                                             {"sexo","Sexo","false"},
                                             {"identificacion_paciente","Identificacion","false"},
                                             {"fecha_nacimiento_paciente","FechaNac","false"},
                                             {"estado","Estado","true"},

                                         };
            dgvpaciente.AlDatosEntrada.Add(ScadenaPacientes);

            String[,] ScadenaTipoExamen ={
                                             {"id_tipo_examen","Codigo","true"},
                                             {"nombre_tipo_examen","Nombre","true"},
                                             {"descripcion_examen","Descripcion","true"},
                                             {"fecha_creacion","Fecha_Creacion","true"},
                                             {"fecha_modificacion","Fecha_Modificacion","false"},
                                             {"estado","Estado","false"},

                                           };
            dgvtipoexamen.AlDatosEntrada.Add(ScadenaTipoExamen);

            String[,] ScadenaMedico = {
                                    {"id_medico","Codigo","true"},
                                    {"nombre_medico","Nombre","true"},
                                    {"priimer_apellido_medico","Apellido","true"},
                                    {"medico_segundo_apellido","Segundo_Apellido","true"},
                                    {"fecha_ingreso","Fecha","true"},
                                    {"estado","Estado","false"},
                                };
            dgvmedico.AlDatosEntrada.Add(ScadenaMedico);
        }

        private void wfDetalleExamen_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdDetalleExamen);
            alDatosEntrada.Add(txtIdPacientes);
            alDatosEntrada.Add(txtIdTipoExamen);
            alDatosEntrada.Add(txtIdMedico);
           
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();

            ///////////////////////////////////
            ///////// Datos Grid Pacientes

            
            dgvpaciente.vinicializar();

            ////////////////////////////////////
            //////////////Datos Grid Tipo Examen 
            
            dgvtipoexamen.vinicializar();

            //////////////////////////////////////
            ////////// Datos Grid Medico
            
            dgvmedico.vinicializar();
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPacientes.Text = dgvpaciente.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTipoExamen.Text = dgvtipoexamen.SObtenerDato;
        }

        private void cuDataGridD3_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = dgvmedico.SObtenerDato;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtIdDetalleExamen.Enabled = false;
            txtIdMedico.Enabled = false;
            txtIdPacientes.Enabled = false;
            txtIdTipoExamen.Enabled = false;
        }
    }
}
