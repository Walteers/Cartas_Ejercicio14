using Cartas_Ejercicio14.Moldes;

Baraja baraja = new Baraja();
bool continuar = true;
string respuesta;
do
{
    Console.WriteLine("Elija una de las siguientes opciones.");
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del montón");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");
    respuesta = Console.ReadLine();

    switch (respuesta)
    {
        case "1":
            baraja.Barajar();
            Display.MostrarContinuar();
            break;
        case "2":
            Console.WriteLine("Carta siguiente:");
            baraja.SiguienteCarta();
            Display.MostrarContinuar();
            Console.Clear();
            break;
        case "3":
            baraja.CartasDisponibles();
            Display.MostrarContinuar();
            Console.Clear();
            break;
        case "4":
            Console.WriteLine("¿Cuantas cartas quiere ver?");
            string opcion = Console.ReadLine();
            if (Verificar.VerificarNumero(opcion, baraja.CartasDisponiblesEnBaraja(baraja.BarajaDeCartas))) baraja.DarCartas(int.Parse(opcion));
            Display.MostrarContinuar();
            Console.Clear();
            break;
        case "5":
            baraja.CartasMonton();
            Display.MostrarContinuar();
            Console.Clear();
            break;
        case "6":
            baraja.MostrarBaraja();
            Display.MostrarContinuar();
            Console.Clear();
            break;
        case "7":
            continuar = false;
            break;
        default:
            Console.WriteLine("A ingresado una opción inválida.");
            Display.MostrarContinuar();
            Console.Clear();
            break;
    }

} while (continuar);