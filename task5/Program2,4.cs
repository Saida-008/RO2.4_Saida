using System;

class Student
{
    private static int nextId = 1;

    public string Name { get; set; }
    public int StudentId { get; }
    private double gpa;

    public double GPA
    {
        get { return gpa; }
        set
        {
            if (value >= 0.0 && value <= 4.0)
                gpa = value;
            else
                Console.WriteLine("GPA must be between 0.0 and 4.0!");
        }
    }

    public string Faculty { get; set; }

    public Student(string name, double gpa, string faculty)
    {
        Name = name;
        StudentId = nextId++;
        Faculty = faculty;
        GPA = gpa;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {StudentId}, Name: {Name}, GPA: {GPA}, Faculty: {Faculty}");
    }
}

class Registry
{
    private Student[] students = new Student[100];
    private int count = 0;

    public void Add(Student student)
    {
        if (count >= 100)
        {
            Console.WriteLine("Registry is full!");
            return;
        }

        students[count++] = student;
        Console.WriteLine("Student added.");
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
                return students[i];
        }
        return null;
    }

    public void FindByName(string name)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (students[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                students[i].Print();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No students found.");
    }

    public void GetTopStudents(int n)
    {
        if (n > count) n = count;

        Student[] temp = new Student[count];
        Array.Copy(students, temp, count);

        Array.Sort(temp, (a, b) => b.GPA.CompareTo(a.GPA));

        for (int i = 0; i < n; i++)
        {
            temp[i].Print();
        }
    }

    public void PrintAll()
    {
        if (count == 0)
        {
            Console.WriteLine("No students in registry.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            students[i].Print();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Registry registry = new Registry();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Student Registry ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Find by ID");
            Console.WriteLine("3. Find by Name");
            Console.WriteLine("4. Top N Students");
            Console.WriteLine("5. Print All");
            Console.WriteLine("0. Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("GPA: ");
                    if (!double.TryParse(Console.ReadLine(), out double gpa))
                    {
                        Console.WriteLine("Invalid GPA!");
                        break;
                    }

                    Console.Write("Faculty: ");
                    string faculty = Console.ReadLine();

                    registry.Add(new Student(name, gpa, faculty));
                    break;

                case "2":
                    Console.Write("Enter ID: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        var student = registry.FindById(id);
                        if (student != null)
                            student.Print();
                        else
                            Console.WriteLine("Student not found.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID!");
                    }
                    break;

                case "3":
                    Console.Write("Enter name: ");
                    registry.FindByName(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter N: ");
                    if (int.TryParse(Console.ReadLine(), out int n))
                        registry.GetTopStudents(n);
                    else
                        Console.WriteLine("Invalid number!");
                    break;

                case "5":
                    registry.PrintAll();
                    break;

                case "0":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}