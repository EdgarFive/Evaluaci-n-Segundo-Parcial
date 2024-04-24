using Evaluación_Segundo_Parcial.ClaseBase;
using Evaluación_Segundo_Parcial.ClaseBase_Enemigos;
using Evaluación_Segundo_Parcial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Segundo_Parcial.ClaseHijas_Enemigos
{
    internal class Goblin__EnemigoGenerico : Enemigo_Generico, IGuerrero
    {
        //Dato extra de la clase secundaria de enemigo Goblin =============
        public string Arma = "Daga";

        //Condiciones de la interfaz ======================================
        public void Atacar()
        {
            Console.WriteLine($"El Goblin ataca...");
        }
        public void Defenderse()
        {
            Console.WriteLine($"El Goblin se está defendiendo...");
        }
    }
}
