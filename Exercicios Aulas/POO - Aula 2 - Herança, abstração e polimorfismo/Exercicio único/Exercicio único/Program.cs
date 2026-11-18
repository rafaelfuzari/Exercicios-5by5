ContaCorrente cc = new ContaCorrente(5412, 0);
ContaPoupanca cp = new ContaPoupanca(5411, 0);
ContaSalario cs = new ContaSalario(5410, 0);

int num;
double valor;




while (true)
{
    Console.WriteLine("Bem vindo ao banco Master");
    Console.WriteLine("Para facilitar a sua vida (e a do programador) criamos três contas para você, uma para cada tipo que oferecemos:" +
        " Corrente, Salário e Poupança");
    Console.WriteLine($"""
        Segue os dados das contas:
        {cc.ToString()}
        {cs.ToString()}
        {cp.ToString()}
        """);
    Console.WriteLine("\n\n");
    Console.WriteLine("""
        -Menu Opções-
        1 - Sacar
        2 - Depositar
        3 - Transferir
        4 - Pagar
        5 - Ver informações das contas
        """);
    Console.WriteLine("Escolha a opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o número da conta a ser sacado");
            num = int.Parse(Console.ReadLine());
            if (num == 5412) cc.Sacar();
            else if (num == 5411) cp.Sacar();
            else if (num == 5410) cs.Sacar();
            break;
        case 2:
            Console.WriteLine("Digite o número da conta a ser depositado");
            num = int.Parse(Console.ReadLine());
            if (num == 5412) cc.Depositar();
            else if (num == 5411) cp.Depositar();
            else if (num == 5410) cs.Depositar();
            cc.AtualizarLimite();
            break;
        case 3:
            Console.WriteLine("Digite o número da conta da qual vai ser transferido(vai sair o dinheiro dessa conta)");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta alvo");
            int alvo = int.Parse(Console.ReadLine());

            if (num == 5412)
            {
                if (alvo == 5411) cc.Transferir(cp);
                else if (alvo == 5410) cc.Transferir(cs);
                else Console.WriteLine("Conta alvo inválida, só de raiva vai voltar pro inicio");
            }
            else if (num == 5411)
            {
                if (alvo == 5412) cp.Transferir(cc);
                else if (alvo == 5410) cp.Transferir(cs);
                else Console.WriteLine("Conta alvo inválida, só de raiva vai voltar pro inicio");
            }
            else if (num == 5410)
            {
                if (alvo == 5412) cs.Transferir(cc);
                else if (alvo == 5411) cs.Transferir(cp);
                else Console.WriteLine("Conta alvo inválida, só de raiva vai voltar pro inicio");
            }
            break;
        case 4:
            Console.WriteLine("Digite o número da conta que vai ser descontado o pagamento");
            num = int.Parse(Console.ReadLine());
            if (num == 5412) cc.Pagar();
            else if (num == 5411) cp.Pagar();
            else if (num == 5410) cs.Pagar();
            break;
        case 5:
            Console.WriteLine(cc.ToString());
            Console.WriteLine(cp.ToString());
            Console.WriteLine(cs.ToString());
            break;

    }

    Console.ReadLine();
    Console.Clear();
    

    
}
