int numero, fib;

numero = 0;
fib = 0;

Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine());

if (numero > 0) Console.WriteLine($"O numero da sequência fibonacci é: {fib}");
else Console.WriteLine("o número tem que ser maior que zero");
if (numero > 1)
{
    fib++;
    Console.WriteLine($"O numero da sequência fibonacci é: {fib}");
    for (int i = 0; i < numero - 2; i++)
    {
        Console.WriteLine($"O numero da sequência fibonacci é: {fib}");
        fib += fib;
    }
}