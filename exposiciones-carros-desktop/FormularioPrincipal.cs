using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exposiciones_carros_desktop
{
    public partial class formularioPrincipal : Form
    {
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        private void comentariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioNuevoComentario formulario = new FormularioNuevoComentario();
            formulario.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioTodosLosComentarios formulario = new FormularioTodosLosComentarios();
            formulario.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioExposicion formulario = new FormularioExposicion();
            formulario.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAutor formulario = new FormularioAutor();
            formulario.Show();
        }
    }
}
