double sueldo, ganancia, nuevoS;

Console.WriteLine("Ingrese su sueldo bruto: ");
sueldo=double.Parse(Console.ReadLine());

while (sueldo <= 600)
{
    ganancia=sueldo * 0.05;
    nuevoS=sueldo+ganancia;
}
