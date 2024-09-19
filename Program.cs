string nombre;

double sueldo, ganancia = 0, nuevoS = 0, descuento = 0, sueldoFinal = 0;

int añoEM, vemtaS;

Console.WriteLine("ingrese su primer nombre: ");

nombre = Console.ReadLine().ToLower().Trim();

Console.WriteLine("cuantas ventas a realizado: ");

vemtaS = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese su sueldo bruto: ");

sueldo = double.Parse(Console.ReadLine());

Console.WriteLine("cuantos años tiene trabajando en la empresa");

añoEM = int.Parse(Console.ReadLine());

if (vemtaS <= 600)

{

    ganancia = vemtaS * 0.05;

    nuevoS = sueldo * ganancia;

}

else if (vemtaS > 600 && vemtaS <= 30000)

{

    ganancia = sueldo * 0.07;

    nuevoS = sueldo + ganancia;

}

else if (vemtaS > 300)

{

    nuevoS = (sueldo + 300) + (vemtaS * 0.06);

}



if (añoEM <= 3)

{

    descuento = nuevoS * 0.065;

    sueldoFinal = nuevoS - descuento;

}

else if (añoEM >= 4)

{

    descuento = nuevoS * 0.045;

    sueldoFinal = nuevoS - descuento;

}

Console.WriteLine($"\n{nombre}");

Console.WriteLine($"\nSu sueldo bruto es S/{sueldo}");

Console.WriteLine($"\nLas ventas que realizo son {vemtaS}");

Console.WriteLine($"\nSus años en la empresa son {añoEM}");

Console.WriteLine($"\nSu ganancia es {ganancia}");

Console.WriteLine($"\nSu descuento es {descuento}");

Console.WriteLine($"\nEl sueldo neto es de S/{sueldoFinal}");

Console.ReadKey();
