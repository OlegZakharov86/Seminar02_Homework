namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int number = new Random().Next(1,8);
        Console.WriteLine(number);
        if (  number > 5 && number < 8)
        {
             Console.WriteLine("Сегодня выходной");
        }
        else
        {
             Console.WriteLine("Дуй на работу");
        }
        }
    }
}

