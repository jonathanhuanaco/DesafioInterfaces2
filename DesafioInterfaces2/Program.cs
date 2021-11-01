using System;

namespace DesafioInterfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Superman superman = new Superman();
            Boing747 boing747 = new Boing747();
            TorreDeControl torreDeControl = new TorreDeControl();
            torreDeControl.agregarVolador(pato);
            torreDeControl.agregarVolador(superman);
            torreDeControl.agregarVolador(boing747);
            torreDeControl.vuelenTodos();
            Console.Read();
        }
    }
}
