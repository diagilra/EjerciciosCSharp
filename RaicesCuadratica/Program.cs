Console.WriteLine("Ingrese el coeficiente a del polinomio:");
double A=double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el coeficiente b del polinomio:");
double B=double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el coeficiente b del polinomio:");
double C=double.Parse(Console.ReadLine());

double DIS=Math.Pow(B,2)-4*A*C;

if (DIS>=0)
{
    double x1=(-B+Math.Sqrt(DIS))/(2*A);
    double x2=(-B-Math.Sqrt(DIS))/(2*A);
    Console.WriteLine($"Las raíces reales del polinomio son: {x1} y {x2}");
}
else
{
    Console.WriteLine("Las raíces del polinomio no son reales");
}