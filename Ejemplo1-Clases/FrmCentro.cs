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
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCentro_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Centro centro1 = new Centro();

            if (txtNombre_Centro.Text.Length > 3 || txtDireccionCentro.Text.Length > 3 || txtTelefonoCentro.Text.Length > 3 || txtEmailCentro.Text.Length > 3)
            {
                centro1.Nombre = txtNombre_Centro.Text;
                centro1.Dir = txtDireccionCentro.Text;
                centro1.Telf = txtTelefonoCentro.Text;
                centro1.Email = txtEmailCentro.Text;

                Datos.Centros.Add(centro1);

                MessageBox.Show("Se agregaron los datos exitosamente ");
            }
            else
            {
                MessageBox.Show("Llene los campos solicitados","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
                
                     
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
