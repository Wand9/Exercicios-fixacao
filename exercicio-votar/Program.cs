//Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"");

Console.WriteLine($"Informe o ano em que nasceu: ");
int anoNascimento = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());

int idade = ( anoAtual - anoNascimento );

if( idade >= 16 )
{
    Console.WriteLine($"Ja pode votar! ");
}

if( idade < 16 )
{
    Console.WriteLine($"Ainda nao pode votar! ");
}