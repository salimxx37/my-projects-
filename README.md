using System;

class Person
{
    public string Name;
    public string Email;
    public Person(string name, string email)
    {
        Name = name;
        Email = email;
    }
    public void DisplayBasicInfo()

    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Email : {Email}");
    }
}
class Student : Person
{
    public string StudentId;
    public double GPA;
    public Student(string name, string email, string studentId, double gpa) : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;
    }
    public void DisplayStudentInfo()

    {
        Console.WriteLine("ــــــــــــــــــــــــــــ ");

        Console.WriteLine("Studint Informition");
        Console.WriteLine("ــــــــــــــــــــــــــــ ");
      DisplayBasicInfo();
        Console.WriteLine($"Studint ID : {StudentId}");
        Console.WriteLine($"Studint GPA : {GPA}");
    }
}
class Employee : Person
{
    public string EmployeeId;
    public double Salary;
    public void DisplayEmployeeInfo()

    {
        Console.WriteLine("ــــــــــــــــــــــــــــ ");

        Console.WriteLine("Employee Informition");
        Console.WriteLine("ــــــــــــــــــــــــــــ ");
      DisplayBasicInfo();
        Console.WriteLine($"Employee ID : {EmployeeId}");
        Console.WriteLine($"Employee salary : {Salary}");

    }

    public Employee(string name, string email, string employeeId, double salary) : base(name, email)
    {
        Salary = salary;
        EmployeeId = employeeId;
    }
}
class Teacher : Employee
{
    public string CoursName;

   public Teacher(string name, string email, string employeeId, string cours_name, double salary) : base(name, email, employeeId, salary)
    {
        CoursName = cours_name;
    }
    public void DisplayTeacherInfo()

    {
        
        Console.WriteLine("ــــــــــــــــــــــــــــ ");
       DisplayEmployeeInfo();
        Console.WriteLine($"Courcs : {CoursName}");
    }
    public void Teach()
    {
        Console.WriteLine("ــــــــــــــــــــــــــــ ");

        Console.WriteLine($"Teacher {Name} teach {CoursName} cours");
    }
}

class program
{
    public static void Main(string[] args)
    {

        Student studint1 = new Student("Omar Saeed", "omar454@gmail.com", "86545", 2.84);
        studint1.DisplayStudentInfo();

        Employee employee1 = new Employee("Ali Ahmed", "ali123@gmail.com", "98765", 100000);
        employee1.DisplayEmployeeInfo();

        Teacher teacher1 = new Teacher("Fahed Ahmad", "famd6544@gmail.com", "13464", "Math", 120000);
        teacher1.DisplayTeacherInfo();
        teacher1.Teach();

    }
}
