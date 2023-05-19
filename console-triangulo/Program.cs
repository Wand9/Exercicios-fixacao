Console.WriteLine($"Descubra qual o seu triângulo!");

Console.WriteLine($"Informe qual a primeira medida do seu triângulo: ");
float medida1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a segunda medida do seu triângulo: ");
float medida2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a terceira medida do seu triângulo: ");
float medida3 = float.Parse(Console.ReadLine());

if(medida1 == medida2 && medida2 == medida3)
{
    Console.WriteLine($"Seu triângulo é Equilátero! ");
}

else if(medida1 != medida2 && medida2 != medida3)
{
    Console.WriteLine($"Seu triângulo é Escaleno! ");
}

else if(medida1 != medida2 && medida2 == medida3)
{
    Console.WriteLine($"Seu triângulo é Isóscele! ");
}

else if(medida1 == medida2 && medida2 != medida3)
{
    Console.WriteLine($"Seu triângulo é Isóscele!");
}