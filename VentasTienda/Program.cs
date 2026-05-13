/*Ventas de una Tienda
Una tienda desea registrar las ventas diarias de una semana.

El programa debe:
Solicitar al usuario las ventas de cada día.
Guardar las ventas en un arreglo.
Calcular el total vendido.
Mostrar cuántos días las ventas superaron 150.
Indicar la venta más baja registrada.*/

double[] VentasSemana = new double [7];
double Suma=0;
double VentaMasBaja;

Console.WriteLine("Ingrese las ventas del dia");
for(int i=0; i<VentasSemana.Length; i++)
{
    try
    {
        Console.Write($"Digite las ventas del dia{i+1}: ");
        VentasSemana[i]=double.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Formato incorrecto, digitelo nuevamente");
        Console.ResetColor();
        i--;
    }
}
for(int i=0; i<VentasSemana.Length; i++)
{
    Suma+=VentasSemana[i];
}
Console.WriteLine($"Las ventas totales de la tienda es de: {Suma}");
for(int i=0; i<VentasSemana.Length; i++)
{
    if(VentasSemana[i]>=150)
    {
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine($"El dia {i+1} se vendieron {VentasSemana[i]}");
        Console.ResetColor();
    }
    
}
VentaMasBaja=VentasSemana[0];
for(int i=0; i<VentasSemana.Length; i++)
{
    if(VentaMasBaja>VentasSemana[i])
    {
        VentaMasBaja=VentasSemana[i];
    }

}
Console.WriteLine($"La venta mas baja registrada es de: {VentaMasBaja}");
