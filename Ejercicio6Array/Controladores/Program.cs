using Ejercicio6Array;
using Ejercicio6Array.Dtos;
using Ejercicio6Array.Servicios;

namespace EjemploArray
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// rpg - 17/01/2024
    /// </summary>
    class Program
    {
        //Metodo principal de la aplicacion
        public static void Main(string[] args)
        {
            //Creamos la lista listaClientes donde se guardaran los datos de los clientes
            //que se den de alta
            List<ClienteDto> listaClientes= new List<ClienteDto>();
            
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            //Variable bool que controla la entrada y salida del menu de la aplicacion
            bool cerrarMenu = false;
            int opcionElegida;

            //Menu que se lanzara y donde el usuario podra ejecutar la opcion que desee
            while (!cerrarMenu)
            {
                opcionElegida = mi.mostrarMenu();
                Console.WriteLine(opcionElegida);

                switch (opcionElegida)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Cerrar menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] -  Se ejecuta la opcion numero 1.");
                        oi.darAltaCliente(listaClientes);
                        foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;

                    case 2:
                        Console.WriteLine("[INFO] -  Se ejecuta la opcion numero 2.");
                        oi.ordenarCliente(listaClientes);
                        break;

                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no existe.");
                        break;
                }
            }
        }
    }
}
