using MediatR;
using MediatRDemo.Command;
using MediatRDemo.DTO;
using MediatRDemo.Repo;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [ApiController]
    [Route("Todo")]
    public class TodoController:ControllerBase
    {
        private readonly IMemoryRepo _repo;
        private readonly IMediator _mediator;

        public TodoController(IMemoryRepo repo,IMediator mediator) 
        {
            _repo = repo;
            _mediator = mediator;
        }

        [HttpPost("CreateTodo")]
        public  ActionResult CreateTodo(TodoDTO request)
        {
            CreateTodoItemCommand command = new CreateTodoItemCommand();
            command.CreatetodoRequest = request;

            var CommandResponse = _mediator.Send(command);
            return Ok(CommandResponse.Result);
        }

        [HttpGet("AllTodos")]
        public ActionResult AllTodos() 
        {
            GetAllTodoItemCommand command = new GetAllTodoItemCommand();    

        var CommandResponse =_mediator.Send(command);
            return Ok(CommandResponse.Result);
        }

        [HttpGet("Items/{id}")]
        public ActionResult GetTodo(string id)
        {
            GetTodoItemByIDCommand command = new GetTodoItemByIDCommand();
            command.TodoId= id;
            var CommandResponse = _mediator.Send(command);
            return Ok(CommandResponse.Result);
        }

        [HttpPost("UpdateItem")]
        public ActionResult UpdateTodo(TodoItemUpdateRequest request)
        {
            UpdateTodoItemCommand command = new UpdateTodoItemCommand();
            command.UpdateTodoRequest = request;
            var CommandResponse = _mediator.Send(command); 
            return Ok(CommandResponse.Result);
        }
    }
}
