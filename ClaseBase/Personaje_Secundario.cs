using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Segundo_Parcial.ClaseBase
{
    internal class Personaje_Secundario
    {
        //Abstracción =========================================
        public string Hombre_Mujer { get; set; }
        public string Nombre {get; set;}
        public double Altura {get; set;}
        public string Compleccion {get; set;}
        public string Color_cabello { get; set; }
        public int salud {get; set;}
        public int Velocidad {get; set;}
        public int Dano { get; set;}

    }
}
