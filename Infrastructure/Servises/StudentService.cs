using Domain.Models;

namespace Infrastructure.Servises;

public class StudentService
{
    List<Student> students = new List<Student>();
    public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void UpdateStudent(Student student)
    {
        foreach (var s in students)
        {
            if (s.Id == student.Id)
            {
                s.FirstName = student.FirstName;
                s.LastName = student.LastName;
                s.BirthDate = student.BirthDate;
                s.Address = student.Address;
                System.Console.WriteLine("Student updated successfully! ");
                System.Console.WriteLine("******************************");
                break;
            }
                 System.Console.WriteLine("Student not found !");
        }
    }
    
    public void DeleteStudent(int id)
    {
        foreach (var stu in students)
        {
            if (stu.Id == id)
            {
                students.Remove(stu);
                System.Console.WriteLine("Student deleted succesfully");
                 System.Console.WriteLine("***************************");

                break;
            }
            System.Console.WriteLine("Student not found! ");
        }
       
    }
}

