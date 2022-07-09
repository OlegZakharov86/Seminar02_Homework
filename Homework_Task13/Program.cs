namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int number = new Random().Next(10,200);
        Console.WriteLine(number);
        string str = Convert.ToString(number);
        if (str.Length == 3)
        {
             Console.WriteLine($"{str[2]}");
        }
        else
        {
             Console.WriteLine("Третьей цифры нет");
        }
        }
    }
}
