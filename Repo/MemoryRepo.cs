using MediatRDemo.DTO;
using MediatRDemo.Entity;

namespace MediatRDemo.Repo
{
    public class MemoryRepo:IMemoryRepo
    {
        List<TodoItem> todoItems = new List<TodoItem>();
        public MemoryRepo()
        {
            todoItems = new()
       {
            new TodoItem
            {
                 ID =Guid.NewGuid().ToString(),
                   Name = "Test Item One",
                    Catagory = nameof(Catagory.Wellness),
                    Status =nameof(ItemStatus.Created),

                    CeatedAt = DateTime.Now

            },
            new TodoItem
            {
                 ID =Guid.NewGuid().ToString(),
                   Name = "Test Item Two",
                    Catagory = nameof(Catagory.Personal),
                    Status =nameof(ItemStatus.Assigned),
                    CeatedAt = DateTime.Now

            },
            new TodoItem
            {
                 ID =Guid.NewGuid().ToString(),
                   Name = "Test Item Theree",
                    Catagory = nameof(Catagory.Social),
                    Status =nameof(ItemStatus.InProgress)  ,
                    CeatedAt = DateTime.Now

            }
       };
        }

      

        public TodoItem CreateItem(TodoDTO request)
        {
            var newItem = new TodoItem
            {
                ID = Guid.NewGuid().ToString(),
                Name = request.Name,
                Status = nameof(ItemStatus.Created),
                 Catagory = request.Catagory,
                CeatedAt = DateTime.Now
            };
            todoItems.Add(newItem);
            return todoItems.Where(x => x.ID == newItem.ID).FirstOrDefault();       
        }

        public TodoItem GetItemById(string id)
        {
            return todoItems.Where(x => x.ID == id).FirstOrDefault();
        }

        public TodoItem UPdateItem(TodoItemUpdateRequest reqest)
        {
           var updated= todoItems.Where(x => x.ID == reqest.ID).FirstOrDefault();
            updated.Status= reqest.Status  ;
            return updated;
        }


        List<TodoItem> IMemoryRepo.AlltodoItems()
        {
            return todoItems.ToList();
        }
    }
}
