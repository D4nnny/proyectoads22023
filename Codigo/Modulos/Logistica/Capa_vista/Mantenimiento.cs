﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
//using Controlador_InventariosMenu();

namespace Vista_PrototipoMenu
{
    public partial class Mantenimiento : Form
    {
        Controlador cn = new Controlador();
        public Mantenimiento()
        {
            InitializeComponent();
        }


        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4004";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = Dgv_tablas;
            TextBox[] Grupotextbox = { txt_IdCuenta, Txt_codigo, Txt_nombre, Txt_cuenta, Txt_fecha, Txt_almacen, Txt_tipo, Txt_estatus, Txt_relacion };
            TextBox[] Idtextbox = { txt_IdCuenta, Txt_nombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_tablas, Grupotextbox, cn.getNombreBd());

        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
