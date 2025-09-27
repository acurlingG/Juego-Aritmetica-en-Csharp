
using System.Security.Cryptography;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("***** JUEGO DE ARITMETICA *****");
Console.WriteLine("--------------------------------");
Console.WriteLine();
Random aleatorio = new Random();  //definimos una variable para numeros aleatorios de tipo Random

int dificultad = 100;

int n1 = aleatorio.Next(1, dificultad);
int n2 = aleatorio.Next(1, dificultad);
byte operacion = (byte)aleatorio.Next(1, 4); // casteo a byte  1 suma, 2 resta, 3 multiplicacion y 4 division
int respuesta = 0;
Console.ForegroundColor = ConsoleColor.White;
switch (operacion)
{
    case 1:   // suma
        Console.WriteLine($"La suma de {n1} + {n2} = ?");
        respuesta = n1 + n2;
break;
    case 2:
        Console.WriteLine($"La resta de {n1} - {n2} = ?");
    respuesta = n1 - n2;
    break;
    case 3:
        Console.WriteLine($"La multiplicacion de {n1} * {n2} = ?");
        respuesta = n1 * n2;
        break;
    case 4:
        Console.WriteLine($"La division de {n1} / {n2} = ?");
        respuesta = n1 / n2;    
        break;
    default:
        break;
}

Console.Write("Digite la respuesta correcta...:  ");
int resultado = int.Parse(Console.ReadLine());

if (respuesta == resultado)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Respuesta Correcta");
} else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Respuesta Incorrecta, la respuesta correcta es {respuesta}");
}