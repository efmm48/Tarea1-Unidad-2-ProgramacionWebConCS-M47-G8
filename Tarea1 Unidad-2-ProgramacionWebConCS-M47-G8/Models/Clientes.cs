using System.Collections.Generic;

namespace Tarea1_Unidad_2_ProgramacionWebConCS_M47_G8.Models
{
    public class Clientes
    {
        private int codigo;
        private string nombre;
        private decimal balance;

        public Clientes()
        {
            
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Balance { get; set; }

    }
}
