using MediatRDemo.DTO;
using MediatRDemo.Entity;

namespace MediatRDemo.Repo
{
    public interface IMemoryRepo
    {
        public List<TodoItem> AlltodoItems();
        public TodoItem GetItemById(string id);
        public TodoItem CreateItem(TodoDTO request);
        public TodoItem UPdateItem(TodoItemUpdateRequest reqest);
    }
}
