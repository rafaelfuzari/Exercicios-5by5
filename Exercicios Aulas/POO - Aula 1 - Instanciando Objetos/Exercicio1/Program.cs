Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.Write("\nDigite o seu saldo:");
double saldo = double.Parse(Console.ReadLine());

ContaBancaria p1 = new(nome, saldo);

while (true) {
    Console.WriteLine("-Digite a sua opção-\n1 - Checar saldo\n2 - Sacar\n3 - Depositar\n 4-Exibir dados da conta");
    int opcao = int.Parse(Console.ReadLine());
    if (opcao > 5 || opcao < 0) continue;
    switch (opcao)
    {
        case 1:
            p1.ExibirSaldo();
            break;
        case 2:
            Console.Write("\nDigite o valor a ser sacado: ");
            p1.Sacar(double.Parse(Console.ReadLine()));
            break;
        case 3:
            Console.Write("\nDigite o valor a ser depositado: ");
            p1.Depositar(double.Parse(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine(p1.ToString());
            break;
    }
}

