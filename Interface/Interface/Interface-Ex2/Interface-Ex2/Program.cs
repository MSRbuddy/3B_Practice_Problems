namespace Interface_Ex2
{
    interface IFirstInterface
    {
        void Fruits(); // interface method
    }

    interface ISecondInterface
    {
        void DryFruits(); // interface method
    }

    // Implement multiple interfaces
    class Food : IFirstInterface, ISecondInterface
    {
        public void Fruits()
        {
            Console.WriteLine("Fruits are good to health.");
            Console.Write("\n");
        }
        public void DryFruits()
        {
            Console.WriteLine("DryFruits are good to health.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Food myObj = new Food();
            myObj.Fruits();
            myObj.DryFruits();
        }
    }
}