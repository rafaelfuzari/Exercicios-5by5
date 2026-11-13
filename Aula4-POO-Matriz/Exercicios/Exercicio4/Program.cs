string[,] dadosTexto = new string[7, 2]; //"Português""Matemática","Ciências","Geografia","História","Artes","Educação Fisica" };
float[,] notas = new float[7, 5];

void PopularMatrizMaterias()
{
    dadosTexto[0,0] = "Português    ";
    dadosTexto[1,0] = "Matemática   ";
    dadosTexto[ 2, 0] = "Ciências   ";
    dadosTexto[3, 0] = "Geografia   ";
    dadosTexto[4, 0] = "História    ";
    dadosTexto[5, 0] = "Artes        ";
    dadosTexto[6, 0] = "Educação Fisica";

}

void PopularNotas()
{
    for(int i = 0; i <7; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            notas[i, j] = Random.Shared.Next(0, 11);
        }
    }
}

void CalcularMedias()
{
    for (int i = 0; i < 7; i++)
    {
        float soma = 0f;
        float media = 0f;
        for (int j = 0; j < 5; j++)
        {
            soma += notas[i, j];
            
        }
        
        media = soma / 4f;
        notas[i,4] = media;
    }
}

void CalcularAprovacao()
{
    for (int i = 0; i < 7; i++)
    {
        if (notas[i,4] < 5)  dadosTexto[i, 1] = "Reprovado";

        else if (notas[i, 4] < 7)  dadosTexto[i, 1] = "Recuperação";

        else dadosTexto[i, 1] = "Aprovado";

    }

}

void ImprimirBoletim()
{
    Console.WriteLine("-------Imprimindo boleto----------");
    Console.WriteLine("As 4 primeiras notas são as notas do bimestre. A 5ª nota é a média do ano");
    Console.WriteLine("\n\n\nMatérias \t N1 \t N2 \t N3 \t N4 \t M \t Sit.");
    for (int i = 0; i < 7; i++)
    {
        Console.Write($"{dadosTexto[i, 0]}\t");
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"[{notas[i, j]}]\t");
        }
        Console.Write($"{dadosTexto[i, 1]}");
        Console.WriteLine();
    }

}

PopularMatrizMaterias();
PopularNotas();
CalcularMedias();
CalcularAprovacao();
ImprimirBoletim();