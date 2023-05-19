//Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano). Com os métodos, ligar, desligar, fazer ligação, enviar mensagem. Só será possível executar tais métodos se o celular estiver ligado. Envie o link do repositório como entrega desta atividade.

using Smarthphone;

Celular novoCelular = new Celular();

Console.WriteLine($"Informe a cor do celular: ");
novoCelular.cor = Console.ReadLine();

Console.WriteLine($"Informe o modelo do seu celular: ");
novoCelular.Modelo = Console.ReadLine();

Console.WriteLine($"Informe o tamanho do seu celular: ");
novoCelular.tamanho = Console.ReadLine();

Console.WriteLine($"O celular esta ligado ? (s/n) ");
string ligado = Console.ReadLine().ToLower();

if (ligado == "s")
{
    novoCelular.ligado = true;
    Console.WriteLine($"O seu aparelho esta ligado!");

    Console.WriteLine(@$"Escolha uma opcao:
    1) Ligar o aparelho
    2) Fazer ligacao
    3) Enviar mensagem
    0) Desligar o aparelho ");
    
}

else if (ligado == "n")
{
    Console.WriteLine($"O seu aparelho esta desligado");

    Console.WriteLine(@$"Escolha uma opcao:
    1) Ligar o aparelho
    2) Fazer ligacao
    3) Enviar mensagem
    0) Desligar o aparelho ");
    
}
char menuEscolha = char.Parse(Console.ReadLine());

switch (menuEscolha)
{
    case '1':
        Console.WriteLine($"Ligando o aparelho! ");
        novoCelular.ligado = false;
        break;

        while (menuEscolha == '1')
{
    Console.WriteLine($"Deseja realizar alguma operação ?");
    char escolha2 = char.Parse(Console.ReadLine());

    Console.WriteLine(@$"Escolha uma opcao:
    1) Ligar o aparelho
    2) Fazer ligacao
    3) Enviar mensagem
    0) Desligar o aparelho ");
}
        
    case '2':
        Console.WriteLine($"Ligue o aparelho primeiro! ");
        novoCelular.ligado = false;
        break;
        
    case '3':
        Console.WriteLine($"Ligue o aparelho primeiro! ");
        novoCelular.ligado = false;
        break;
        
    case '0':
        Console.WriteLine($"O aparelho ja esta desligado! ");
        novoCelular.ligado = false;
        break;
}
