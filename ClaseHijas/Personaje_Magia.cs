using Evaluación_Segundo_Parcial.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Segundo_Parcial.ClaseHijas
{
    internal class Personaje_Magia : Personaje_Secundario
    {
        public int Cantidad_Magia { get; set; }
        public int cantidad_mana { get; set; }


        //POLIMORFISMO DINAMICO =====================================
        public override void Avanzar(int _adelante)
        {
            Console.WriteLine($"Ivan Caminando...");
        }
        public override void Avanzar(int _adelante, int _velocidad)
        {
            Console.WriteLine($"Ivan Corriendo...");
        }
    }
}
