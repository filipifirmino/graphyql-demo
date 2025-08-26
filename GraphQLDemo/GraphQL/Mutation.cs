using GraphQLDemo.Models;
using HotChocolate.Subscriptions;

namespace GraphQLDemo.GraphQL;

public class Mutation
{
    public async Task<User> AddUser(string name, [Service] ITopicEventSender sender)
    {
        var user = new User { Id = new Random().Next(1, 1000), Name = name };
        await sender.SendAsync(nameof(Subscription.OnUserCreated), user);
        {
            return user;
        }
    }
}