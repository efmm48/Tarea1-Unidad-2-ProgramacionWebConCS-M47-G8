using Tarea1_Unidad_2_ProgramacionWebConCS_M47_G8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1_Unidad_2_ProgramacionWebConCS_M47_G8.Servicios
{
    public class ClientesServicios
    {
        public Clientes ObtenerCliente()
        {
            return new Clientes()
            {
                Codigo = 1,
                Nombre = "Juan",
                Balance = 200
            };            

        }

        public List<Clientes> obtenerClientes()
        {
            var cliente1 = new Clientes()
            {
                Codigo=1,
                Nombre="Juan",
                Balance=200
            };

            var cliente2 = new Clientes()
            {
                Codigo = 2,
                Nombre = "Pablo",
                Balance = 300
            };

            var cliente3 = new Clientes()
            {
                Codigo = 3,
                Nombre = "Maria",
                Balance = 400
            };

            var cliente4 = new Clientes()
            {
                Codigo = 4,
                Nombre = "Julio",
                Balance = 250
            };

            return new List<Clientes> { cliente1, cliente2, cliente3, cliente4 };
        }

    }
}
