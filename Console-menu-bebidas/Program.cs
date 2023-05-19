Console.WriteLine(@$"
---------------------------
|    menu de bebidas      |
|1-Suco de laranja        |
|2-Coca-cola              |
|3-Fanta laranja          |
|4-Guarana                |
---------------------------
");

Console.WriteLine($"Escolha sua bebida: ");
char bebida = char.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"Gostaria de adicionar gelo? ");
string adicional = Console.ReadLine().ToLower();

string bebidaEscolhida = "Bebida não definida"; 


switch (adicional)
{
    case "sim":
    adicional = "com gelo";
        break;

    case "nao":
    adicional = "sem gelo";
        break;

    default:
    Console.WriteLine($"gelo não selecionado");

        break;
}



switch (bebida)
{
    case '1':
    bebidaEscolhida = "Suco de laranja";
    Console.WriteLine($"Voce escolheu {bebidaEscolhida} {adicional}");

        break;
    case '2':
    bebidaEscolhida = "Coca-cola";
    Console.WriteLine($"Voce escolheu {bebidaEscolhida} {adicional}");

        break;
    case '3':
    bebidaEscolhida = "fanta laranja";
    Console.WriteLine($"Voce escolheu {bebidaEscolhida} {adicional}");

        break;
    case '4':
    bebidaEscolhida = "guarana";
    Console.WriteLine($" Voce escolheu {bebidaEscolhida} {adicional}");

        break;
    default: Console.WriteLine($"bebida não selecionada");

        break;
}