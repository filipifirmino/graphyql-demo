namespace GraphQLDemo.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Content { get; set; }
}