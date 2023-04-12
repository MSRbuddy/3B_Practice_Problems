namespace ProtectedAccessModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
   
    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            //We Can access the Protected Member from Derived Classes
            //from Other Assemblies
            Console.WriteLine(Id); //No-Compile Time Error
        }
    }
    public class AnotherAssemblyClass2
    {
        public void Dispplay3()
        {
            //We Cannot access the Protected Member from Non-Derived Classes
            //from Other Assemblies
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); // Compile Time Error
        }
    }
    //The scope of the protected members in C#.NET is as follows:
    //With the Class: YES
    //Derived Class in Same Assembly: YES
    //Non-Derived Class in Same Assembly: NO
    //Derived Class in Other Assemblies: YES
    //Non-Derived Class in Other Assemblies: NO
}