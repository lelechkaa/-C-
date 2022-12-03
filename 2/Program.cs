Console.WriteLine("Ведите первое число");
int numberfirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int numbersecond = Convert.ToInt32(Console.ReadLine()); 

if(numberfirst > numbersecond)
{
   Console.WriteLine($"max = {numberfirst}");
   Console.WriteLine($"min = {numbersecond}");
}

if(numbersecond > numberfirst)
{
    Console.WriteLine($"max = {numbersecond}");
    Console.WriteLine($"min = {numberfirst}");
}
