namespace CSharpPrimaryConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Primary Contructor");
        }
    }

    public class Student
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _standard;

        public Student(string firstName, string lastName, int standard)
        {
            _firstName = firstName;
            _lastName = lastName;
            _standard = standard;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Printing Student");
            Console.WriteLine($"FirstName: {_firstName}");
            Console.WriteLine($"Lastname: {_lastName}");
            Console.WriteLine($"Standard: {_standard}")
        }
    }
}
