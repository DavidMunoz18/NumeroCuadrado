using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroCuadrado
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "NumeroEntero";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("0. cerrar");
            Console.WriteLine("1. ejecutar");
            opcionIntroducida = Console.ReadKey(true).KeyChar - '0';
            return opcionIntroducida;
        }
    }
}
