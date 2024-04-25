using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_Segundo_Parcial.Eventos
{
    //==========================================================================================
    //EDITOR ===================================================================================
    //==========================================================================================
    public delegate void DDelegadoBatalla(object sender, EventArgs datos); //Generamos delegado para evento ====

    //==========================================================================================  EVENTO
    public class EditorBatallas //Creamos clase del evento ====
    {
        public event DDelegadoBatalla EE_Evento_Batalla; //Generamos el evento
        
        public void Se_inicia_batalla(bool boole) //Metodo para corroborar si se va a iniciar una batalla ========
        {
            if (boole)
            {
                Batalla_Iniciada();
            }
            else
            {
                Console.WriteLine($"No se pudo iniciar la batalla.");
            }
        }
        public virtual void Batalla_Iniciada() //Metodo donde se implementa el evento =============
        {
            EE_Evento_Batalla?.Invoke(this, EventArgs.Empty);

        }
    }
    //========================================================================================== SUSCRIPTORES

    public class Esenario()
    {
        public void Generar_terreno(object sender, EventArgs datos)
        {
            Console.WriteLine($"Se genera el terreno con: Tierra, pasto y arboles.");
        }

        public void Generar_interfaz(object sender, EventArgs datos)
        {
            Console.WriteLine($"Se genera la interfaz con: Poderes, barra de vida y puntuación.");
        }

        public void Generar_Personajes(object sender, EventArgs datos)
        {
            Console.WriteLine($"Se generan los personajes: Personajes y enemigos.");
        }
    }
}
