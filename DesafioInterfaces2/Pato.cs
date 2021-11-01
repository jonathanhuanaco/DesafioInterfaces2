using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class Pato : Volador
    {
        private int energia;
        public void Volador()
        {
            Console.WriteLine("Estoy volando como un pato...¡cuak!");
        }
    }
}
