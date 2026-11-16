float x, y;

x = 0f;
y = 0f;

Console.Write("Informe o primeiro número: ");
x = float.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
y = float.Parse(Console.ReadLine());

Console.WriteLine($"A soma dos dois números é: {x+y}");
Console.WriteLine($"A subtração dos dois números é: {x - y}");
Console.WriteLine($"A multiplicação dos dois números é: {x * y}");
if (x != 0 && y != 0) Console.WriteLine($"A divisão dos dois números é: {x / y}");
else Console.WriteLine("Não existe divisão por 0");

