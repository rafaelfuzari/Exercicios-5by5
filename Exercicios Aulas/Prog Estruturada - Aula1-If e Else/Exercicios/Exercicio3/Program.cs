float nota1, nota2, nota3, nota4, media;

nota1 = 0f;
nota2 = 0f;
nota3 = 0f;
nota4 = 0f;

Console.Write("Informe a primeira nota:");
nota1 = float.Parse(Console.ReadLine());

Console.Write("Informe a segunda nota:");
nota2 = float.Parse(Console.ReadLine());

Console.Write("Informe a terceira nota:");
nota3 = float.Parse(Console.ReadLine());

Console.Write("Informe a quarta nota:");
nota4 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media < 0) Console.WriteLine($"A sua média foi:{media} \nCOMO QUE A NOTA DEU NEGATIVO?");
else if (media <= 5) Console.WriteLine($"A sua média foi:{media} \nREPROVADO!!");
else if (media < 7) Console.WriteLine($"A sua média foi:{media} \nRecuperação!");
else if (media < 10) Console.WriteLine($"A sua média foi:{media} \nAprovado!");
else Console.WriteLine("a nota tem que ser até 10 seu safado!");
