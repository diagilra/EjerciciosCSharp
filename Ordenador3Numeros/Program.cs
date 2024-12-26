Console.WriteLine("Ingrese el primer número:");
float A=float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
float B=float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número:");
float C=float.Parse(Console.ReadLine());

if (A>B)
{   if (A>C)
    {
        if (B>C)
        {
            Console.WriteLine($"{A}, {B}, {C}");
        }
        else
        {
            Console.WriteLine($"{A}, {C}, {B}");
        }
    }
    else
    {
        Console.WriteLine($"{C}, {A}, {B}");
    }
}
else
{
    if(B>C)
    {
        if (A>C)
        {
            Console.WriteLine($"{B}, {A}, {C}");
        }
        else
        {
            Console.WriteLine($"{B}, {C}, {A}");
        }
    }
    else 
    {
        Console.WriteLine($"{C}, {B}, {A}");
    }
}