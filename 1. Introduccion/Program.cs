// using System.Security.Cryptography.X509Certificates;

int[] retiros = new int[10]; //Arreglo para almacenar los retiros 

Console.WriteLine("\t ------------Bienvenido al banco ------------");
while (true)
{
    Console.Write("Por favor seleccione una opcion: \n");
    Console.WriteLine("\t 1. Ingresar la cantidad de retiros hechos por los usuarios");
    Console.WriteLine("\t 2. Revisar la cantidad entregada de billetes y monedas");
    Console.WriteLine("\n Ingresa la opcion: ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            IngresarRetiros(retiros);
            break;
        case 2:
            RevisarBilletesYMonedas(retiros);
            break;
        default:
            Console.Write("Opción inválida. Por favor, seleccione 1 o 2. \n");
            break;
    }
}

static void IngresarRetiros(int[] retiros)
{
    Console.WriteLine("Ingrese la cantidad de retiros (máximo 10): ");
    int num_retiros = int.Parse(Console.ReadLine());

    /* Validamos que el numero de residuos sea entre 1 a 10 */
    if (num_retiros < 1 || num_retiros > 10)
    {
        Console.Write("La cantidad de retiros debe ser entre 1 a 10 \n");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadLine();
    }
    else
    {
        for (int i = 0; i < num_retiros; i++)
        {
            Console.Write($"Ingrese la cantidad de dinero para el retiro {i + 1} debe ser entre 1 y 50000: \n");
            int cantidadDinero = int.Parse(Console.ReadLine());
            if (cantidadDinero < 1 || cantidadDinero > 50000)
            {
                Console.WriteLine("La cantidad de dinero debe estar entre 1 y 50,000");
                i--; //Se resta una posicion al contador ya que no se cumple
                continue;
            }
            retiros[i] = cantidadDinero; //Guardamos la cantidad de dinero retirado en el arreglo de retiros
        }
        Console.WriteLine("\t Retiros ingresados correctamente \n");

        Console.WriteLine("\n Presiona 'enter' para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
}

static void RevisarBilletesYMonedas(int[] retiros)
{
    for (int i = 0; i < retiros.Length; i++)
    {
        int retiro = retiros[i];

        // Vericamos si encontramos un retiro no ingresado 
        if (retiro == 0)
        {
            break;
        }

        int[] billetes = { 500, 200, 100, 50, 20 };
        int[] monedas = { 10, 5, 1 };

        int cantidadRestante = retiro;
        int totalBilletes = 0;
        int totalMonedas = 0;

        Console.Write("----------------------------------------");
        Console.WriteLine($"\nRetiro #{i + 1}: ");

        Console.WriteLine("En total se usaron: ");
        // Se muestra cuantos billetes se usaron de cada uno
        foreach (int billete in billetes)
        {
            int cantidadBilletes = cantidadRestante / billete;
            cantidadRestante %= billete;
            if (cantidadBilletes > 0)
            {
                Console.WriteLine($"\t Billetes de ${billete}: {cantidadBilletes}");
                totalBilletes += cantidadBilletes;
            }
        }

        foreach (int moneda in monedas)
        {
            int cantidadMondas = cantidadRestante / moneda;
            cantidadRestante %= moneda;
            if (cantidadMondas > 0)
            {
                Console.WriteLine($"\t Monedas de ${moneda}: {cantidadMondas}");
                totalMonedas += cantidadMondas;
            }
        }

        Console.WriteLine($"Cantidad de dinero: {retiro} \n");
        Console.WriteLine($"Total de billetes entregados: {totalBilletes}");
        Console.WriteLine($"Total de monedas entregadas: {totalMonedas}");
    }

    Console.WriteLine("\n Presiona 'enter' para continuar...");
    Console.ReadLine();
    Console.Clear();
}