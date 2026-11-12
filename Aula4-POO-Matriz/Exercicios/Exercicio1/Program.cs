using System.Security.Cryptography;

int coluna;
int linha;

linha = 0;
coluna = 0;

Console.Write("Digite o numero de colunas: ");
coluna = int.Parse(Console.ReadLine());

Console.Write("Digite o numero de linhas: ");
linha = int.Parse(Console.ReadLine());

int[,] PopularMatriz()
{
    int[,] matriz = new int[linha, coluna];
    
    for(int i = 0; i < linha; i++)
    {
        for(int j = 0; j< coluna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }
    }

    return matriz;
}

void ImprimirMatriz(int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
    }

    Console.WriteLine();

    for (int i = linha -1; i >= 0; i--)
    {
        Console.WriteLine();
        for (int j = coluna -1; j >= 0; j--)
        {
            Console.Write($"[{matriz[i, j]}] ");
        }
    }
}


ImprimirMatriz(PopularMatriz());

