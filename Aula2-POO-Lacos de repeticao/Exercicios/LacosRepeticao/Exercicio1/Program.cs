int numero;

numero = 0;

Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero}x{i}={i * numero}");
}


