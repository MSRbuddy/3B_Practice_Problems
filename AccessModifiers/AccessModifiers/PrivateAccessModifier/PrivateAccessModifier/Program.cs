namespace Private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            //You cannot access the Private Member from the Derived Class
            //from Other Assemblies
            Console.WriteLine(Id); //Compile Time Error
        }
    }
    public class AnotherAssemblyClass2
    {
        public void Dispplay3()
        {
            //You cannot access the Private Member from the Non-Derived Classes
            //from Other Assemblies
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); //Compile Time Error
        }
    }
    //The scope of the Private members in C#.NET is as follows:

    //With the Class: YES
    //Derived Class in Same Assembly: NO
    //Non-Derived Class in Same Assembly: NO
    //Derived Class in Other Assemblies: NO
    //Non-Derived Class in Other Assemblies: NO
}