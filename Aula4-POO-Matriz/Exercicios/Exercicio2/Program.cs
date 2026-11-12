using System.Security.Cryptography;

int coluna;
int linha;


linha = 3;
coluna = 5;

int[,] PopularMatriz()
{
    int[,] matriz = new int[linha, coluna];

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
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
    int[,] matrizInversa = new int [coluna, linha];
    Console.WriteLine();

    for (int i = 0; i < coluna; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < linha; j++)
        {
            matrizInversa[i, j] = matriz[j, i];
            Console.Write($"[{matrizInversa[i, j]}] ");
        }
    }
}

ImprimirMatriz(PopularMatriz());