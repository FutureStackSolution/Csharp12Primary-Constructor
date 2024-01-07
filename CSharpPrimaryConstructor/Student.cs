namespace CSharpPrimaryConstructor
{
    public class Student(string firstName, string lastName, int standard)
    {
        private readonly string _firstName =firstName;
        private readonly string _lastName=lastName;
        private readonly int _standard= standard;

        //public Student(string firstName, string lastName, int standard)
        //{
        //    _firstName = firstName;
        //    _lastName = lastName;
        //    _standard = standard;
        //}

        public void PrintStudent()
        {
            Console.WriteLine("Following is a student details");
            Console.WriteLine($"FirstName: {_firstName}");
            Console.WriteLine($"Lastname: {_lastName}");
            Console.WriteLine($"Standard: {_standard}");
        }
    }
    public record StudentRecord(string firstName, string lastName, int standard)
    {
        // business logic and validations there
    }
    
}
