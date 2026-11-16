float lado1, lado2, lado3;

lado1 = 0f;
lado2 = 0f;
lado3 = 0f;



Console.Write("Informe, em centímetros, o lado 1: ");
lado1 = float.Parse(Console.ReadLine());

Console.Write("Informe, em centímetros, o lado 2: ");
lado2 = float.Parse(Console.ReadLine());

Console.Write("Informe, em centímetros, o lado 3: ");
lado3 = float.Parse(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado2+ lado3 > lado1 && lado3+lado1 > lado2)
{
    if (lado1 == lado2 && lado1 == lado3) Console.WriteLine("O triângulo é equilátero");
    else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3) Console.WriteLine("O triangulo é escaleno");
    else Console.WriteLine("O triângulo é isósceles");

}else Console.WriteLine("Isso não é um triangulo, a soma de dois lados tem que ser maior que o terceiro");