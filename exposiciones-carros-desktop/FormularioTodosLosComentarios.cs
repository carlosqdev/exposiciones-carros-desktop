using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Entities;

namespace exposiciones_carros_desktop
{
    public partial class FormularioTodosLosComentarios : Form
    {
        private Comentarios _Comentarios = new Comentarios();
        string mensaje = "";
        public FormularioTodosLosComentarios()
        {
            InitializeComponent();
        }

        private void CargarComentarios()
        {
            try
            {
                List<Comentario> _listaComentarios = _Comentarios.ListaDeComentarios(out mensaje);
                dtgMensajes.DataSource = _listaComentarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormularioTodosLosComentarios_Load(object sender, EventArgs e)
        {
            CargarComentarios();
            dtgMensajes.Columns["Id"].Visible = false;
        }
    }
}
