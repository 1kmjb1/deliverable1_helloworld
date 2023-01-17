namespace deliverable1_helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter the user's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);

        }
    }
}