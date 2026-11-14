string[,] tabuleiroUm = new string[0, 0]; //matriz que representa o tabuleiro do jogador um
string[,] tabuleiroDois = new string[0, 0]; // matriz que representa o tabuleiro do jogador dois
int tamanhoTabuleiro; //controlador do tamanho do tabuleiro
int direcao; //a direção que o barco vai ser criado

//navios e seus tamanhos;
int portaAviao = 5;
int encouracado = 4;
int cruzador = 3;
int submarino = 3;
int fragata = 2;


//lendo o input do usuário sobre o tamanho do tabuleiro, tem que ser entre 10 e 20;
Console.Write("Digite o tamanho do tabuleiro:");
tamanhoTabuleiro = int.Parse(Console.ReadLine());

//reinicializando a matriz com o tamanho que o jogador escolheu
tabuleiroUm = new string[tamanhoTabuleiro, tamanhoTabuleiro];
tabuleiroDois = new string[tamanhoTabuleiro, tamanhoTabuleiro];


void PopularTabuleiro() //Primeiro eu populo toda a matriz com tabuleiro com "[~]" que representa a água(espaço vazio)
{
   
    for (int i = 0; i < tamanhoTabuleiro; i++)
    {
        for (int j = 0; j < tamanhoTabuleiro; j++)
        {
            tabuleiroUm[i, j] = "[~]";
            tabuleiroDois[i, j] = "[~]";
        }
    }
   
}

void ImprimirTabuleiro(string[,] tabuleiro)
{
    for (int i = 0; i < tamanhoTabuleiro; i++)
    {
        for (int j = 0; j < tamanhoTabuleiro; j++)
        {
            Console.Write($"{tabuleiro[i,j]}");
           
        }
        Console.WriteLine();
    }
}
void CriarBarco(int tamanhoNavio, string[,] tabuleiro)
{
    int posicaoX = Random.Shared.Next(0, tamanhoTabuleiro); //escolho uma posição aleatorio no tabuleiro
    int posicaoY = Random.Shared.Next(0, tamanhoTabuleiro);

    int comprimento = tamanhoNavio - 1  ; //pegando o comprimento do navio, considerando que a posição dele será a posicão central

    direcao = Random.Shared.Next(0,2);//Random.Shared.Next(0, 1); //gera um numero entre 0 e 1 para determinar a direção que o navio vai ser gerado, 0 significa na horizontal e 1 na vertical
    Console.WriteLine(direcao);
    switch (direcao)
    {
        case 0:
            Console.WriteLine("cheguei na posição certa");
            while ((posicaoY + comprimento >= tamanhoTabuleiro || posicaoY - comprimento < 0))
            {
                Console.WriteLine($"não cabe{posicaoY} {posicaoX}");
               
                //preciso alterar a posição de criação do navio até que ele caiba no tabuleiro
                posicaoX = Random.Shared.Next(0, tamanhoTabuleiro);
                posicaoY = Random.Shared.Next(0, tamanhoTabuleiro);
            }

            while (comprimento >= 0)
            {
                Console.WriteLine("criando o barco");
                tabuleiro[posicaoY + comprimento, posicaoX] = $"[{tamanhoNavio}]";
                comprimento--;
            }


            break;

        case 1:
            Console.WriteLine("teste");
            while (posicaoX + comprimento > tamanhoTabuleiro - 1)
            {
                Console.WriteLine("teste1");
                //preciso alterar a posição de criação do navio até que ele caiba no tabuleiro
                posicaoX = Random.Shared.Next(0, tamanhoTabuleiro);
                posicaoY = Random.Shared.Next(0, tamanhoTabuleiro);
            }
            while (comprimento >= 0)
            {
                Console.WriteLine("teste2");
                tabuleiro[posicaoY, posicaoX + comprimento] = $"[{tamanhoNavio}]";
                comprimento--;
            }
            
                break;

    }

}

PopularTabuleiro();
CriarBarco(5, tabuleiroUm);
ImprimirTabuleiro(tabuleiroUm);

PopularTabuleiro();
CriarBarco(5, tabuleiroUm);
ImprimirTabuleiro(tabuleiroUm);


PopularTabuleiro();
CriarBarco(5, tabuleiroUm);
ImprimirTabuleiro(tabuleiroUm);


PopularTabuleiro();
CriarBarco(5, tabuleiroUm);
ImprimirTabuleiro(tabuleiroUm);


