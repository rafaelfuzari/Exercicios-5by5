int numero;

numero = 0;

Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine());

for (int i = 2; i <= numero; i++)
{
    int divisores = 2;
    int j = 2;
    while (j <= i)
    {
        if ((i % j == 0) && (j != i)) divisores--;
        j++;
    };
    
    if (divisores == 2) Console.WriteLine($"{i} é um numero primo");
    if (divisores < 2) Console.WriteLine($"{i} não é um numero primo");
}