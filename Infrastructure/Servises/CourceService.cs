using Domain.Models;

namespace Infrastructure.Servises;

public class CourceService
{
     List<Course> courses = new List<Course>();
    public List<Course> GetCource()
    {
        return courses;
    }
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
    public void UpdateCourse(Course cource)
    {
        foreach (var c in courses)
        {
            if(c.Id == cource.Id)
            {
                c.Title = cource.Title;
                c.Description = cource.Description;
                c.Fee = cource.Fee;
                c.HasDiscount = cource.HasDiscount;
                System.Console.WriteLine("Cource updated successfully! ");
                 System.Console.WriteLine("***************************");

                break;
            }
             System.Console.WriteLine("Cource not found !");
        }
       
    }
    public void DeleteCourse(int id)
    {
        foreach (var cou in courses)
        {
            if(cou.Id == id)
            {
                courses.Remove(cou);
                 System.Console.WriteLine("Cource deleted successfully! ");
                 System.Console.WriteLine("***************************");
                 break;
            }
             System.Console.WriteLine("Cource not found! ");
        }
       
    }
}
