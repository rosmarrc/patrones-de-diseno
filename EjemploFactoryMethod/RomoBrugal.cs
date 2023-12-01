using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFactoryMethod
{
    class RomoBrugal : BebidaAlcoholica
    {
        public override int NivelDeAlcohol()
        {
            return 35;
        }
    }
}
