using Ejercicio6Array.Dtos;
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
    internal class OperativaImplementacion : OperativaInterfaz
    {
        //Metodo por el cual se guarda el cliente creado en la lista listaCliente2
        public void darAltaCliente(List<ClienteDto> listaCliente2)
        {
            ClienteDto cliente = crearCliente();
            listaCliente2.Add(cliente);
        }
        /// <summary>
        ///Metodo que permite introducir los valores de los atributos para poder crear
        ///a los clientes
        /// rpg - 17/01/2024
        /// </summary>
        private ClienteDto crearCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la edad: ");
            nuevoCliente.EdadCliente = Convert.ToInt32(Console.ReadLine());

            return nuevoCliente;
        }
        //Metodo por el cual los clientes guardados en la lista se muestren por pantalla ordenados 
        //por el valor de su edad de manera descendente
        public void ordenarCliente(List<ClienteDto> listaClientes2)
        {
            if (listaClientes2.Count < 3)
            {
                Console.WriteLine("Deben de haber minimo 3 clientes registrados. ");
            }
            else
            {
                for (int i = 0; i < listaClientes2.Count - 1; i++)
                {
                    for (int j = 0; j < listaClientes2.Count - 1 - i; j++)
                    {
                        if (listaClientes2[j].EdadCliente < listaClientes2[j + 1].EdadCliente)
                        {
                            ClienteDto aux = listaClientes2[j];
                            listaClientes2[j] = listaClientes2[j + 1];
                            listaClientes2[j + 1] = aux;
                        }
                    }
                }

                Console.WriteLine("Lista de clientes ordenada por edad de manera descendente: ");
                foreach (ClienteDto cliente in listaClientes2)
                {
                    Console.WriteLine(cliente.ToString());
                }
            }
        }
    }
}
