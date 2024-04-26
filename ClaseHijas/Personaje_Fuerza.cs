using Evaluación_Segundo_Parcial.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Segundo_Parcial.ClaseHijas
{
    internal class Personaje_Fuerza : Personaje_Secundario
    {
        public int Cantidad_Fuerza { get; set; }


        //POLIMORFISMO DINAMICO =====================================
        public override void Avanzar(int _adelante)
        {
            Console.WriteLine($"Garet Caminando...");
        }
        public override void Avanzar(int _adelante, int _velocidad)
        {
            Console.WriteLine($"Garet Corriendo...");
        }
        public void Se_Mostrardatos()
        {
            Console.WriteLine($"\nPersonaje Fuerza.");
            Console.WriteLine($"\nHerencia =============================");
            Mostrarinfo();
            Console.WriteLine($"\nPersonales =============================");
            Console.WriteLine($"Fuerza: {Cantidad_Fuerza}");
        }

    }
}
