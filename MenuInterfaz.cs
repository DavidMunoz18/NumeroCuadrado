using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroCuadrado
{
    /// <summary>
    /// Contiene las cabeceras de los metodos
    /// 241023 - dmp
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida de la aplicación
        /// 241023 - dmp
        /// </summary>
        void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menu y selecciona la opcion
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
