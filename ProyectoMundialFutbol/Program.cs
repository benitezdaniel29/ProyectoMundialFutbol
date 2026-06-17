using System.Reflection.Metadata.Ecma335;

string[] selecciones = new string[20];
int[,] goles = new int[3, 3];

// funcion de elegir opciones en menu
int opcion;
do
{

    Console.Clear();

    Console.WriteLine("===== MENÚ PRINCIPAL =====");
    Console.WriteLine("1. Cargar selecciones");
    Console.WriteLine("2. Mostrar selecciones");
    Console.WriteLine("3. Buscar selección");
    Console.WriteLine("4. Ingresar resultado de partido");
    Console.WriteLine("5. Ver estadísticas de una selección");
    Console.WriteLine("6. Mostrar tabla de posiciones");
    Console.WriteLine("7. Generar torneo aleatorio");
    Console.WriteLine("8. Estadísticas del torneo");
    Console.WriteLine("9. Ejercicio adicional");
    Console.WriteLine("10. Salir");
    Console.Write("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());
    int N = 0;
    switch (opcion)
    {
        case 1:
            N = CargarSelecciones(ref selecciones);

            break;

        case 2:
            MostrarSelecciones(selecciones);
            break;

                case 3:
                   BuscarSeleccion(ref selecciones);
                  break;

               case 4:
                   IngresarResultado(goles ,  selecciones);
                   break;

            //    case 5:
            //        VerEstadisticasSeleccion();
            //        break;

            //    case 6:
            //        MostrarTablaPosiciones();
            //        break;

            //    case 7:
            //        GenerarTorneoAleatorio();
            //        break;

            //    case 8:
            //        EstadisticasTorneo();
            //        break;

            //    case 9:
            //        EjercicioAdicional();
            //        break;

            //    case 10:
            //        Console.WriteLine("Saliendo...");
            //        break;

            //    default:
            //        Console.WriteLine("Opción inválida.");
            //        break;
    }

    if (opcion != 10)
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
} while (opcion != 0);




// funcion de cargar selecciones 
int CargarSelecciones(ref string[] equipos)
{
    Console.Clear();
    Console.WriteLine("===== CARGAR SELECCIONES =====");
    Console.WriteLine("Ingrese la cantidad de selecciones: ");
    int cantidad;
    cantidad = int.Parse(Console.ReadLine());

    for (int i = 0; i < cantidad; i++)
    {
        Console.Write($"Ingrese el nombre de la selección {i + 1}: ");
        equipos[i] = Console.ReadLine();
    }
    int posicion = 1;
    Console.WriteLine("==== SELECCIONES CARGADAS ====");
    for (int i = 0; i < cantidad; i++)
    {
        posicion = i + 1;
        Console.WriteLine($"{posicion}) {equipos[i]}");

    }
    return cantidad;
}
// aqui recibimos el resultado de la funcion cargar selecciones para usarlo en otras funciones


// funcion para mostrar selecciones convocadas
void MostrarSelecciones(string[] equipos)
{
    Console.Clear();
    Console.WriteLine("===== mostrar selecciones =====");
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"{i + 1}) {equipos[i]}");
    }

}


void BuscarSeleccion(ref string[] equipos)
{
    Console.Clear();
    Console.WriteLine("==== BUSCAR SELECCION ====");
    Console.WriteLine("Ingrese el nombre de la selección a buscar: ");
    string buscar = Console.ReadLine();
    for (int i = 0; i < equipos.Length; i++)
    {
        if (equipos[i] == buscar)
        {
            Console.WriteLine($" La selección : //{buscar}// se encuentra en la posición => {i + 1}");
            return;
        }  
    }
     Console.WriteLine("Seleccion no encontrada VERIFIQUE QUE HAYA ESCRITO BIEN");
   
}

void IngresarResultado(int[,] goles , string[] paises)
{
    Console.Clear();
    Random rnd = new Random();
    Console.WriteLine("==== HACER JUGAR EQUIPOS ====");
    Console.WriteLine("Necesita ingresar 2 paises para jugar");
    Console.WriteLine("Ingrese el nombre del PRIMER equipo :");
    string equipo1 = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre del SEGUNDO equipo :");
    string equipo2 = Console.ReadLine();
    int i = Array.IndexOf(paises, equipo1);
    int j = Array.IndexOf(paises, equipo2);

    if (i == -1 || j == -1)
    {
        Console.WriteLine("Uno o ambos equipos no existen.");
        return;
    }
    // hola cambios git
   // hola prueba git

    if (i == j)
    {
        Console.WriteLine("Un equipo no puede jugar contra sí mismo.");
        return;
    }

    goles[i, j] = rnd.Next(0, 6);
    goles[j, i] = rnd.Next(0, 6);
    Console.WriteLine();
    Console.WriteLine($"{equipo1} {goles[i, j]} - {goles[j, i]} {equipo2}");
}


for (int i = 0; i < goles.GetLength(0); i++)
    {
        for (int j = 0; j < goles.GetLength(1); j++)
        {
            Console.WriteLine($"El resultado del partido es : {goles[i, j]}");
        }
    }