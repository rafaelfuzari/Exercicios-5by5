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
            Console.Write($"{tabuleiro[i, j]}");

        }
        Console.WriteLine();
    }
}
void CriarBarco(int tamanhoNavio, string[,] tabuleiro)
{
    bool check = false;
    int posicaoX = Random.Shared.Next(1, tamanhoTabuleiro -1); //escolho uma posição aleatorio no tabuleiro
    int posicaoY = Random.Shared.Next(1, tamanhoTabuleiro -1);

    int comprimento = tamanhoNavio - 1; //pegando o comprimento do navio, considerando que a posição dele será a posicão central

    Reset:
    direcao = Random.Shared.Next(0, 2); //gera um numero entre 0 e 1 para determinar a direção que o navio vai ser gerado, 0 significa na vertical e 1 na horizontal
  
    
    switch (direcao)
    {
        case 0:

            
            do
            {
                Console.WriteLine("reiniciei");
                
                posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1); //escolho uma posição aleatorio no tabuleiro
                posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);

                //preciso alterar a posição de criação do navio até que ele caiba no tabuleiro
                while (posicaoY + comprimento >= tamanhoTabuleiro - 2)
                {
                    Console.WriteLine($"não cabe{posicaoY} {posicaoX}");
                    posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                    posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                }


                for (int i = posicaoX - 1; i <= posicaoX + 1; i++)
                {
                    for (int j = posicaoY - 1; j <= posicaoY + tamanhoNavio; j++)//checando se não há nenhum barco a esquerda
                    {
                        if (j > tamanhoTabuleiro - 1) goto Reset;
                        if (!tabuleiro[j, i].Equals("[~]") && i != posicaoX)
                        {
                            Console.WriteLine("tem um barco encostado(vertical)");
                            goto Reset;
                        }

                        if ((i == posicaoX) && (j == posicaoY - 1 || j == posicaoY + tamanhoNavio))
                        {
                            if (!tabuleiro[j, i].Equals("[~]"))
                            {
                                Console.WriteLine("tem um barco encostado(vertical)");
                                goto Reset;
                            }
                        }
                    }



                }

                if (!tabuleiro[posicaoY, posicaoX].Equals("[~]")) goto Reset;

                while (comprimento >= 0)
                {
                    //criando o barco na vertical
                   
                    tabuleiro[posicaoY + comprimento, posicaoX] = $"[{tamanhoNavio}]";
                    comprimento--;
                }
            } while ((posicaoY + comprimento >= tamanhoTabuleiro - 2));

            break;

        case 1:
            
            do
            {
                Console.WriteLine("reiniciei");
                posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1); //escolho uma posição aleatorio no tabuleiro
                posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                //preciso alterar a posição de criação do navio até que ele caiba no tabuleiro
                while (posicaoX + comprimento >= tamanhoTabuleiro - 2)
                {
                    Console.WriteLine($"não cabe{posicaoY} {posicaoX}");
                    posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                    posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                }

                for (int i = posicaoY - 1; i <= posicaoY + 1; i++)
                {
                    for (int j = posicaoX - 1; j <= posicaoX + tamanhoNavio; j++)//checando se não há nenhum barco a esquerda
                    {
                        if (j > tamanhoTabuleiro - 1) goto Reset;
                        if (!tabuleiro[i, j].Equals("[~]") && i != posicaoY)
                        {
                            Console.WriteLine("tem um barco encostado(horizontal)");
                            goto Reset;
                        }

                        if (i == posicaoY && (j == posicaoX - 1 || j == posicaoX + tamanhoNavio))
                        {
                            if (!tabuleiro[i, j].Equals("[~]"))
                            {
                                Console.WriteLine("tem um barco encostado(horizontal)");
                                
                                goto Reset;
                            }

                        }
                    }
                }

                if (!tabuleiro[posicaoY, posicaoX].Equals("[~]")) goto Reset;

                while (comprimento >= 0)
                {

                    //criando o barco na horizontal
                    tabuleiro[posicaoY, posicaoX + comprimento] = $"[{tamanhoNavio}]";
                    comprimento--;
                }
            } while (posicaoX + comprimento > tamanhoTabuleiro - 2);
            break;

    }

}

PopularTabuleiro();
CriarBarco(5, tabuleiroUm);
CriarBarco(4, tabuleiroUm);
CriarBarco(3, tabuleiroUm);
CriarBarco(3, tabuleiroUm);
CriarBarco(2, tabuleiroUm);
ImprimirTabuleiro(tabuleiroUm);







