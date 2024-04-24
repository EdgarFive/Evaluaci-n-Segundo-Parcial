using Evaluación_Segundo_Parcial.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Segundo_Parcial.ClaseHijas
{
    internal class Personaje_Curacion : Personaje_Secundario
    {
        public int Cantidad_Curacion {  get; set; }
        public int mana {  get; set; }


        //POLIMORFISMO DINAMICO =====================================
        public override void Avanzar(int _adelante)
        {
            Console.WriteLine($"Mia Caminando...");
        }
        public override void Avanzar(int _adelante, int _velocidad)
        {
            Console.WriteLine($"Mia Corriendo...");
        }

    }
}
