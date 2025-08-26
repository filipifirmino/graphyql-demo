# GraphQL Demo - Projeto Base

Um projeto base para implementação de APIs GraphQL usando ASP.NET Core 9.0 e HotChocolate.

## 📋 Descrição

Este projeto demonstra a implementação de um padrão GraphQL completo com:
- **Queries** para consultas de dados
- **Mutations** para modificações de dados
- **Subscriptions** para notificações em tempo real
- **WebSockets** para comunicação bidirecional
- **HotChocolate** como servidor GraphQL

## 🚀 Tecnologias Utilizadas

- **.NET 9.0** - Framework de desenvolvimento
- **ASP.NET Core** - Plataforma web
- **HotChocolate** - Servidor GraphQL para .NET
- **WebSockets** - Para subscriptions em tempo real

## 📦 Dependências

```xml
<PackageReference Include="HotChocolate.AspNetCore" Version="15.1.8" />
<PackageReference Include="HotChocolate.AspNetCore.Voyager" Version="10.5.5" />
<PackageReference Include="HotChocolate.Subscriptions.InMemory" Version="15.1.8" />
```

## 🏗️ Estrutura do Projeto

```
GraphQLDemo/
├── GraphQL/
│   ├── Query.cs          # Definições de consultas
│   ├── Mutation.cs       # Definições de mutações
│   └── Subscription.cs   # Definições de inscrições
├── Models/
│   ├── User.cs           # Modelo de usuário
│   └── Post.cs           # Modelo de post
├── Program.cs             # Configuração da aplicação
└── GraphQLDemo.csproj    # Arquivo do projeto
```

## 🎯 Funcionalidades Implementadas

### Queries
- `GetUser()` - Retorna um usuário com seus posts

### Mutations
- `AddUser(name)` - Cria um novo usuário e dispara evento de subscription

### Subscriptions
- `OnUserCreated` - Escuta eventos de criação de usuários

### Modelos de Dados
- **User**: Id, Name, Posts
- **Post**: Id, Title, Content, CreatedAt

## 🚀 Como Executar

### Pré-requisitos
- .NET 9.0 SDK instalado
- Visual Studio 2022 ou VS Code

### Passos para Execução

1. **Clone o repositório**
   ```bash
   git clone [url-do-repositorio]
   cd GraphQLDemo
   ```

2. **Restaura as dependências**
   ```bash
   dotnet restore
   ```

3. **Executa o projeto**
   ```bash
   dotnet run
   ```

4. **Acessa o endpoint GraphQL**
   - URL: `http://localhost:5000/graphql`
   - Playground GraphQL integrado

## 🔧 Configuração

### Program.cs
```csharp
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddInMemorySubscriptions();
```

### Endpoints
- **GraphQL**: `/graphql` - Endpoint principal
- **WebSockets**: Habilitado para subscriptions
- **Voyager**: Comentado (descomente para habilitar)

## 📝 Exemplos de Uso

### Query de Usuário
```graphql
query {
  getUser {
    id
    name
    posts {
      id
      title
      content
      createdAt
    }
  }
}
```

### Mutation para Criar Usuário
```graphql
mutation {
  addUser(name: "João Silva") {
    id
    name
  }
}
```

### Subscription para Novos Usuários
```graphql
subscription {
  onUserCreated {
    id
    name
  }
}
```

## 🎨 Personalização

### Adicionando Novos Tipos
1. Crie o modelo em `Models/`
2. Adicione as operações em `GraphQL/`
3. Registre no `Program.cs`

### Configurando HotChocolate
- Modifique as opções no `Program.cs`
- Adicione validações e autorizações
- Configure cache e rate limiting

## 🔍 Debugging e Desenvolvimento

### Logs
- Configure níveis de log no `appsettings.Development.json`
- Use o playground GraphQL para testar queries

### Hot Reload
- O projeto suporta hot reload durante desenvolvimento
- Alterações nos arquivos GraphQL são aplicadas automaticamente

## 📚 Recursos Adicionais

- **Documentação HotChocolate**: [https://chillicream.com/docs/hotchocolate](https://chillicream.com/docs/hotchocolate)
- **GraphQL Specification**: [https://graphql.org/](https://graphql.org/)
- **ASP.NET Core**: [https://docs.microsoft.com/pt-br/aspnet/core/](https://docs.microsoft.com/pt-br/aspnet/core/)

## 🤝 Contribuição

1. Fork o projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## 📞 Suporte

Para dúvidas ou suporte:
- Abra uma issue no repositório
- Consulte a documentação do HotChocolate
- Verifique os exemplos no playground GraphQL

---

**Desenvolvido com ❤️ usando .NET e GraphQL**
