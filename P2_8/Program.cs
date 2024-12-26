/* En una tienda efectúan un descuento a los clientes dependiendo del monto de la
compra. El descuento se efectúa con base en el siguiente criterio:
-Si el monto es menor que $500 no hay descuento.
-Si el monto está comprendido entre $500 y $1 000
inclusive 5% de descuento.
Si el monto está comprendido entre $1 000 y $7 000
inclusive 11% de descuento.
Si el monto está comprendido entre $7 000 y $15 000
inclusive 18% de descuento.
Si el monto es mayor a $15 000 25% de descuento.
Construya un diagrama de flujo tal que dado el monto de la compra de un
cliente, determine lo que el mismo debe pagar. */

Console.WriteLine("Ingrese el valor de su compra: ");
double COMPRA=double.Parse(Console.ReadLine());
double PAGAR = 0;

if (COMPRA<500)
{
    PAGAR=COMPRA;
}
else if (COMPRA>=500 && COMPRA<=1000)
{
    PAGAR=COMPRA*0.95;
}
else if (COMPRA>1000 && COMPRA<=7000)
{
    PAGAR=COMPRA*0.89;
}
else if (COMPRA>7000 && COMPRA<=15000)
{
    PAGAR=COMPRA*0.82;
}
else if (COMPRA>15000)
{
    PAGAR=COMPRA*0.75;
}

Console.WriteLine($"Usted debe pagar: {PAGAR}");

 