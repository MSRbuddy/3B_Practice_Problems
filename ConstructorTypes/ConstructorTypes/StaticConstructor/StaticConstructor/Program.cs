namespace StaticConstructor
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Executed!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Exceution Started...");
        }
    }
}