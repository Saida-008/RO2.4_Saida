using System;

class Student
{
    public string Name { get; set; }
    public int StudentId { get; private set; }
    private double gpa;
    public string Faculty { get; set; }

    private static int nextId = 1;

    public double GPA
    {
        get { return gpa; }
        set
        {
            if (value >= 0.0 && value <= 4.0)
                gpa = value;
            else
                gpa = 0.0;
        }
    }

    public Student(string name, double gpa, string faculty)
    {
        Name = name;
        GPA = gpa;
        Faculty = faculty;
        StudentId = nextId++;
    }

    public void Print()
    {
        Console.WriteLine($"{StudentId} | {Name} | {GPA} | {Faculty}");
    }
}

class Registry
{
    private Student[] students = new Student[100];
    private int count = 0;

    public void Add(Student s)
    {
        if (count < 100)
            students[count++] = s;
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
            if (students[i].StudentId == id)
                return students[i];
        return null;
    }

    public Student FindByName(string name)
    {
        for (int i = 0; i < count; i++)
            if (students[i].Name.ToLower() == name.ToLower())
                return students[i];
        return null;
    }

    public void GetTopStudents(int n)
    {
        Student[] sorted = new Student[count];
        Array.Copy(students, sorted, count);

        Array.Sort(sorted, (a, b) => b.GPA.CompareTo(a.GPA));

        for (int i = 0; i < n && i < count; i++)
            sorted[i].Print();
    }

    public void PrintAll()
    {
        for (int i = 0; i < count; i++)
            students[i].Print();
    }
}

class Program
{
    static void Main()
    {
        Registry reg = new Registry();

        while (true)
        {
            Console.WriteLine("\n1 Add | 2 FindById | 3 FindByName | 4 Top | 5 All | 0 Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
                continue;

            if (choice == 0) break;

            switch (choice)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("GPA: ");
                    double gpa;
                    if (!double.TryParse(Console.ReadLine(), out gpa))
                        gpa = 0;

                    Console.Write("Faculty: ");
                    string fac = Console.ReadLine();

                    reg.Add(new Student(name, gpa, fac));
                    break;

                case 2:
                    Console.Write("ID: ");
                    int id;
                    if (int.TryParse(Console.ReadLine(), out id))
                    {
                        var s = reg.FindById(id);
                        if (s != null) s.Print();
                        else Console.WriteLine("Not found");
                    }
                    break;

                case 3:
                    Console.Write("Name: ");
                    string n = Console.ReadLine();

                    var s2 = reg.FindByName(n);
                    if (s2 != null) s2.Print();
                    else Console.WriteLine("Not found");
                    break;

                case 4:
                    Console.Write("n: ");
                    int top;
                    if (int.TryParse(Console.ReadLine(), out top))
                        reg.GetTopStudents(top);
                    break;

                case 5:
                    reg.PrintAll();
                    break;
            }
        }
    }
}