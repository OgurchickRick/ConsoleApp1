namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата: ");
            int side = Convert.ToInt32(Console.ReadLine());
            int perimeter = 4 * side;
            Console.WriteLine($"Периметр квадрата равен: {perimeter}");
        }
    }
}