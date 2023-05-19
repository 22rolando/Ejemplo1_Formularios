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
    public partial class FrmTrabajador : Form
    {
        public FrmTrabajador()
        {
            InitializeComponent();
        }

        private void btnGuardar_Trabajador_Click(object sender, EventArgs e)
        {
            Personal trb1 = new Personal();

            if (txtNombre.Text.Length > 3 || txtDireccion.Text.Length > 3 || txtTelefono.Text.Length > 3 || txtEmail.Text.Length > 3)
            {
                trb1.Nombre = txtNombre.Text;
                trb1.Direccion = txtDireccion.Text;
                trb1.Telf = txtTelefono.Text;
                trb1.Email = txtEmail.Text;

                Datos.Personanles.Add(trb1);

                MessageBox.Show("Se agrego correctamente");

            }
            else
            {
                MessageBox.Show("Llene los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
