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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno alum1 = new Alumno();

            if (txtNombre.Text.Length > 3 || txtDireccion.Text.Length > 3 || txtTelefono.Text.Length > 3 || txtEmail.Text.Length > 3)
            {
                alum1.Nombre = txtNombre.Text;
                alum1.Direccion = txtDireccion.Text;
                alum1.Telf = txtTelefono.Text;
                alum1.Email = txtEmail.Text;

                Datos.Alumnos.Add(alum1);

                MessageBox.Show("Se agrego al alumno correctamente");

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
