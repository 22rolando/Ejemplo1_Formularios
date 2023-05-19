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
    public partial class FmrProfesor : Form
    {
        public FmrProfesor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Profesor_Click(object sender, EventArgs e)
        {
            Profesor prof1 = new Profesor();

            if(txtNombre.Text.Length > 3 || txtDireccion.Text.Length > 3 || txtTelefono.Text.Length > 3 || txtEmail.Text.Length > 3)
            {
                prof1.Nombre = txtNombre.Text;
                prof1.Direccion = txtDireccion.Text;
                prof1.Telf = txtTelefono.Text;
                prof1.Email = txtEmail.Text;

                Datos.Profesores.Add(prof1);

                MessageBox.Show("Se agredo correctamente");
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
