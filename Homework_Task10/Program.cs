namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int number = new Random().Next(100,1000);
        Console.WriteLine(number);
        string str = Convert.ToString(number);
        Console.WriteLine($"{str[1]}");
        }
    }
}
