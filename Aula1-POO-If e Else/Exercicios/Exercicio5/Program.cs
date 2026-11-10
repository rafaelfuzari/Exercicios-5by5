int ano;

ano = 0;

Console.Write("Insira o ano: ");
ano = int.Parse(Console.ReadLine());



if (ano > 0 && ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)) Console.WriteLine("o ano foi bissexto");
else if (ano > 0) Console.WriteLine("O ano não foi bissexto");
else Console.WriteLine("Não existe ano negativo e nem zero! Para de tentar quebrar o sistema!!!");



