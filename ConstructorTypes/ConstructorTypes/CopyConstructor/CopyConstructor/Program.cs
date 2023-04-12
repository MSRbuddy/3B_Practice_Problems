namespace CopyConstructor
{
    public class CopyConstructor
    {
        int x;
        //Parameterized Constructor
        public CopyConstructor(int i)
        {
            x = i;
        }
        //Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(525);
            obj1.Display();
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Display();
        }
    }
}