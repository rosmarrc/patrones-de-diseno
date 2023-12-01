using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFactoryMethod
{
    public class Creador
    {
        public const int ROMO_BRUGAL = 1;
        public const int PRESIDENTE = 2;

        public static BebidaAlcoholica CreadorBebida(int tipo)
        {
            switch(tipo)
            {
                case ROMO_BRUGAL:
                    return new RomoBrugal();
                case PRESIDENTE:
                    return new Presidente();
                default: return null;
            }
        }

    }
}
