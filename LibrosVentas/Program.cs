/*Inventario de una Librería
Una librería necesita registrar las ventas de libros por categoría.

El programa debe:
Solicitar la cantidad de libros vendidos en 5 categorías.
Guardar la información en un arreglo.
Mostrar el total de libros vendidos.
Indicar la categoría con más ventas.
Calcular el promedio de ventas.*/


string[] Categoria = new string [5] {"Ficcion", "Romance", "Fantasia", "Misterio", "Aventura"};
int[] Ventas = new int [5];
double TotalVentas = 0;
int mayorVentas=Ventas[0];
double Promedio;
Console.WriteLine("Ingrese la cantidad de libros vendidos por categoría:");
for (int i = 0; i<Categoria.Length; i++)
{
    try
    {
        Console.Write($"Ingrese los libros vendidos de la categoria {Categoria[i]}: ");
        Ventas[i] = int.Parse(Console.ReadLine()!);
        TotalVentas+= Ventas[i];
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--;
    }

}
Console.WriteLine($"El total de libros vendidos es: {TotalVentas}");
for (int i = 0; i<Categoria.Length; i++)
{
    if (mayorVentas < Ventas[i])
    {
        mayorVentas = Ventas[i];
    }
} 
for (int i = 0; i<Categoria.Length; i++)
{
    if (mayorVentas == Ventas[i])
    {
     Console.WriteLine($"La categoria Mas vendida es {Categoria[i]} con un total de: {mayorVentas} de libros vendidos");   
    }
}
Promedio = TotalVentas/Categoria.Length;
Console.WriteLine($"El promedio de ventas es: {Promedio}");