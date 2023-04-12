namespace Interface_Ex1
{
    interface ITestInterface1
    {
         void Add(int num1, int num2);
    }
    interface ITestInterface2 : ITestInterface1
    {
        void Sub(int num1, int num2);
    }
    public class ImplementationClass1 : ITestInterface1
    {
        //Implement only the Add method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
    public class ImplementationClass2 : ITestInterface2
    {
        //Implement Both Add and Sub method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Addition of {num1} and {num2} is {num1 + num2}");
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Subtraction of {num1} and {num2} is {num1 - num2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ImplementationClass1 obj1 = new ImplementationClass1();
            
            //Using obj1 we can only call Add method
            obj1.Add(5, 25);
            
            //We cannot call Sub method
            //obj1.Sub(100, 20);
            ImplementationClass2 obj2 = new ImplementationClass2();
            
            //Using obj2 we can call both Add and Sub method
            obj2.Add(10, 20);
            obj2.Sub(12, 2);
        }
    }
}