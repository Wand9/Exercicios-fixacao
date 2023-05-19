Console.WriteLine($"Digite o nome do aluno: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo a consulta de media {nome} ;)");

Console.WriteLine($"informe sua primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());


Console.WriteLine($"informe sua segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());


Console.WriteLine($"informe sua terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());


Console.WriteLine($"informe sua quarta nota: ");
float nota4 = float.Parse(Console.ReadLine());


Console.WriteLine($"informe sua quinta nota: ");
float nota5 = float.Parse(Console.ReadLine());

float media = ( (nota1+nota2+nota3+nota4+nota5)/5);

Console.WriteLine($"A media do aluno é igual á: {media}" );