int numero;

numero = 0;

Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i <= numero; i++)
{
    
    if (i % 2 != 0) Console.WriteLine($"Numeros impares: {i}");
}

for (int i = numero; i >=0; i--)
{
    if (i % 2 == 0) Console.WriteLine($"Numeros pares: {i}");
}