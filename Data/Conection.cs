using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conection
    {
        static string _CadenaConexion = @"Data Source=localhost;Initial Catalog=comentarios; User ID=udem;Password=udem123";

        public static string CadenaConexion
        {
            get { return _CadenaConexion; }
        }
    }
}
