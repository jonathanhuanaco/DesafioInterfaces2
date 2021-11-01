using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class Superman:Volador
    {
        private int experiencia;
        public void Volador()
        {
            Console.WriteLine("Estoy volando como un campeón...");
        }
    }
}
