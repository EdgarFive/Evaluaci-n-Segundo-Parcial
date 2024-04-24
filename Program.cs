
using Evaluación_Segundo_Parcial.ClaseBase;
using Evaluación_Segundo_Parcial.ClaseHijas;

//Evaluación Segundo Parcial Edgar Chinchilla ==================================================


//==============================================================================================
//AREA DE FUNCIONES ============================================================================
//==============================================================================================


static void ffpersonaje_curacion()
{
    Personaje_Curacion ccpersonaje_curacion = new Personaje_Curacion();

    //Herencia =================================================
    ccpersonaje_curacion.Hombre_Mujer = "Mujer";
    ccpersonaje_curacion.Nombre = "Mia";
    ccpersonaje_curacion.Altura = 175;
    ccpersonaje_curacion.Compleccion = "Delgada";
    ccpersonaje_curacion.Color_cabello = "Cian";
    ccpersonaje_curacion.salud = 50;
    ccpersonaje_curacion.Velocidad = 10;
    ccpersonaje_curacion.Dano = 50;

    //Personal =================================================
    ccpersonaje_curacion.Cantidad_Curacion = 10;
    ccpersonaje_curacion.mana = 20;
}

static void ffpersonaje_fuerza()
{
    Personaje_Fuerza ccpersonaje_fuerza = new Personaje_Fuerza();

    //Herencia =================================================
    ccpersonaje_fuerza.Hombre_Mujer = "Hombre";
    ccpersonaje_fuerza.Nombre = "Garet";
    ccpersonaje_fuerza.Altura = 190;
    ccpersonaje_fuerza.Compleccion = "Robusto";
    ccpersonaje_fuerza.Color_cabello = "PeliRojo";
    ccpersonaje_fuerza.salud = 50;
    ccpersonaje_fuerza.Velocidad = 6;
    ccpersonaje_fuerza.Dano = 60;

    //Personal =================================================
    ccpersonaje_fuerza.Cantidad_Fuerza = 20;
}

static void ffpersonaje_megia()
{
    Personaje_Magia ccpersonaje_magia = new Personaje_Magia();

    //Herencia =================================================
    ccpersonaje_magia.Hombre_Mujer = "Hombre";
    ccpersonaje_magia.Nombre = "Ivan";
    ccpersonaje_magia.Altura = 169;
    ccpersonaje_magia.Compleccion = "Delgado";
    ccpersonaje_magia.Color_cabello = "Rubio";
    ccpersonaje_magia.salud = 50;
    ccpersonaje_magia.Velocidad = 10;
    ccpersonaje_magia.Dano = 50;

    //Personal =================================================
    ccpersonaje_magia.Cantidad_Magia = 10;
    ccpersonaje_magia.cantidad_mana = 20;
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



//==============================================================================================
//FIN DEL PROGRAMA =============================================================================
//==============================================================================================