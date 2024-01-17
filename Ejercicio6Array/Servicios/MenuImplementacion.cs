using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Array.Servicios
{
    /// <summary>
    /// Clase que implementa las interfaces de menu
    /// rpg - 17/01/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        //Metodo que mostrara el menu en el que el usuario eleigira la opcion que desee
        public int mostrarMenu()
        {
            int opcionIntroducida;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0. Cerra aplicacion");
            Console.WriteLine("1. Dar de alta a nuevo cliente");
            Console.WriteLine("2. Ordenar lista de clientes");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
    }
}
