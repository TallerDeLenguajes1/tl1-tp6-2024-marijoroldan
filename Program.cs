// See https://aka.ms/new-console-template for more information
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



