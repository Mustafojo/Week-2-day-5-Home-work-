using Domain.Models;
using Infrastructure.Servises;

var student1 = new Student();
student1.Id = 1;
student1.FirstName = "Mustafo";
student1.LastName = "Barotov";
student1.Address = "33mkr";
student1.BirthDate = new DateTime(2007,09,26);

var student2 = new Student();
student2.Id = 2;
student2.FirstName = "Mahdi";
student2.LastName = "Barotov";
student2.Address = "82xmkr";
student2.BirthDate = new DateTime(2007,08,23);

var stuser = new StudentService();
stuser.AddStudent(student1);
stuser.AddStudent(student2);


foreach (var item in stuser.GetStudents())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"AddRess: {item.Address}");
    System.Console.WriteLine($"BirthDate: {item.BirthDate}");
    System.Console.WriteLine("**************************");
}


var updatedStudent = new Student();
updatedStudent.Id = 1;
updatedStudent.FirstName = "Abubakr";
updatedStudent.LastName = "Barotov";
updatedStudent.Address = "Rohi Nav";
updatedStudent.BirthDate = new DateTime(2001,02,21);

stuser.UpdateStudent(updatedStudent);

foreach (var item in stuser.GetStudents())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"AddRess: {item.Address}");
    System.Console.WriteLine($"BirthDate: {item.BirthDate}");
    System.Console.WriteLine("**************************");
}

stuser.DeleteStudent(1);
foreach (var item in stuser.GetStudents())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"AddRess: {item.Address}");
    System.Console.WriteLine($"BirthDate: {item.BirthDate}");
    System.Console.WriteLine("**************************");
}

System.Console.WriteLine("///////////////////////////////////////////////");



var teacher1 = new Teacher();
teacher1.Id = 1;
teacher1.FirstName = "Mustafo";
teacher1.LastName = "Barotov";
teacher1.Position = "Maktab";
teacher1.ExperienceAmount = 11;

var teacher2 = new Teacher();
teacher2.Id = 2;
teacher2.FirstName = "Mahdi";
teacher2.LastName = "Barotov";
teacher2.Position = "Donishgoh";
teacher2.ExperienceAmount = 23;

var teachser = new TeacherService();
teachser.AddTeacher(teacher1);
teachser.AddTeacher(teacher2);


foreach (var item in teachser.GetTeacher())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"Position: {item.Position}");
    System.Console.WriteLine($"ExperienceAmount: {item.ExperienceAmount}");
    System.Console.WriteLine("**************************");
}


var updatedTeacher = new Teacher();
updatedTeacher.Id = 1;
updatedTeacher.FirstName = "Abubakr";
updatedTeacher.LastName = "Barotov";
updatedTeacher.Position = "Sadik";
updatedTeacher.ExperienceAmount = 6;

teachser.UpdateTeacher(updatedTeacher);

foreach (var item in teachser.GetTeacher())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"Position: {item.Position}");
    System.Console.WriteLine($"ExperienceAmount: {item.ExperienceAmount}");
    System.Console.WriteLine("**************************");
}

teachser.DeleteTeacher(1);
foreach (var item in teachser.GetTeacher())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"Position: {item.Position}");
    System.Console.WriteLine($"ExperienceAmount: {item.ExperienceAmount}");
    System.Console.WriteLine("**************************");
}
System.Console.WriteLine("///////////////////////////////////////////////");


var post1 = new Post();
post1.Id = 1;
post1.Title = "Football";
post1.Description = "Livarpool";
post1.VoteAmount = 34;
post1.CreatedAt =  new DateTime(2023,07,10);

var post2 = new Post();
post2.Id = 2;
post1.Title = "Bascetball";
post1.Description = "Los-Angless";
post1.VoteAmount = 23;
post1.CreatedAt =  new DateTime(2023,05,12);

var postser = new PostService();
postser.AddPost(post1);
postser.AddPost(post2);


foreach (var item in postser.GetPost())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: {item.Description}");
    System.Console.WriteLine($"VoteAmount: {item.VoteAmount}");
    System.Console.WriteLine($"CreatedAt: {item.CreatedAt}");
    System.Console.WriteLine("**************************");
}


var updatePost = new Post();
updatePost.Id = 1;
updatePost.Title = "ValleyBall";
updatePost.Description = "Japan";
updatePost.VoteAmount = 57;
updatePost.CreatedAt =  new DateTime(2023,02,12);

postser.UpdatePost(updatePost);

foreach (var item in postser.GetPost())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: {item.Description}");
    System.Console.WriteLine($"VoteAmount: {item.VoteAmount}");
    System.Console.WriteLine($"CreatedAt: {item.CreatedAt}");
    System.Console.WriteLine("**************************");
}

postser.DeletePost(1);
foreach (var item in postser.GetPost())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: {item.Description}");
    System.Console.WriteLine($"VoteAmount: {item.VoteAmount}");
    System.Console.WriteLine($"CreatedAt: {item.CreatedAt}");
    System.Console.WriteLine("**************************");
}

System.Console.WriteLine("///////////////////////////////////////////////");




var course1 = new Course();
course1.Id = 1;
course1.Title = "C#";
course1.Description = "OOP";
course1.Fee = 1500;
course1.HasDiscount =  true;

var course2 = new Course();
course2.Id = 2;
course1.Title = "JS";
course1.Description = "OOP";
course1.Fee = 1500;
course1.HasDiscount =  false;

var courceSer = new CourceService();
courceSer.AddCourse(course1);
courceSer.AddCourse(course2);


foreach (var item in courceSer.GetCource())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: {item.Description}");
    System.Console.WriteLine($"Fee: {item.Fee}");
    System.Console.WriteLine($"HasDiscount: {item.HasDiscount}");
    System.Console.WriteLine("**************************");
}


var updatedCource = new Course();
updatedCource.Id = 1;
updatedCource.Title = "C++";
updatedCource.Description = "OOP";
updatedCource.Fee = 1000;
updatedCource.HasDiscount = false;

courceSer.UpdateCourse(updatedCource);

foreach (var item in courceSer.GetCource())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: {item.Description}");
    System.Console.WriteLine($"Fee: {item.Fee}");
    System.Console.WriteLine($"HasDiscount: {item.HasDiscount}");
    System.Console.WriteLine("**************************");
}


courceSer.DeleteCourse(1);

foreach (var item in courceSer.GetCource())
{
    System.Console.WriteLine($"Id: {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: {item.Description}");
    System.Console.WriteLine($"Fee: {item.Fee}");
    System.Console.WriteLine($"HasDiscount: {item.HasDiscount}");
    System.Console.WriteLine("**************************");
}





