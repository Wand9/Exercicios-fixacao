//3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. 
//Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), 


//sabendo-se que: - Se quantidade &lt;= 5 o desconto será de 2% - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3% - Se quantidade &gt; 10 o desconto será de 5% Dica: utilize if / else if / else

static float chocolateAoLeite(float quantidade, float preco)
{
    if (quantidade <= 5)
    {
        return (quantidade * preco) * 0.98f;
    }

    else if (quantidade >5 && quantidade <= 10 )
    {
        return (quantidade * preco) * 0.97f;
    }

    else 
    {
        return (quantidade * preco) * 0.95f;
    }
}

static float chocolateBranco(float quantidade, float preco)
{

    if (quantidade <= 5)
    {
        return (quantidade * preco) * 0.98f;
    }

    else if(quantidade > 5 && quantidade <= 10 )
    {
        return (quantidade * preco) * 0.97f;
    }

    else 
    {
        return (quantidade * preco) * 0.95f;
    }

}

Console.WriteLine($"Bem vindo ao atacado doces!");

float precochocolateAoLeite = 10.00f;
float precochocolateBranco = 14.00f;

float quantidadechocolateAoLeite;
float quantidadechocolateBranco;

float precototal;

char opcao;

{
    Console.WriteLine(@$"
    Informe o chocolate:
    (A) - Chocolate ao leite
    (B) - Chocolate branco
    ");
        opcao = char.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 'A':
                Console.WriteLine($"Informe a quantidade de chocolates: ");
                quantidadechocolateAoLeite = float.Parse(Console.ReadLine());

                precototal = chocolateAoLeite(quantidadechocolateAoLeite, precochocolateAoLeite);

                Console.WriteLine($"O valor total dos seus chocolates ao leite e : {precototal} ");

                break;
            default:
                break;
        }
        
}


