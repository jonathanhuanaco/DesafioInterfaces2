using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioInterfaces2
{
    class TorreDeControl
    {
        private List<Volador> voladores = new List<Volador>();
        public void vuelenTodos()
        {
            foreach (Volador item in voladores) item.Volador();
        }
        public void agregarVolador(Volador unvolable)
        {
            voladores.Add(unvolable);
        }
    }
}
