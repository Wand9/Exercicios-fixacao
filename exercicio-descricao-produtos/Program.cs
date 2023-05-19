int indexProdutos = 0;
string[] produto = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];

void listagem()
{
    for (int i = 0; i < indexProdutos; i++)
    {
        if (promocao[indexProdutos] == true)
        {
            Console.WriteLine($"Produto #{i + 1}");
            Console.WriteLine($"Nome do produto: {produto[i]}");
            Console.WriteLine($"Preço do produto: R${preco[i]},00");
            Console.WriteLine($"Está em promoção?: sim");
            Console.WriteLine($"");
        }
        else
        {
            Console.WriteLine($"Produto #{i + 1}");
            Console.WriteLine($"Nome do produto: {produto[i]}");
            Console.WriteLine($"Preço do produto: R${preco[i]},00");
            Console.WriteLine($"Está em promoção?: não");
            Console.WriteLine($"");
        }
    }
}

static char menu()
{
Console.WriteLine(@$"                    -----------------------------------
                    |                                 |
                    |      ESTOQUE DE PRODUTOS        |       
                    |                                 |
                    -----------------------------------");
    

    Console.WriteLine(@$"
    O que deseja fazer?
    1 - Cadastrar produtos
    2 - Listar produtos
    0 - Sair
    ");
    return char.Parse(Console.ReadLine());
}

do
{
    switch (menu())
    {
        case '1':
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Informe o nome do #{i + 1} produto:");
                produto[indexProdutos] = Console.ReadLine();

                Console.WriteLine($"Informe o preço do produto:");
                preco[indexProdutos] = float.Parse(Console.ReadLine());

                Console.WriteLine($"O produto está em promoção? Digite 's' ou 'n'.");
                char escolhaPromo = char.Parse(Console.ReadLine());
                if (escolhaPromo == 's')
                {
                    promocao[indexProdutos] = true;
                }
                else
                {
                    promocao[indexProdutos] = false;
                }
                indexProdutos++;
                Console.WriteLine($"Produto cadastrado!");
                Console.WriteLine($"");
            }

            Console.WriteLine($"Gostaria de listar os produtos cadastrados? Digite 's' ou 'n'.");
            char respostaCadastro = char.Parse(Console.ReadLine());
            if (respostaCadastro == 's')
            {
                listagem();
            }
            else
            {
                Console.WriteLine($"");
            }
            break;

        case '2':
            listagem();
            break;
    }
} while (menu() != '0');