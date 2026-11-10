int x;

x = 0;

Console.WriteLine("Digite o número a ser verificado");
x = int.Parse(Console.ReadLine());

if (x % 2 == 0) Console.WriteLine($"{x} é um numero par");
else Console.WriteLine($"{x} é um numero impar");
