Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine()); 
int count = 1;

while(number>0) 
{
    Console.WriteLine(count<=number);
    number++;
    if(number%2==0)
    {
        Console.WriteLine(number+ " ");
    }
}
