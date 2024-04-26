
using Evaluación_Segundo_Parcial.ClaseBase;
using Evaluación_Segundo_Parcial.ClaseHijas;
using Evaluación_Segundo_Parcial.Eventos;
using System.Runtime.InteropServices.Marshalling;

//Evaluación Segundo Parcial Edgar Chinchilla ==================================================


//==============================================================================================
//AREA DE FUNCIONES ============================================================================
//==============================================================================================




    Personaje_Curacion ccpersonaje_curacion = new Personaje_Curacion();

    //Herencia =================================================
    ccpersonaje_curacion.Hombre_Mujer = "Mujer";
    ccpersonaje_curacion.Nombre = "Mia";
    ccpersonaje_curacion.Compleccion = "Delgada";
    ccpersonaje_curacion.Color_cabello = "Cian";
    ccpersonaje_curacion.Arma = "Báculo";
    ccpersonaje_curacion.salud = 50;
    ccpersonaje_curacion.Velocidad = 10;
    ccpersonaje_curacion.Dano = 50;
    ccpersonaje_curacion._Altura = 4;

    //Personal =================================================
    ccpersonaje_curacion.Cantidad_Curacion = 10;
    ccpersonaje_curacion.mana = 20;


    //INDEXADORES ==============================================
    ccpersonaje_curacion[0] = "Báculo";
    ccpersonaje_curacion[1] = "Daga";
    ccpersonaje_curacion[2] = "Escudo";





    Personaje_Fuerza ccpersonaje_fuerza = new Personaje_Fuerza();

    //Herencia =================================================
    ccpersonaje_fuerza.Hombre_Mujer = "Hombre";
    ccpersonaje_fuerza.Nombre = "Garet";
    ccpersonaje_fuerza.Compleccion = "Robusto";
    ccpersonaje_fuerza.Color_cabello = "PeliRojo";
    ccpersonaje_fuerza.Arma = "Espada";
    ccpersonaje_fuerza.salud = 50;
    ccpersonaje_fuerza.Velocidad = 6;
    ccpersonaje_fuerza.Dano = 60;
    ccpersonaje_fuerza._Altura = 190;


    //Personal =================================================
    ccpersonaje_fuerza.Cantidad_Fuerza = 20;




    Personaje_Magia ccpersonaje_magia = new Personaje_Magia();

    //Herencia =================================================
    ccpersonaje_magia.Hombre_Mujer = "Hombre";
    ccpersonaje_magia.Nombre = "Ivan";
    ccpersonaje_magia.Compleccion = "Delgado";
    ccpersonaje_magia.Color_cabello = "Rubio";
    ccpersonaje_magia.Arma = "Báculo";
    ccpersonaje_magia.salud = 50;
    ccpersonaje_magia.Velocidad = 10;
    ccpersonaje_magia.Dano = 50;
    ccpersonaje_magia._Altura = 169;


    //Personal =================================================
    ccpersonaje_magia.Cantidad_Magia = 10;
    ccpersonaje_magia.cantidad_mana = 20;



static void ffGenerar_Ecenario()
{
    EditorBatallas eeEvento_inicio = new EditorBatallas();
    Esenario Generar_esenario = new Esenario();
    eeEvento_inicio.EE_Evento_Batalla += Generar_esenario.Generar_terreno;
    eeEvento_inicio.EE_Evento_Batalla += Generar_esenario.Generar_interfaz;
    eeEvento_inicio.EE_Evento_Batalla += Generar_esenario.Generar_Personajes;

    eeEvento_inicio.Se_inicia_batalla(true);
}


/*
static void ffpersonaje_secundario()
{
    Personaje_Secundario ccpersonajesecundario = new Personaje_Secundario();   
    
}
*/

//==============================================================================================
//AREA DE DEFINICIONES =========================================================================
//==============================================================================================



//==============================================================================================
//INICIO DEL PROGRAMA ==========================================================================
//==============================================================================================
for (int ii = 0; ii != -1;)
{
    try
    {
        Console.Clear();
        Console.WriteLine($"Bienvenido al codigo de la Segunda evaluación de programación I.\nElija una opción:\n1. Abstracción.\n2. Herencia\n3. Polimorfismo\n4. Encapsulación\n5. Interfaces.\n6. Delegados\n7. Eventos.\n8. Indexadores\n9. Propiedades\n-1. Salir.");
        int eemenu = int.Parse(Console.ReadLine());
        switch (eemenu)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"ABSTRACCIÓN.");
                Console.WriteLine($"Ver código en Clase padre.");
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine($"HERENCIA.");
                ccpersonaje_curacion.Se_Mostrardatos();
                Console.WriteLine($"====================================================================================================");
                ccpersonaje_fuerza.Se_Mostrardatos();
                Console.WriteLine($"====================================================================================================");
                ccpersonaje_magia.Se_Mostrardatos();
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine($"POLIMORFISMO.");
                Console.WriteLine($"Elije un personaje:\n1. Mia.\n2. Gater.\n3. Ivan.");
                eemenu = int.Parse(Console.ReadLine());
                switch (eemenu)
                {
                    case 1:
                        Console.WriteLine($"Elije una opción:\n1. Caminar.\n2. Correr.");
                        eemenu = int.Parse(Console.ReadLine());
                        switch (eemenu)
                        {
                            case 1:
                                ccpersonaje_curacion.Avanzar(1);
                                break;
                            case 2:
                                ccpersonaje_curacion.Avanzar(1,1);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Elije una opción:\n1. Caminar.\n2. Correr.");
                        eemenu = int.Parse(Console.ReadLine());
                        switch (eemenu)
                        {
                            case 1:
                                ccpersonaje_fuerza.Avanzar(1);
                                break;
                            case 2:
                                ccpersonaje_fuerza.Avanzar(1, 1);
                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine($"Elije una opción:\n1. Caminar.\n2. Correr.");
                        eemenu = int.Parse(Console.ReadLine());
                        switch (eemenu)
                        {
                            case 1:
                                ccpersonaje_magia.Avanzar(1);
                                break;
                            case 2:
                                ccpersonaje_magia.Avanzar(1, 1);
                                break;
                        }
                        break;
                }
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine($"ENCAPSULACIÓN.");
                Console.WriteLine($"Mira el código en la Clase Padre.");
                Console.ReadKey();
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case -1:
                ii = -1;
                break;
            default:
                Console.Clear();
                Console.WriteLine($"Los parámetros ingresados no son validos; Inténtelo de nuevo.");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception eerror)
    {
        Console.Clear();
        Console.WriteLine($"Ah ocurrido un error en el ingreso de datos; Error: \"{eerror}\"");
        Console.ReadKey();
    }
}

Console.WriteLine($"");

ffGenerar_Ecenario();


Console.ReadKey();


//==============================================================================================
//FIN DEL PROGRAMA =============================================================================
//==============================================================================================

// Imprimir las armas del personaje utilizando el indexador ===============================


/*Console.WriteLine("Armas del personaje:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i + 1}. {ccpersonaje_curacion[i]}");
}*/
