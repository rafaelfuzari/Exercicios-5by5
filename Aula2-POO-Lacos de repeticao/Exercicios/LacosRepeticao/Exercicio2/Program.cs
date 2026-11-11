int numero, fib;


numero = 0;
fib = 0;

Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine($"O numero da sequência fibonacci é: {fib}");

if (numero > 0)
{
    fib++;
    Console.WriteLine($"O numero da sequência fibonacci é: {fib}");
    for (int i = 0; i < numero - 2; i++)
    {
        Console.WriteLine($"O numero da sequência fibonacci é: {fib}");
        fib += fib;
    }
}