Console.WriteLine($"Informe sua senha: ");
float senha = float.Parse(Console.ReadLine());

float validacao = ( 1234 );

if (senha == validacao)
{
    Console.WriteLine($"Acesso permitido! ");
}

else if ( senha != validacao)
{
    Console.WriteLine($"Acesso negado! ");
}