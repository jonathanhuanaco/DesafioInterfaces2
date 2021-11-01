using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class Boing747 : Volador
    {
        private int horas;
        public void Volador()
        {
            Console.WriteLine("Estoy volando como un avion...");
        }
    }
}
