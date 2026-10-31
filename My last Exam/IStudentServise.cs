interface IStudentService
{
    void AddStudent(Student student);

    void DisplayStudents();

    void UpdateStudent(int id);

    void DeleteStudent(int id);

    void SearchByName(string name);

    void SearchByGroup(string group);
}