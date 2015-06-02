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
                                             {"nombre_paciente","nombre","true"},                                            
                                             {"primer_apellido","PrimerApellido","true"},
                                             {"segundo_apellido","SegundoApellido","false"},
                                             {"direccion_paciente","Direccion","false"},
                                             {"telefono_paciente","Telefono","false"},
                                             {"sexo","Sexo","false"},
                                             {"identificacion_paciente","Identificacion","false"},
                                             {"fecha_nacimiento_paciente","FechaNac","false"},
                                             {"estado","Estado","true"},

                                         };
            cuDataGridD1.AlDatosEntrada.Add(ScadenaPacientes);

            String[,] ScadenaTipoExamen ={
                                             {"id_tipo_examen","Codigo","true"},
                                             {"nombre_tipo_examen","Nombre","true"},
                                             {"descripcion_examen","Descripcion","true"},
                                             {"fecha_creacion","FechaCreac","true"},
                                             {"fecha_modificacion","FechaModif","false"},
                                             {"estado","Estado","false"},

                                           };
            cuDataGridD2.AlDatosEntrada.Add(ScadenaTipoExamen);

            String[,] ScadenaMedico = {
                                    {"id_medico","Codigo","true"},
                                    {"nombre_medico","Nombre","true"},
                                    {"priimer_apellido_medico","PrimerApellido","true"},
                                    {"medico_segundo_apellido","SegundoApellido","true"},
                                    {"fecha_ingreso","Fecha","true"},
                                    {"estado","Estado","false"},
                                };
            cuDataGridD3.AlDatosEntrada.Add(ScadenaMedico);
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

            
            cuDataGridD1.vinicializar();

            ////////////////////////////////////
            //////////////Datos Grid Tipo Examen 
            
            cuDataGridD2.vinicializar();

            //////////////////////////////////////
            ////////// Datos Grid Medico
            
            cuDataGridD3.vinicializar();
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPacientes.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTipoExamen.Text = cuDataGridD2.SObtenerDato;
        }

        private void cuDataGridD3_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = cuDataGridD3.SObtenerDato;
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
