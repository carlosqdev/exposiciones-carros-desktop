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
    public partial class FormularioExposicion : Form
    {
        public FormularioExposicion()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            FormularioNuevoComentario formulario = new FormularioNuevoComentario();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioNuevoComentario formulario = new FormularioNuevoComentario();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormularioNuevoComentario formulario = new FormularioNuevoComentario();
            formulario.Show();
        }
    }
}
