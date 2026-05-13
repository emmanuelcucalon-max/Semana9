/*Notas de Estudiantes
Un profesor necesita almacenar las calificaciones finales de sus estudiantes.

El programa debe:
Solicitar las notas de 8 estudiantes.
Guardar las notas en un arreglo unidimensional.
Mostrar únicamente las notas aprobadas.
Contar cuántos estudiantes reprobaron.
Calcular el promedio general del grupo.*/

double[] notas= new double[8];
double Promedio;
int Reprobados=0;
double Suma=0;

Console.WriteLine("Digite las notas de los 8 estudiantes");
for(int i=0; i<notas.Length; i++)
{
    try
    {
        Console.WriteLine($"Nota del estudiante {i+1}: ");
        notas[i]=double.Parse(Console.ReadLine()!);
        Suma+=notas[i];
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Error de formato, digite en el formato correspondiente");
        Console.ResetColor();
        i--;
    }
    
}
Promedio=Suma/notas.Length;
Console.WriteLine("Las notas aprobadas son de los estudiantes");
for (int i=0; i<notas.Length; i++)
{
    if(notas[i]>=70)
    {
        Console.WriteLine($"El estudiante {i+1} ha aprobado con una nota de {notas[i]}");
    }
    else
    {
        Reprobados++;
    }
}
Console.WriteLine($"Han reprobado un total de {Reprobados} alumnos.");
Console.WriteLine($"El promedio de notas es de {Promedio} puntos");
