Console.WriteLine(@$"
--------------------------------
|  Saiba se o seu time venceu  |
--------------------------------
");

Console.WriteLine($"Quantos gols seu time fez: ");
float time1 = float.Parse(Console.ReadLine());

System.Console.WriteLine($"Quantos gols o time rival marcou: ");
float time2 = float.Parse(Console.ReadLine());

if(time1 > time2)
{
    Console.WriteLine($"O time 1 venceu!");
}

else if(time1 < time2)
{
    Console.WriteLine($"O time 2 venceu!");
}

if (time1 == time2)
{
    Console.WriteLine($"O jogo terminou empatado");
}