namespace CSharpPrimaryConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Primary Contructor Demo");
            Student student= new Student("Andrew", "Smith", 20);
            StudentRecord studentRecord = new("Andrew", "Smith", 20);
           
            student.PrintStudent();
        }
    }
}
