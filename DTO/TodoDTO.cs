using MediatRDemo.Entity;

namespace MediatRDemo.DTO
{
    public class TodoDTO
    {
        public string Name { get; set; }
        public string Catagory { get; set; }
    }

    public class TodoItemUpdateRequest
    {
        public string ID { get; set; } 
        public string Status { get; set; }
    }
}
