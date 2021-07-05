using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comentario
    {
        private int _Id;
        private string _Nombre;
        private string _Mensaje;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { _Mensaje = value; }
        }

        public Comentario()
        {
            _Id = Id;
            _Nombre = Nombre;
            _Mensaje = Mensaje;
        }


    }
}
