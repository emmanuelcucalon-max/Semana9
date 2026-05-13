double[,] matriz = new double [3,3];

Console.WriteLine("Matrices");
Console.WriteLine("Ingresa las temperaturas en la matriz");
int count=1;
for(int r=0; r<3; r++)
{
    for(int c=0;c<3;c++)
    {
        try
        {
            Console.WriteLine($"Dime la temperatura: #{count++}");
            matriz[r,c]=Convert.ToDouble(Console.ReadLine()!);
        }
        catch(FormatException)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Formato de entrada incorrecto, Ingrese numeros enteros");
            Console.ResetColor();
            c--;
            count--;
        }
        
    }
}
Console.Clear();
Console.WriteLine("Temperaturas registradas");
for(int f=0; f<3; f++)
{
    for(int c=0;c<3;c++)
    {
        if(matriz[f,c]>=40) Console.ForegroundColor=ConsoleColor.Red;
        else if (matriz[f,c]>=35) Console.ForegroundColor=ConsoleColor.Yellow;
        else Console.ForegroundColor=ConsoleColor.Green;

        Console.Write($"{matriz[f,c]} ");
        Console.ResetColor();
        
    }
    Console.WriteLine();
}
