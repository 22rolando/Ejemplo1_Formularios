﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class frmListarTrabajadores : Form
    {
        public frmListarTrabajadores()
        {
            InitializeComponent();
        }

        private void frmTrabajadores_Load(object sender, EventArgs e)
        {
            dataGridViewTra.DataSource = Datos.Personanles;
        }

        private void btnCancelar_ListTrabajador_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
