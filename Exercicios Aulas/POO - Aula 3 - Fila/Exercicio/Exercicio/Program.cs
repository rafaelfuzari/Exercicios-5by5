FilaPadrao filaPadrao = new FilaPadrao();
FilaPrioritaria filaPrioritaria = new FilaPrioritaria();
Senha senha = new Senha();

int contadorPrioritario = 0;
int contadorNormal = 1;


string saida = string.Empty;

void ChamarPrioritario()
{
    if (!filaPrioritaria.Vazio())
    {
        Console.WriteLine($"{filaPrioritaria.Head.Valor} está sendo chamado!");
        filaPrioritaria.Retirar();
        contadorPrioritario++;
        Thread.Sleep(5);
    }
}

void ChamarPadrao()
{
    if (!filaPadrao.Vazio())
    {
        Console.WriteLine($"{filaPadrao.Head.Valor} está sendo chamado!");
        filaPadrao.Retirar();
        contadorNormal++;
        Thread.Sleep(5);
    }
}
//gerando a fila de pessoas prioritarias
for (int i = 0; i < 20; i++)
{
    senha = new Senha();
    senha.GerarSenha("P");
    filaPrioritaria.Inserir(senha);
    
}

for (int i = 0; i < 8; i++)
{
    senha = new Senha();
    senha.GerarSenha("N");
    filaPadrao.Inserir(senha);

}

Console.WriteLine("-Fila Prioritaria");
filaPrioritaria.Imprimir();
Console.WriteLine("-Fila Padrão-");
filaPadrao.Imprimir();
int totalPessoas = filaPrioritaria.Contador + filaPadrao.Contador;

while(!filaPrioritaria.Vazio() ||!filaPadrao.Vazio()) {
    {
        if (contadorNormal >= 1 || filaPadrao.Vazio())
        {

            ChamarPrioritario();
            ChamarPrioritario();

        }
        
        if ((contadorPrioritario >= 2 || filaPrioritaria.Vazio()))
        {
            ChamarPadrao();
        }
    }
}

Console.ReadLine();


