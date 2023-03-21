
Console.WriteLine("Digite o número que você quiser, eu vou adivinhar se ele é par ou impar. Duvida? Aaaaaaaah, nem vou falar o restos");
Thread.Sleep(5000);

Console.Clear();

Console.Write(">");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine($"{number} é par. HA! ACERTEI!");
}
else{


Console.WriteLine($"{number} é impar. HA! SOU MUITO BOM!");
}
 ///  % = para pegar o resto de uma divisão if  o numero divido por 2 for igual a 0   *leozinho passou aqui* ///