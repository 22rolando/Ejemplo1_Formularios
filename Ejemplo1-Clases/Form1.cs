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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro vent1 = new FrmCentro();

            vent1.ShowDialog();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCentros cent1 = new ListarCentros();

            cent1.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrProfesor prof1 = new FmrProfesor();

            prof1.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListProfesores prof1 = new FrmListProfesores();

            prof1.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstudiante est1 = new FrmEstudiante();

            est1.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarEstudiante est1 = new FrmListarEstudiante();

            est1.ShowDialog();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmTrabajador trb1 = new FrmTrabajador();

            trb1.ShowDialog();
        }

        private void listaDeTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarTrabajadores trab1 = new frmListarTrabajadores();

            trab1.ShowDialog();
        }
    }
}
