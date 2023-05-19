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
    public partial class ListarCentros : Form
    {
        public ListarCentros()
        {
            InitializeComponent();
        }

        private void ListarCentros_Load(object sender, EventArgs e)
        {
            dataGridViewCen.DataSource = Datos.Centros;
        }

        private void dataGridViewCen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_ListCentro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
