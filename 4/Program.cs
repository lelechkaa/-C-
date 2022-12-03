Console.WriteLine("Ведите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Ведите третье число");
int numberThird = Convert.ToInt32(Console.ReadLine()); 


if(numberFirst > numberSecond)
{
    if(numberFirst > numberThird)
{
    Console.WriteLine($"max = " + numberFirst);
}

else
{
    Console.WriteLine($"max = " + numberThird);
}
}

else if(numberSecond > numberThird)
{
    Console.WriteLine($"max = " + numberSecond);
}

else
{
    Console.WriteLine($"max = " + numberThird);
}