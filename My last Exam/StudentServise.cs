class StudentService : IStudentService
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void DisplayStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Id} {student.FullName} {student.Age} {student.Group}");
        }
    }

    public void UpdateStudent(int id)
    {
        try
        {
            Student student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)

                Console.Write("Enter name: ");
            student.FullName = Console.ReadLine();

            Console.Write("Enter age: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter group: ");
            student.Group = Console.ReadLine();


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void DeleteStudent(int id)
    {
        try
        {
            Student student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                students.Remove(student);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void SearchByName(string name)
    {
        Console.WriteLine(students.FindAll(x => x.FullName == name));
    }

    public void SearchByGroup(string group)
    {
        System.Console.WriteLine(students.FindAll(x => x.Group == group));
    }
}


