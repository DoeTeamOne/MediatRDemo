using MediatR;
using MediatRDemo.DTO;
using MediatRDemo.Entity;
using MediatRDemo.Repo;

namespace MediatRDemo.Command
{
    public class CreateTodoItemCommand:IRequest<TodoItem>
    {
        public TodoDTO CreatetodoRequest { get; set; }
    }

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, TodoItem>
    {
        private readonly IMemoryRepo _repo;

        public CreateTodoItemCommandHandler(IMemoryRepo repo)
        {
            _repo = repo;
        }
        public async Task<TodoItem> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
           return  _repo.CreateItem(request.CreatetodoRequest);
        }
    }
}
  