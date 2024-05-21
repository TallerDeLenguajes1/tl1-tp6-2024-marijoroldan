// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("valor de a: " + a);
// Console.WriteLine("valor de b: " + b);


// // EJERCICIO 1

// string? input;
// bool boolresul;
// int num, invertido = 0, numInvertido = 0;
// Console.WriteLine("Ingrese un número: ");
// input = Console.ReadLine();

// boolresul = int.TryParse(input, out num);
// if (boolresul == true)
// {
//     while (num > 0)
//     {
//         invertido = num % 10;
//         numInvertido = numInvertido * 10 + invertido;
//         num = num / 10;
//     }

// }

//Console.WriteLine("Número invertido: " + numInvertido);


// //EJERCICIO 3
// float numX, numAbs = 0, numCuad = 0;
// Console.WriteLine("Ingrese un número: ");
// float.TryParse(Console.ReadLine(), out numX);

// if (numX != 0)
// {
//     if (numX < 0)
//     {
//         numAbs = numX * (-1);
//     }
//     else
//     {
//         numAbs = numX;
//     }
//     Console.WriteLine("Valor absoluto: " + numAbs);

//     numCuad = numX * numX;

//     Console.WriteLine("Valor al cuadrado: " + numCuad);

//     if (numX > 0)
//     {
//         double numRaiz = Math.Sqrt(numX);
//         Console.WriteLine("Valor raiz cuadrada: " + numRaiz);
//     }
//     else
//     {
//         Console.WriteLine("No se puede calcular la raiz cuadrada ");
//     }
//      double numSeno= Math.Sin(numX);
//         Console.WriteLine("El seno del número: "+numSeno);
//      double numCos = Math.Cos(numX);
//         Console.WriteLine("El coseno del número: "+numCos);
//     int numEnt1 = (int)numX; //devuelve el valor entero sin redondear
    
//     int numEnt2 = Convert.ToInt32(numX); //devuelve el valor entero redondea
//         Console.WriteLine("El entero: "+numEnt1);
//         Console.WriteLine("El entero: "+numEnt2);

    
// } else
// {
// Console.WriteLine("Ingresar otro valor");
// float.TryParse(Console.ReadLine(), out numX);
//     if (numX < 0)
//     {
//         numAbs = numX * (-1);
//     }
//     else
//     {
//         numAbs = numX;
//     }
//     Console.WriteLine("Valor absoluto: " + numAbs);

//     numCuad = numX * numX;

//     Console.WriteLine("Valor al cuadrado: " + numCuad);

//     if (numX > 0)
//     {
//         double numRaiz = Math.Sqrt(numX);
//         Console.WriteLine("Valor raiz cuadrada: " + numRaiz);
//     }
//     else
//     {
//         Console.WriteLine("No se puede calcular la raiz cuadrada ");
//     }
//      double numSeno= Math.Sin(numX);
//         Console.WriteLine("El seno del número: "+numSeno);
//      double numCos = Math.Cos(numX);
//         Console.WriteLine("El coseno del número: "+numCos);
//     int numEnt1 = (int)numX; //devuelve el valor entero sin redondear
    
//     int numEnt2 = Convert.ToInt32(numX); //devuelve el valor entero redondea
//         Console.WriteLine("El entero: "+numEnt1);
//         Console.WriteLine("El entero: "+numEnt2);

// }

//SOLICITO 2 VALORES AL USUARIO
float num1,num2;
Console.WriteLine("Ingresar un valor");
float.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("Ingresar otro valor");
float.TryParse(Console.ReadLine(), out num2);

if (num1>num2)
{
    Console.WriteLine("Número máximo: "+num1);
    Console.WriteLine("Número minimo: "+num2);
}else
{
    Console.WriteLine("Número máximo: "+num2);
    Console.WriteLine("Número minimo: "+num1);
}
