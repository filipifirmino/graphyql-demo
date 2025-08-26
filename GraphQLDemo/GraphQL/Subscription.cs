using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQL;

public class Subscription
{
    [Subscribe]
    [Topic]
    public User OnUserCreated([EventMessage] User user) => user;
}