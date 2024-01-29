using Domain.Models;

namespace Infrastructure.Servises;

public class PostService
{

    List<Post> posts = new List<Post>();
    public List<Post> GetPost()
    {
        return posts;
    }
    public void AddPost(Post post)
    {
        posts.Add(post);
    }
    public void UpdatePost(Post post)
    {
        foreach (var p in posts)
        {
            if (p.Id == post.Id)
            {
                p.Title = post.Title;
                p.Description = post.Description;
                p.CreatedAt = post.CreatedAt;
                p.VoteAmount = post.VoteAmount;
                System.Console.WriteLine("Post updated successfully! ");
                 System.Console.WriteLine("***************************");

                break;
            }
            System.Console.WriteLine("Post not found !");
        }
        
    }
    public void DeletePost(int id)
    {
        foreach (var pos in posts)
        {
            if (pos.Id == id)
            {
                posts.Remove(pos);
                System.Console.WriteLine("Post Deleted successfully!");
                 System.Console.WriteLine("***************************");

                break;
            }
             System.Console.WriteLine("Post not found! ");
        }
       
    }
}
