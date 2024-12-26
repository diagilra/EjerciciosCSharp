/* La siguiente se llama la conjetura de ULAM en honor del matemático S.Ulam:
• Comience con cualquier entero positivo
• Si es par, divídalo entre 2; si es impar, multiplíquelo por 3 y agréguele 1.
• Obtenga enteros sucesivamente repitiendo el proceso.
Al final, obtendrá el número 1, independientemente del entero inicial. Por ejemplo,
cuando el entero inicial es 26, la secuencia será: 26, 13, 40, 20, 10, 5, 16, 8, 4,
2, 1.
Escriba un programa que lea un entero positivo y obtenga e imprima
la sucesión de ULAM.
*/
int num=0;

Console.WriteLine("Ingrese un número entero positivo");
if (int.TryParse(Console.ReadLine(), out num) && num>0)
{
    Console.WriteLine("Secuencia ULAM");

    while (num!=1)
    {
        Console.Write($"{num}, ");
        if (num%2==0)
        {
            num/= 2;
        }
        else
        {
            num=num*3+1;
        }
    }
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Error: Debes ingresar un número entero positivo.");
}