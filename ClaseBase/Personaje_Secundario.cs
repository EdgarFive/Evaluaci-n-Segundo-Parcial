using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public string Compleccion {get; set;}
        public string Color_cabello { get; set; }
        public int salud {get; set;}
        public int Velocidad {get; set;}
        public int Dano { get; set;}

        //Encapsulamiento ======================================
        private double Altura { get; set; }
        
        public double _Altura
        {
            get { return _Altura; }
            set { Altura = value; }
        }

        //POLIMORFISMO ESTÁTICO ===========================
        public virtual void Avanzar(int _adelante)
        {
            Console.WriteLine($"Personaje Caminando...");
        }
        public virtual void Avanzar(int _adelante, int _velocidad)
        {
            Console.WriteLine($"Personaje Corriendo...");
        }


        //Solo para poder probar como funcionan el encapsulamiento ============
        public virtual void Mostrarinfo()
        {
            Console.WriteLine($"Altura: {Altura}");
        }
        //======================================================================

    }
}
