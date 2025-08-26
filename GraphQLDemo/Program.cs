using GraphQLDemo.GraphQL;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddInMemorySubscriptions();


var app = builder.Build();
app.UseWebSockets();
app.MapGraphQL();
//app.MapGraphQLVoyager("/voyager");
app.Run();
