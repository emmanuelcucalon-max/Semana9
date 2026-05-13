/*Temperaturas de la Semana
Una estación meteorológica necesita registrar las temperaturas máximas de 7 días.

El programa debe:
Solicitar al usuario las 7 temperaturas.
Guardar los datos en un arreglo unidimensional.
Mostrar todas las temperaturas registradas.
Calcular el promedio semanal.
Indicar la temperatura más alta y la más baja.*/

using System.Timers;

double[] TemperaturaSemana = new double [7];
double SumaTemperaturas=0;
double Promedio;
Console.WriteLine("Digite la temperatura del dia");
for(int i=0;i<TemperaturaSemana.Length;i++)
{
    try
    {
        Console.Write($"dia {i+1}: ");
        TemperaturaSemana[i]=double.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.WriteLine("Ingrese una temperatura en formato valido");
        i--;
    }
}
Console.WriteLine("Las temperaturas de los 7 dias son: ");
for(int i=0;i<TemperaturaSemana.Length;i++)
{
    Console.WriteLine($"Dia {i+1} = {TemperaturaSemana[i]}C");
}
for(int i=0;i<TemperaturaSemana.Length;i++)
{
    SumaTemperaturas+=TemperaturaSemana[i];
}

Promedio=SumaTemperaturas/7;

Console.WriteLine($"El promedio de su temperatura es de: {Promedio}");