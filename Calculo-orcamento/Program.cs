Console.WriteLine(@$"
-----------------------------
|   Programa para calcular  |
|       orçamento           |
-----------------------------
");

Console.WriteLine($"Informe seu salario: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe seu gasto: ");
float gasto = float.Parse(Console.ReadLine());

float orçamento = ( salario - gasto );


if (salario >= gasto)
{
    Console.WriteLine($"Dentro do orcamento!");
}

if (salario < gasto)
{
    Console.WriteLine($"Orcamento estourado");
}


 