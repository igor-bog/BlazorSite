using BlazorApp2.CQRS.Infrastructure;

namespace BlazorApp2.CQRS.Commands;

public record CreateUserCommand(string Name, string Email) : ICommand<Guid>;
