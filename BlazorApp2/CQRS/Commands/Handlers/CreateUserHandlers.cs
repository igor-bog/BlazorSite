using BlazorApp2.CQRS.Commands;
using BlazorApp2.CQRS.Infrastructure;

namespace BlazorApp2.CQRS.Handlers;

public class CreateUserHandler : ICommandHandler<CreateUserCommand, Guid>
{
    public Task<Guid> Handle(CreateUserCommand command)
    {
        // пока просто возвращаем Guid без сохранения в БД
        return Task.FromResult(Guid.NewGuid());
    }
}
