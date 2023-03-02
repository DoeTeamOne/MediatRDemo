using MediatR;
using MediatRDemo.DTO;
using MediatRDemo.Entity;
using MediatRDemo.Repo;

namespace MediatRDemo.Command
{
    public class UpdateTodoItemCommand:IRequest<TodoItem>
    {
            public TodoItemUpdateRequest UpdateTodoRequest { get; set; }
    }
    public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateTodoItemCommand, TodoItem>
    {
        private readonly IMemoryRepo _repo;

        public UpdateTodoItemCommandHandler(IMemoryRepo repo)
        {
            _repo = repo;
        }
        public async Task<TodoItem> Handle(UpdateTodoItemCommand request, CancellationToken cancellationToken)
        {
            return _repo.UPdateItem(request.UpdateTodoRequest);   
        }
    }
}
