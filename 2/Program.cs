using tascN2_Classes;
Console.WriteLine("Продажа продукции за 5 дней:");
Hero[] steps = new Hero[5];
Random rand = new Random();

for (int i = 0; i < steps.Length; i++)
{
    steps[i] = new Hero(rand.Next(10000), rand.Next(10000), rand.Next(10000));
    Console.WriteLine(steps[i]);
}