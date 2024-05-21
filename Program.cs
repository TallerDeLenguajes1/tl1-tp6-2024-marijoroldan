// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a: " + a);
Console.WriteLine("valor de b: " + b);


// EJERCICIO 1

string? input;
bool boolresul;
int num, invertido = 0, numInvertido = 0;
Console.WriteLine("Ingrese un número: ");
input = Console.ReadLine();

boolresul = int.TryParse(input, out num);
if (boolresul == true)
{
    while (num > 0)
    {
        invertido = num % 10;
        numInvertido = numInvertido * 10 + invertido;
        num = num / 10;
    }

}

Console.WriteLine("Número invertido: " + numInvertido);


//EJERCICIO 2


int operacion, num1, num2, suma = 0, resta = 0, multi = 0, div = 0;
Console.WriteLine("Qué operación desea realizar: \n 1. SUMA \n 2. RESTA \n 3. MULTI \n 4. DIV");

int.TryParse(Console.ReadLine(), out operacion);

while (operacion != 0)
{
    if (operacion == 1)
    {
        Console.WriteLine("Ingrese los números: ");
        int.TryParse(Console.ReadLine(), out num1);
        int.TryParse(Console.ReadLine(), out num2);


        suma = num1 + num2;
        Console.WriteLine("SUMA: " + suma);
    }
    else if (operacion == 2)
    {
        Console.WriteLine("Ingrese los números: ");
        int.TryParse(Console.ReadLine(), out num1);
        int.TryParse(Console.ReadLine(), out num2);
        resta = num1 - num2;
        Console.WriteLine("RESTA: " + resta);
    }
    else if (operacion == 3)
    {
        Console.WriteLine("Ingrese los números: ");
        int.TryParse(Console.ReadLine(), out num1);
        int.TryParse(Console.ReadLine(), out num2);
        multi = num1 * num2;
        Console.WriteLine("MULTI: " + multi);
    }
    else if (operacion == 4)
    {
        Console.WriteLine("Ingrese los números: ");
        int.TryParse(Console.ReadLine(), out num1);
        int.TryParse(Console.ReadLine(), out num2);
        div = num1 / num2;
        Console.WriteLine("DIV: " + div);
    }
    Console.WriteLine("Desea realizar otra operación: \n 0. NO \n 1. SUMA \n 2. RESTA \n 3. MULTI \n 4. DIV");
    int.TryParse(Console.ReadLine(), out operacion);

}





