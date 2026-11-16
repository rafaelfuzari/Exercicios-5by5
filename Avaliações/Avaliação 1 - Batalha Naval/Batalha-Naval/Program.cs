using System.ComponentModel.Design;

string[,] tabuleiroUm = new string[0, 0]; //matriz que representa o tabuleiro do jogador um
string[,] tabuleiroDois = new string[0, 0]; // matriz que representa o tabuleiro do jogador dois
int tamanhoTabuleiro; //controlador do tamanho do tabuleiro
int direcao; //a direção que o barco vai ser criado
bool vitoriaJog = false, vitoriaCom = false; //controle de vitoria


tamanhoTabuleiro = 10;

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

void ImprimirTabuleiroJogador(string[,] tabuleiro)
{
    //no tabuleiro do jogador não temos segredos, o valor exato da matriz vai ser exibido
   
    
    Console.WriteLine("\t\t\t --Jogador--");
    Console.WriteLine("\t\t   0  1  2  3  4  5  6  7  8  9");//cabeçalho, junto com as linhas

    for (int i = 0; i < tamanhoTabuleiro; i++)
    {
        //cabeçalho de colunas
        Console.Write($"\t\t{i} ");
        for (int j = 0; j < tamanhoTabuleiro; j++)
        {
            //mudando a cor de acordo com o indice a ser exibido, e logo em seguida exibindo ele
            if (tabuleiro[i,j].Equals("[!]")) Console.ForegroundColor = ConsoleColor.Green;
            else if (tabuleiro[i, j].Equals("[~]")) Console.ForegroundColor = ConsoleColor.Blue;
            else if (tabuleiro[i, j].Equals("[X]")) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write($"{tabuleiro[i, j]}");

            Console.ResetColor(); //resetando a cor para o padrao
        }
        Console.WriteLine();
    }
}

void ImprimirTabuleiroComputador(string[,] tabuleiro)
{
    //O tabuleiro do computador não pode exibir os barcos dele, somente os espaços vazios e os que já foram acertados
    //dessa forma, os indices que possuirem um navio aparecerão como espaços vazios ([~])

    //cabeçalho, junto com as linhas
    Console.WriteLine("\t\t\t--Computador--");
    Console.WriteLine("\t\t   0  1  2  3  4  5  6  7  8  9");
    for (int i = 0; i < tamanhoTabuleiro; i++)
    {
        Console.Write($"\t\t{i} "); //cabeçalhos de colunas

        for (int j = 0; j < tamanhoTabuleiro; j++)
        {
            //trocando de cor de acordo com o índice a ser exibido e exibindo ele
            Console.ForegroundColor = ConsoleColor.Red;
            if (!tabuleiro[i, j].Equals("[!]") && !tabuleiro[i, j].Equals("[X]"))
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.Write("[~]");
            }
            else if (tabuleiro[i, j].Equals("[!]"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[!]");
            }
            else if (tabuleiro[i, j].Equals("[X]"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[X]");
            }
                Console.ResetColor();//resetando a cor para o padrão
            }
        Console.WriteLine();
    }
}
void CriarBarco(int tamanhoNavio, string[,] tabuleiro)
{
    //essa eu nem sei como eu fiz funcionar, mas funciona, e eu vou TENTAR explicar
    
    int posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1); //escolho uma posição aleatorio no tabuleiro
    int posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);

    int comprimento = tamanhoNavio - 1; //pegando o comprimento do navio, considerando que a posição dele será a posicão central

Reset:
    direcao = Random.Shared.Next(0, 2); //gera um numero entre 0 e 1 para determinar a direção que o navio vai ser gerado, 0 significa na vertical e 1 na horizontal


    switch (direcao)
    {
        case 0:


            do
            {

                posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1); //escolho uma posição aleatorio no tabuleiro
                posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);

                //preciso alterar a posição de criação do navio até que ele caiba no tabuleiro
                while (posicaoY + comprimento >= tamanhoTabuleiro - 2)
                {

                    posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                    posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                }


                //o barco foi criado na vertical, verifico se há algum barco uma linha acima e uma abaixo dele, dentro do seu tamanho
                //também verifico se há algum barco uma coluna antes do ponto de origem dele, e também uma coluna depois do fim dele
                for (int i = posicaoX - 1; i <= posicaoX + 1; i++)
                {
                    for (int j = posicaoY - 1; j <= posicaoY + tamanhoNavio; j++)
                    {
                        if (j > tamanhoTabuleiro - 1) goto Reset;
                        if (!tabuleiro[j, i].Equals("[~]") && i != posicaoX)
                        {

                            goto Reset;
                        }

                        if ((i == posicaoX) && (j == posicaoY - 1 || j == posicaoY + tamanhoNavio))
                        {
                            if (!tabuleiro[j, i].Equals("[~]"))
                            {

                                goto Reset;
                            }
                        }
                    }



                }

                if (!tabuleiro[posicaoY, posicaoX].Equals("[~]")) goto Reset; //se houver algum barco nessa posição, reinicia todo o processo de criação

                while (comprimento >= 0)
                {
                    //criando o barco na vertical, a partir do ponto de origem para a direita

                    tabuleiro[posicaoY + comprimento, posicaoX] = $"[{tamanhoNavio}]";
                    comprimento--;
                }
            } while ((posicaoY + comprimento >= tamanhoTabuleiro - 2));

            break;

        case 1:

            do
            {

                posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1); //escolho uma posição aleatorio no tabuleiro
                posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);

                //preciso alterar a posição de criação do navio até que ele caiba no tabuleiro
                while (posicaoX + comprimento >= tamanhoTabuleiro - 2)
                {

                    posicaoX = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                    posicaoY = Random.Shared.Next(1, tamanhoTabuleiro - 1);
                }

                //o barco foi criado na horizontal, verifico se há algum barco uma coluna na esquerda e uma na direita dele, dentro do seu tamanho
                //também verifico se há algum barco uma linha antes do ponto de origem dele, e também uma uma depois do fim dele
                for (int i = posicaoY - 1; i <= posicaoY + 1; i++)
                {
                    for (int j = posicaoX - 1; j <= posicaoX + tamanhoNavio; j++)
                    {
                        if (j > tamanhoTabuleiro - 1) goto Reset;
                        if (!tabuleiro[i, j].Equals("[~]") && i != posicaoY)
                        {

                            goto Reset;
                        }

                        if (i == posicaoY && (j == posicaoX - 1 || j == posicaoX + tamanhoNavio))
                        {
                            if (!tabuleiro[i, j].Equals("[~]"))
                            {


                                goto Reset;
                            }

                        }
                    }
                }

                if (!tabuleiro[posicaoY, posicaoX].Equals("[~]")) goto Reset; //se já houver um barco nessa posição, reinicia todo o processo de geração

                while (comprimento >= 0)
                {

                    //criando o barco na horizontal, do ponto de partida para baixo
                    tabuleiro[posicaoY, posicaoX + comprimento] = $"[{tamanhoNavio}]";
                    comprimento--;
                }
            } while (posicaoX + comprimento > tamanhoTabuleiro - 2);
            break;

    }
}

void Atirar(string[,] tabuleiro)
{
    //pegando os dados de mira do jogador
    InputMira:
    Console.Write("Digite a linha que você deseja mirar: ");
    int linha = int.Parse(Console.ReadLine()!);
    Console.Write("Digite a coluna que você deseja mirar: ");
    int coluna = int.Parse(Console.ReadLine()!);

    //se o jogador escrever alguma coordenada errada, o sistema volta um passo
    if (coluna > 9 || coluna < 0 || linha > 9 || linha < 0)
    {
        Console.WriteLine("\t\t Você digitou uma coordenada errada! Vamos de novo");
        goto InputMira;
    }
    Console.Clear();
    //checo se o jogador já escolheu uma posição que não tenha escolhido antes
    if (!tabuleiro[linha, coluna].Equals("[X]") && !tabuleiro[linha, coluna].Equals("[!]")) { 
        if (tabuleiro[linha, coluna].Equals("[~]"))//se for um espaço vazio, só troca o caractere e passa a vez pro computador
        {
            tabuleiro[linha, coluna] = "[X]";
        }
        else
        {
            tabuleiro[linha, coluna] = "[!]";//se não for um espaço vazio, vai alterar a matriz do oponente, indicando que atingiu um navio

            Console.Clear();

            //reimprimindo os tabuleiros
            ImprimirTabuleiroJogador(tabuleiroUm);
            ImprimirTabuleiroComputador(tabuleiroDois);

            Console.WriteLine("\t\tVocê acertou uma parte do navio! Irá atirar novamente");

            //checando se o jogador venceu
            vitoriaJog = checarVitoria(tabuleiroDois);

            if (!vitoriaJog) Atirar(tabuleiro);//se não venceu, atira de novo, se não, vai pra "tela" de vitória
            else
            {
                Console.WriteLine("\n\t\tVocê ganhou! Aperte ENTER para voltar para o menu principal");
                Console.ReadLine();
                
            }
            
        }
    }
    else
    {
        //caso o jogador escolha uma casa que já tenha escolhido, atira de novo
        Console.WriteLine("Você escolheu uma casa que já atirou, escolha outra");
        Atirar(tabuleiro);
    }
    
}

void AtirarCom(string[,] tabuleiro)
{
    //mira aleatória da máquina
    int linha = Random.Shared.Next(0, tamanhoTabuleiro);
    int coluna = Random.Shared.Next(0, tamanhoTabuleiro);

    //garantindo que a máquina não atire em um lugar que já tenha atirado
    while (tabuleiroUm[linha, coluna].Equals("[X]") || tabuleiroUm[linha, coluna].Equals("[!]"))
    {
        linha = Random.Shared.Next(0, tamanhoTabuleiro);
        coluna = Random.Shared.Next(0, tamanhoTabuleiro);
    }


    if (tabuleiro[linha, coluna].Equals("[~]"))//caso atingir um espaço vazio, vai trocar o caractere para representar
    {
        tabuleiro[linha, coluna] = "[X]";

        //reimprimindo os tabuleiros
        ImprimirTabuleiroJogador(tabuleiroUm);
        ImprimirTabuleiroComputador(tabuleiroDois);

        //errou o tiro, passando a vez pro jogador
        Console.WriteLine($"O computador acertou a casa [{linha},{coluna}] e o tiro foi direto na água! Pressione ENTER para prosseguir");
        Console.ReadLine();
    }
    else //caso acerte o tiro
    {
        tabuleiro[linha, coluna] = "[!]";//caractere representado que acertou um tiro

        //reimprimindo os tabuleiros
        ImprimirTabuleiroJogador(tabuleiroUm);
        ImprimirTabuleiroComputador(tabuleiroDois);

        //acertou o tiro, vai atirar de novo
        Console.WriteLine($"O computador acertou a casa [{linha},{coluna}] e tinha uma parte do navio! Ele vai atirar de novo! Pressione Enter para prosseguir ");
        Console.ReadLine();

        //checando se o computador ganhou
        vitoriaCom = checarVitoria(tabuleiro);

        if (!vitoriaCom)AtirarCom(tabuleiro); // se não ganhou, atira de novo, se não, o jogador vai pra "tela" de derrota
        else
        {
            Console.WriteLine("\n\t\tVocê perdeu! Aperte ENTER para voltar para o menu principal");
            Console.ReadLine();
        }
    }




}
bool checarVitoria(string[,] tabuleiro)
{
    //para checar a vitória, os laços for percorrem toda a matriz e contam quantas casas de navio ainda tem
    //se não houver nenhuma, é vitória do jogador oposto ao do tabuleiro informado no parâmetro
    int contador = 0;

    for (int i = 0; i < tamanhoTabuleiro; i++)
    {
        for (int j = 0; j < tamanhoTabuleiro; j++)
        {
            if (tabuleiro[i, j] != "[~]" &&
                tabuleiro[i, j] != "[!]" &&
                tabuleiro[i, j] != "[X]") contador++;


        }

    }

    if (contador == 0) return true;
    else return false;
}



while (true)
{
menu:
    int escolha = 100;

    Console.Clear();

    Console.WriteLine("\t------------Bem vindo à Batalha Naval------------\n\n");
    Console.Write("\t\tDigite o numero da opção desejada:\n\t\t" +
        "1 - Jogar\n\t\t" +
        "2 - Como jogar\n\t\t" +
        "0 - Sair\n\t\t");

    escolha = int.Parse(Console.ReadLine());


    switch (escolha)
    {
        case (1):
            while (true)
            {
            GerarTabuleiro:

                Console.Clear();
                Console.WriteLine("\n\t Caso não tenha visto como jogar no menu principal, é fortemente recomendável que retorne e veja o tutorial" +
                "\n\n\t O seu tabuleiro é gerado aleatoriamente, você pode ir gerando novos tabuleiros até que fique satisfeito com o resultado\n");

                //populando o tabuleiro tanto do jogando quanto do computador
                PopularTabuleiro();
                //criando os barcos e mostrando o tabuleiro para o jogador
                CriarBarco(5, tabuleiroUm);
                CriarBarco(4, tabuleiroUm);
                CriarBarco(3, tabuleiroUm);
                CriarBarco(3, tabuleiroUm);
                CriarBarco(2, tabuleiroUm);
                
                ImprimirTabuleiroJogador(tabuleiroUm);

                
                Console.WriteLine("\n\t1 - Jogar \t\t 2 - Gerar tabuleiro");
                string opcao = Console.ReadLine();

                //checando se o jogador quer continuar com o tabuleiro gerado ou gerar um novo
                if (opcao.Equals("1")) break;
                else if (opcao.Equals("2")) goto GerarTabuleiro;
                else
                {
                    Console.WriteLine("Insira uma opção válida(aguarde o reinicio)");
                    Thread.Sleep(3000);
                    goto GerarTabuleiro;
                }
            }
            //criando os barcos do computador
            CriarBarco(5, tabuleiroDois);
            CriarBarco(4, tabuleiroDois);
            CriarBarco(3, tabuleiroDois);
            CriarBarco(3, tabuleiroDois);
            CriarBarco(2, tabuleiroDois);

            //laço da jogatina
            while (true)
            {
                Console.Clear();
                //imprimo os tabuleiros e alterno os turnos entre jogador e computador
                //também checo se houve vitória entre os tiros
                ImprimirTabuleiroJogador(tabuleiroUm);

                Console.WriteLine("\n");

                ImprimirTabuleiroComputador(tabuleiroDois);
                
                Atirar(tabuleiroDois);
                if (vitoriaCom || vitoriaJog) goto menu;
                AtirarCom(tabuleiroUm);
                if (vitoriaCom || vitoriaJog) goto menu;
            }

        case (2):
            //tutorial do jogo
            Console.WriteLine("\t-------------------------------------------------");
            Console.WriteLine("\n\t\tO jogo segue as regras padrões\n\t\t" +
                "\n\t\t-Cada jogador possui 5 navios de tamanhos diferentes;" +
                "\n\t\t-O objetivo é destruir os navios do adversário antes que ele faça o mesmo com os seus;" +
                "\n\t\t-Para destruir os navios basta escolher a ação de atirar e escolher as coordenadas;" +
                "\n\t\t-Se não acertar nada, a casa será marcada com um 'X', e será a vez do seu adversário atirar;" +
                "\n\t\t-Se acertar uma parte de navio, a casa será marcada com um '!' e você podera atirar novamente;" +
                "\n\t\t-Ao destruir todos os navios do adversário, você ganha o jogo!" +
                "\n\n\t\t Insira algum valor e dê ENTER para voltar ao menu principal");
            Console.ReadLine();
            Console.Clear();
            goto menu;

        case (0):
            //opção de sair do jogo
            Console.WriteLine("\n\t\t Obrigado por Jogar!");
            goto saida;

        default:
            //entrada inválida
            Console.WriteLine("Digite uma opção válida!(aguarde o reinicio)");
            Thread.Sleep(3000);
            goto menu;
           

    }


saida:
    break;
}





