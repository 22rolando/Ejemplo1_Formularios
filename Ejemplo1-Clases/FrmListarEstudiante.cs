using System;
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
    public partial class FrmListarEstudiante : Form
    {
        public FrmListarEstudiante()
        {
            InitializeComponent();
        }

        private void FrmListarEstudiante_Load(object sender, EventArgs e)
        {
            dataGridViewEst.DataSource = Datos.Alumnos;
        }

        private void dataGridViewEst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_ListEstudiante_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
