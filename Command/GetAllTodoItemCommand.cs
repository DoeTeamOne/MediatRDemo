using MediatR;
using MediatRDemo.Entity;
using MediatRDemo.Repo;

namespace MediatRDemo.Command
{
    public class GetAllTodoItemCommand:IRequest<List<TodoItem>>
    {

    }
    public class GetAllTodoItemCommandHandler : IRequestHandler<GetAllTodoItemCommand, List<TodoItem>>
    {
        private readonly IMemoryRepo _repo;

        public GetAllTodoItemCommandHandler(IMemoryRepo repo)
        {
            _repo = repo;
        }
        public async Task<List<TodoItem>> Handle(GetAllTodoItemCommand request, CancellationToken cancellationToken)
        {
            return _repo.AlltodoItems();
        }
    }
}
