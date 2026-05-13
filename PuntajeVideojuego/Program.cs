/*Puntajes de un Videojuego
Un jugador desea almacenar los puntajes obtenidos en diferentes partidas.

El programa debe:
Pedir al usuario ingresar 6 puntajes.
Guardar los datos en un arreglo unidimensional.
Mostrar el puntaje más alto.
Ordenar los puntajes de menor a mayor.
Contar cuántos puntajes son mayores a 500.*/

int[] puntajes = new int[6];
int PuntajeMayor=0;
int Superior500=0;
Console.WriteLine("Ingrese los puntajes obtenidos en las partidas");
for (int i=0; i<puntajes.Length; i++)
{
    try
    {
        Console.WriteLine($"Puntaje {i+1}: ");
        puntajes[i]=int.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Formato incorrecto, Digite el puntaje con numeros enteros");
        Console.ResetColor();
        i--;
    }
}
for (int i=0; i<puntajes.Length; i++)
{
    if(PuntajeMayor<puntajes[i])
    {
        PuntajeMayor=puntajes[i];
    }
}
Console.WriteLine($"El puntaje mas alto es: {PuntajeMayor}");
for (int i=0; i<puntajes.Length; i++)
{
    if(puntajes[i]>500)
    {
        Superior500++;
    }
}
Console.WriteLine($"La cantidad de puntajes mayores a 500 es: {Superior500}");
for (int i=0; i<puntajes.Length; i++)
{
    for (int j=0; j<puntajes.Length-1; j++)
    {
        if(puntajes[j]>puntajes[j+1])
        {
            int aux=puntajes[j];
            puntajes[j]=puntajes[j+1];
            puntajes[j+1]=aux;
        }
    }
}
Console.WriteLine("Los puntajes ordenados de menor a mayor son: ");
for (int i=0; i<puntajes.Length; i++)
{
    Console.WriteLine(puntajes[i]);
}