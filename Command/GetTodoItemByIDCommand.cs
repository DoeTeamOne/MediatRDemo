using MediatR;
using MediatRDemo.Entity;
using MediatRDemo.Repo;

namespace MediatRDemo.Command
{
    public class GetTodoItemByIDCommand:IRequest<TodoItem>
    {
        public string TodoId { get; set; } 
    }
    public class GetTododByIDCommandHandler : IRequestHandler<GetTodoItemByIDCommand, TodoItem>
    {
        private readonly IMemoryRepo _repo;

        public GetTododByIDCommandHandler(IMemoryRepo repo)
        {
            _repo = repo;
        }
        public async Task<TodoItem> Handle(GetTodoItemByIDCommand request, CancellationToken cancellationToken)
        {
           return _repo.GetItemById(request.TodoId);
        }
    }
}
