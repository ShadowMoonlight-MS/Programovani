namespace _03_dedicnost
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }
    }

    class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }

        public override void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am in grade {Grade}.");
        }
    }




    internal class Program
    {
        static void Main()
        {
         
            Person person = new Person("Alice");
            person.SayHello();

            Console.WriteLine();

            Student student = new Student("Bob", 10);
            student.SayHello();
        }
    }
}
