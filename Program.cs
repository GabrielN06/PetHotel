string especie, raca, alcunha, pelagem;
int idade;

Console.WriteLine("Pet hotel \"Nem um pio\" \n");
Console.WriteLine("Preecha a ficha com informações do seu pet\n");

Console.WriteLine("FICHA: ");

Console.WriteLine("Digite a espécie: ");
especie = Console.ReadLine()!.ToUpper();

Console.WriteLine("Digite a raça: ");
raca = Console.ReadLine()!.ToUpper();

Console.WriteLine("Digite a alcunha: ");
alcunha = Console.ReadLine()!.ToUpper();

Console.WriteLine("Digite a idade: ");
idade = int.Parse(Console.ReadLine() ??"");

Console.WriteLine("Digite a pelagem: ");
pelagem = Console.ReadLine()!.ToUpper();

Console.Clear();

    Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

    Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|               Pet Hotel \"Nem um pio\"                    |");

    Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"| Espécie: {especie,-18} | Raça: {raca,-19} |");


     Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

    Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"| Atende pela alcunha de: {alcunha,-31} |");
Console.WriteLine($"| Idade: {idade,-2}ano(s) | Pelagem/cor: {pelagem,-24} |");

    Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

