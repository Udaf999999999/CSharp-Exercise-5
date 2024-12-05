namespace Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) user;
            Console.WriteLine("Enter your name:");
            user.Name = Console.ReadLine();

            user.Dishes = new string[5];

            for (int i = 0; i < user.Dishes.Length; i++)
            {
                Console.WriteLine("Write your " + (i + 1) + " favorite dish.");
                user.Dishes[i] = Console.ReadLine();
            }
        }
    }
}
