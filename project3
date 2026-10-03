
using System.Security.Cryptography.X509Certificates;

class  Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
    public virtual void DisplayInfo()

    {
        Console.WriteLine($"Name : {Name}");
      
    }
}
class Student : Person
{
    public string StudentId;

    public Student( string name,string studentId) : base(name)
    {
        Name = name;
        StudentId = studentId;
      
    }
    public override void DisplayInfo()

    {


        Console.WriteLine(" Informition");
        Console.WriteLine("");
        Console.WriteLine($"Studint Name : {Name}");
        Console.WriteLine($"Studint ID : {StudentId}");
        Console.WriteLine("ــــــــــــــــــــــــــــ ");

    }
}
class Employee : Person
{
    public string EmployeeId;
    public double Salary;
    public Employee(string name, double salary) : base(name)
    {
        Name = name;
        Salary = salary;

    }
    public override void DisplayInfo()
    {


        Console.WriteLine(" Informition");
        Console.WriteLine("");

        Console.WriteLine($"Employee Name : {Name}");

        Console.WriteLine($"Employee salary : {Salary}");
        Console.WriteLine("ــــــــــــــــــــــــــــ ");
    }

  
}
 sealed class Teacher : Person
{
    public string CoursName;

    public Teacher(string name, string cours_name) : base(name)
    {
        CoursName = cours_name;
    }
    public override void DisplayInfo()

    {

        Console.WriteLine(" Informition");
        Console.WriteLine("");
        Console.WriteLine($"Teacher Name: {Name} ");
        Console.WriteLine($"Teacher Cours Name: {CoursName}");
        Console.WriteLine("ــــــــــــــــــــــــــــ ");
    }
   
}

class program
{
    public static void DisplayPersonInfo(Person person)
    { person.DisplayInfo(); }
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee("Ali Ahmed", 100000);


        Teacher teacher1 = new Teacher("Fahed Ahmad", "Math");

        Student studint1 = new Student("Omar Saeed", "86545");

        List<Person> members = new List<Person>();
        members.Add(teacher1);
        members.Add(employee1);
        members.Add(studint1);

        DisplayPersonInfo( teacher1); DisplayPersonInfo(studint1); DisplayPersonInfo(employee1);
        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");

        foreach (Person member in members)
        {
            Console.WriteLine(member.GetType().Name);

            member.DisplayInfo();
        }



}
}
