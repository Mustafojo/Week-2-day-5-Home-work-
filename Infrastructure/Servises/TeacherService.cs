using Domain.Models;

namespace Infrastructure.Servises;

public class TeacherService
{

    List<Teacher> teachers = new List<Teacher>();
    public List<Teacher> GetTeacher()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public void UpdateTeacher(Teacher teacher)
    {
        foreach (var t in teachers)
        {
            if(t.Id == teacher.Id)
            {
                t.FirstName = teacher.FirstName;
                t.LastName = teacher.LastName;
                t.Position = teacher.Position;
                t.ExperienceAmount = teacher.ExperienceAmount;
                System.Console.WriteLine("Techer updated successfully! ");
                 System.Console.WriteLine("***************************");

                break;
            }
            System.Console.WriteLine("Teacher not found !");
        }
        
    }
    public void DeleteTeacher(int id)
    {
        foreach (var tea in teachers)
        {
            if(tea.Id == id)
            {
                teachers.Remove(tea);
                 System.Console.WriteLine("Techer deleted successfully! ");
                 System.Console.WriteLine("***************************");

                 break;
            }
             System.Console.WriteLine("Teacher no found! ");
        }
       
    }
}

