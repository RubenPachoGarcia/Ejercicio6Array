using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Array.Dtos
{
    /// <summary>
    ///Clase que contendra los atributos de los clientes que querremos dar de alta
    /// rpg - 17/01/2024
    /// </summary>
    internal class ClienteDto
    {
        //Atributos
        long idCliente;
        string nombreCliente;
        string apellidosCliente;
        string nombreCompletoCliente;
        int edadCliente;

        //Metodos getters y setters (get-lectura | set-escritura)
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        //Constructor con los atributos necesarios para los clientes
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edadCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCliente + " " + apellidosCliente;
            this.edadCliente = edadCliente;
        }
        //Al definir un constructor con los atributos, hay que definir de manera explicita el
        //constructor vacio generado automaticamente
        public ClienteDto() 
        { 
        }

        //Metodo ToString
        override
        public string ToString()
        {
            string elementoString = "[" + "id:" + this.idCliente +
                " - nombre completo:" + this.nombreCompletoCliente +
                " - edad:" + this.edadCliente + "]";

            return elementoString;
        }
    }
}
