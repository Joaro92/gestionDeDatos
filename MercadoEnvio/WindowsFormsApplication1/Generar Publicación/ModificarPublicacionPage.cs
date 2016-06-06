﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class ModificarPublicacionPage : Form
    {
        public ModificarPublicacionPage()
        {
            InitializeComponent();
            


        }

        private void ModificarPublicacionPage_Load(object sender, EventArgs e)
        {
            PublicacionSubastaDaoImpl sub = new PublicacionSubastaDaoImpl();
            this.Tag = sub.GetById(352375);

            if (this.Tag != null)
            {
                String tipoPublicacion = null;
                Double? codigo = null;
                String descripcion = null;
                Double? stock = null;
                bool? envioSN = null;
                bool? preguntasSN = null;
                Double precio = 0;
                DateTime? fechaIncioDateTime = null;
                DateTime? fechaVencimientoDateTime = null;
                String nombreUsuario = null;
                Estadopublicacion estadoPublicacion = new Estadopublicacion();
                ICollection<Rubro> rubro = new List<Rubro>();
                Visibilidad visbilidad = new Visibilidad();

                if (this.Tag is PublicacionSubasta) {
                    PublicacionSubasta publicacionSubasta = (PublicacionSubasta)this.Tag;
                    //Datos Basicos
                    tipoPublicacion = "Publicación Subasta";
                    codigo = publicacionSubasta.codigoPublicacion;
                    descripcion = publicacionSubasta.descripcion;
                    stock = publicacionSubasta.stock;
                    envioSN = publicacionSubasta.envioSN;   
                    preguntasSN = publicacionSubasta.preguntasSN;
                    precio = publicacionSubasta.valorInicialVenta;
                    fechaIncioDateTime = publicacionSubasta.fechaCreacion;
                    fechaVencimientoDateTime = publicacionSubasta.fechaVencimiento;
                    nombreUsuario = publicacionSubasta.Usuario.userName;
                    //Combo values
                    estadoPublicacion = publicacionSubasta.EstadoPublicacion;
                    rubro = publicacionSubasta.RubroLst;
                    visbilidad = publicacionSubasta.Visibilidad;

                } if (this.Tag is PublicacionNormal) {
                    PublicacionNormal publicacionDirecta = (PublicacionNormal)this.Tag;
                    tipoPublicacion = "Publicación Compra Inmediata";
                    //Datos Basicos
                    codigo = publicacionDirecta.codigoPublicacion;
                    descripcion = publicacionDirecta.descripcion;
                    stock = publicacionDirecta.stock;
                    envioSN = publicacionDirecta.envioSN;   
                    preguntasSN = publicacionDirecta.preguntasSN;
                    precio = publicacionDirecta.precioPorUnidad;
                    fechaIncioDateTime = publicacionDirecta.fechaCreacion;
                    fechaVencimientoDateTime = publicacionDirecta.fechaVencimiento;
                    nombreUsuario = publicacionDirecta.Usuario.userName;
                    //Combo values
                    estadoPublicacion = publicacionDirecta.EstadoPublicacion;
                    rubro = publicacionDirecta.RubroLst;
                    visbilidad = publicacionDirecta.Visibilidad;
                }
                
                comboBox1.Text=tipoPublicacion;
                CodigoPublicacionTxt.Text= Convert.ToString(codigo);
                DescripcionTxt.Text = descripcion;
                stockTxt.Text = Convert.ToString(stock);                           
                EnvioCheckBox.Checked = Convert.ToBoolean(envioSN);
                PreguntasCheckBox.Checked = Convert.ToBoolean(preguntasSN);
                PrecioTxt.Text = Convert.ToString(precio);
                UsuarioNombreTxt.Text = nombreUsuario;
                fechaIncioDateTimeTxt.Value = fechaIncioDateTime.Value;
                fechaVencimientoDateTimeTxt.Value = fechaVencimientoDateTime.Value;

                WorkflowEstadosDaoImpl workflowEstadosDaoImpl = new WorkflowEstadosDaoImpl();
                IList<Estadopublicacion> estadosPublicacionLts = workflowEstadosDaoImpl.darWorkflowEstadosActivoByEstadoActual(estadoPublicacion.idEstadoPublicacion);

                //Setup data binding
                EstadoComboBox.DataSource = estadosPublicacionLts;
                EstadoComboBox.DisplayMember = "nombre";
                EstadoComboBox.ValueMember = "idEstadoPublicacion";


                RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
                IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();
/*                foreach (rubro rubrolts in rubrolts)  {
                
                }*/

                RubroComboBox.DataSource = rubroLts;
                RubroComboBox.DisplayMember = "descripcion";
                RubroComboBox.ValueMember = "idRubro";


            }
        }

        private void fechaIncioDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {



























        }
    }
}
