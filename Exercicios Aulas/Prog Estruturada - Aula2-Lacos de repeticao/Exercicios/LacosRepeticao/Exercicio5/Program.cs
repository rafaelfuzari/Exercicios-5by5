int numero, resultado;

numero = 0;
resultado = 0;

Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine());
resultado = numero;

for (int i = numero; i > 1; i--)
{
    resultado *= i - 1;

}
Console.WriteLine(resultado);