using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQL;

public class Query
{
    public User GetUser() => new User
    {
        Id = 1, Name = "John Doe", Posts = new List<Post>
        {
            new Post { Id = 1, Title = "First Post", Content = "This is my first post." },
            new Post { Id = 2, Title = "Second Post", Content = "This is my second post." }
        }
    };
}