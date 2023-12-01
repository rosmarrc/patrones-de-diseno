using EjemploFactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaAlcoholica obebida = Creador.CreadorBebida(Creador.PRESIDENTE);
            Console.WriteLine(obebida.NivelDeAlcohol());
        }

    }
}

