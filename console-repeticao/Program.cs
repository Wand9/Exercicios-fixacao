Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade (entre 0 e 100)" );
string idade = Console.ReadLine();

while (idade.Length > 100)
{
    Console.WriteLine($"Digite a idade dentro do aceito (maior do que 0 e menor de 100): ");
    idade = Console.ReadLine();     
}
Console.WriteLine($"Idade aceita");


Console.WriteLine($"Digite seu salario (Precisa ser maior do que 0)" );
string salario = Console.ReadLine();

while (salario.Length <= 0)
{
    Console.WriteLine($"Digite o salario que esteja dentro do padrao (maior do que 0): ");
    salario = Console.ReadLine();     
}
Console.WriteLine($"Salario aceito");


Console.WriteLine($"Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));" );
string estadoCivil = Console.ReadLine();

while (estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d")
{
    Console.WriteLine($"Adicione o estado civil da forma correta: ");
    estadoCivil = Console.ReadLine();     
}
Console.WriteLine($"Estado civil correto");







