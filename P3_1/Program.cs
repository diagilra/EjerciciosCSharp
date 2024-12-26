/*Realice un programa tal que dado como datos 20 números enteros, obtenga
la suma de los números impares y el promedio de los números pares.*/

int sumaImpares=0;
int sumaPares=0;
int contadorPares=0;

Console.WriteLine("Introduzca 20 números enteros:");

for(int i=1; i<=20;i++)
{
    Console.Write($"Número  {i}: ");
    int numero=int.Parse(Console.ReadLine());

    if(numero%2==0)
    {
        sumaPares += numero;
        contadorPares++;
    }
    else
    {
    sumaImpares+=numero;
    }
}

double promedioPares = contadorPares>0? sumaPares/contadorPares: 0;

Console.WriteLine($"La suma de los números impares es: {sumaImpares}");
Console.WriteLine($"El promedio de los números pares es: {promedioPares:F2}");