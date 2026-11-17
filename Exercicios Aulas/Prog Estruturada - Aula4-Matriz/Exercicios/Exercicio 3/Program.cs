int linha, coluna;
int[,] matriz = new int[0, 0];

Console.Write("Informe o tamanho da matriz quadrada: ");
linha = int.Parse(Console.ReadLine());
coluna = linha;

matriz = new int[linha, coluna];

void PreencherMatriz()
{

    for (int i = 0; i < linha; i++)
    {
        
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"Digite o valor de [{i}][{j}]: ");
            matriz[i,j] = int.Parse(Console.ReadLine());
        }
    }
}

void ImprimirMatriz(int[,] matriz)
{
    Console.WriteLine("------------------Matriz Impressa--------------");
    for (int i = 0; i < linha; i++)
    {
        Console.WriteLine();

        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{matriz[i, j]}]\t");

        }
    }

    
}

void CalcularLinhas(int[,] matriz)
{
    Console.WriteLine("\n\n---------Calculo das linhas-------------");
    
    for (int i = 0; i < linha; i++)
    {
        int soma = 0;
        for (int j = 0; j < coluna; j++)
        {
            soma += matriz[i,j];
            
        }
        Console.WriteLine($"Soma da linha {i}: {soma}");
    }

}

void CalcularColunas(int[,] matriz)
{
    Console.WriteLine("\n---------Calculo das Colunas-------------");

    for (int i = 0; i < linha; i++)
    {
        int soma = 0;
        for (int j = 0; j < coluna; j++)
        {
            soma += matriz[j, i];

        }
        Console.WriteLine($"Soma da coluna {i}: {soma}");
    }

}
void CalcularDiagonalPrincipal(int[,] matriz)
{
    Console.WriteLine("\n---------Calculo da diagonal principal-------------");
    int soma = 0;
    for (int i = 0; i < linha; i++)
    {
        
        for (int j = 0; j < coluna; j++)
        {
            if (j == i) soma += matriz[i, j];

        }
        
    }
    Console.WriteLine($"Soma da diagonal principal: {soma}");
}

void CalcularDiagonalSecundaria(int[,] matriz)
{
    Console.WriteLine("\n---------Calculo da diagonal secundária-------------");
    int soma = 0;
    int cont = linha;
    int aux = 0;
    while (cont > 0)
    {
        soma += matriz[cont-1, aux];
        aux++;
        cont--;
    }
    Console.WriteLine($"Soma da diagonal secundaria: {soma}");
}

PreencherMatriz();
ImprimirMatriz(matriz);
CalcularLinhas(matriz);
CalcularColunas(matriz);
CalcularDiagonalPrincipal(matriz);
CalcularDiagonalSecundaria(matriz);