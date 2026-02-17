int dias;
double temperatura;
int diasCalurosos = 0;
int diasFrios = 0;
double sumaTemperaturas = 0;

Console.Write("cuantos dias quiere registrar bro: ");
dias = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= dias; i++)
{
    Console.WriteLine("Día " + i);

    do
    {
        Console.Write("Ingrese la temperatura que sea -10 grados y 50 grados: ");
        temperatura = Convert.ToDouble(Console.ReadLine());

        if (temperatura < -10 || temperatura > 50)
        {
            Console.WriteLine("Temperatura inválida. Intente nuevamente.");
        }

    } while (temperatura < -10 || temperatura > 50);

    if (temperatura > 30)
    {
        diasCalurosos++;
    }
    else if (temperatura < 15)
    {
        diasFrios++;
    }

    sumaTemperaturas += temperatura;
    Console.WriteLine();
}

double promedio = sumaTemperaturas / dias;

Console.WriteLine("===== RESULTADOS =====");
Console.WriteLine("Días calurosos (>30): " + diasCalurosos);
Console.WriteLine("Días fríos (<15): " + diasFrios);
Console.WriteLine("Promedio de temperatura: " + promedio);

