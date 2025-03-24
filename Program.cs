string especie, raca, alcunha, pelagem;
int idade;

Console.WriteLine("Pet hotel \"Nem um pio\" \n");
Console.WriteLine("Preecha a ficha com informações do seu pet\n");

Console.WriteLine("FICHA: ");

Console.Write("Digite a espécie: ");
especie = Console.ReadLine()!.ToUpper();

Console.Write("Digite a raça: ");
raca = Console.ReadLine()!.ToUpper();

Console.Write("Digite a alcunha: ");
alcunha = Console.ReadLine()!.ToUpper();

Console.Write("Digite a idade: ");
idade = int.Parse(Convert.ToString(Console.ReadLine()!));

Console.Write("Digite a pelagem: ");
pelagem = Console.ReadLine()!.ToUpper();

Console.Clear();

    Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

    Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|               Pet Hotel \"Nem um pio\"                    |");

    Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"| Espécie: {especie.PadLeft(18,'.')} | Raça: {raca.PadLeft(19,'.')} |");


     Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

    Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"| Atende pela alcunha de: {alcunha.PadLeft(31,'.')} |");
Console.WriteLine($"| Idade: {idade}ano(s) | Pelagem/cor: {pelagem.PadLeft(24,'.')} |");

    Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

