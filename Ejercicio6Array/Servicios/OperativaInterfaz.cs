using Ejercicio6Array.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Array.Servicios
{
    /// <summary>
    /// Contiene los metodos para trabajar con los clientes (añadir y ordenar)
    /// rpg - 4/12/2023
    /// </summary>
    internal interface OperativaInterfaz
    {
        //Metodo por el cual se guarda el cliente creado en la lista listaCliente2
        public void darAltaCliente(List<ClienteDto> listaClientes2);
        //Metodo por el cual los clientes guardados en la lista se muestren por pantalla ordenados 
        //por el valor de su edad de manera descendente
        public void ordenarCliente(List<ClienteDto> listaClientes2);

    }
}
