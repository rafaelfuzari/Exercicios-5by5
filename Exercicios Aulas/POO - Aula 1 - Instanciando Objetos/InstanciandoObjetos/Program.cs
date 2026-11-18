Carro c1 = new Carro("Renault", "Kwid", 2026, "2027", 94000.00f, "Gasolina", "1.0",70);
Carro c2 = new Carro("Nissan", "Versa", 2015, "2015", 47000.00f, "Gasolina", "1.6", 110);
Carro c3 = new Carro("Honda", "Civic", 2022, "2021", 115000.00f, "Etanol", "2.0", 150);
Carro c4 = new Carro("Volkswagen", "Gol G5", 2017, "2017", 38000.00f, "Etanol", "1.0", 76);


Carro[] cArray = new Carro[] { c1, c2, c3, c4 };

for (int i = 0; i < cArray.Length; i++)
{
    Console.WriteLine(cArray[i]);
}

