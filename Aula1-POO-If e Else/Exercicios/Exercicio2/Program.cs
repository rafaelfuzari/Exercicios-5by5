float x;
float y;

x = 0f;
y = 0f;

Console.WriteLine("informe o primeiro numero");
x = float.Parse(Console.ReadLine());
Console.WriteLine("informe o segundo numero");
y = float.Parse(Console.ReadLine());

if (x > y) Console.WriteLine($"{x} é maior que {y}");
else if (x < y) Console.WriteLine($"{x} é menor que {y}");
else Console.WriteLine("Os dois números são iguais");