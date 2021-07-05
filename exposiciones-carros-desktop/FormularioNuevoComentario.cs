using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Logic;

namespace exposiciones_carros_desktop
{
    public partial class FormularioNuevoComentario : Form
    {
        public FormularioNuevoComentario()
        {
            InitializeComponent();
        }

        private Comentarios _Guardar = new Comentarios();
        string mensaje = "";
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtMensaje.Text != "")
            {
                Comentario oMensaje = new Comentario();
                oMensaje.Nombre = txtNombre.Text.Trim();
                oMensaje.Mensaje = txtMensaje.Text.Trim();

                _Guardar.InsertarMensaje(oMensaje, out mensaje);
               MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }else
            {
                MessageBox.Show("Es requerido llenar los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
