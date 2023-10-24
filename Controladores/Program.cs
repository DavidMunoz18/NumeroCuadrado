namespace NumeroCuadrado.Controladores;

class program
{
    static void Main(string[] args)
    {
        MenuInterfaz menu = new MenuImplementacion();
        menu.mostrarMensajeBienvenida();

        bool cerrarMenu = false;
        int opcionIntroducida;
        while(!cerrarMenu)
        {
            int n1;
            int numeroEntero;
            double numeroEntero2;
            opcionIntroducida = menu.mostrarMenuYSeleccion();
            switch (opcionIntroducida)
            {
                case 0:
                    cerrarMenu = true;
                    break;
                case 1:
                    Console.WriteLine("Introduzca un numero entero");
                    numeroEntero = Int32.Parse(Console.ReadLine());
                    numeroEntero2 = Math.Sqrt(numeroEntero);
                    Console.WriteLine(numeroEntero2);
                    n1 = Convert.ToInt32(numeroEntero2);
                    
                    if(n1 * n1 == numeroEntero)
                    {
                     Console.WriteLine("Es un numero entero");
                    }
                    else
                    {
                        Console.WriteLine("No es un numero entero");
                    }

                    break;

                   
            }


                   
                    

                    

            }
        }
    }

