using Microsoft.AspNetCore.Identity;

namespace MediatRDemo.Entity
{
    public class TodoItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
       public string Catagory { get; set; } 
        public string Status { get; set; }
        public DateTime CeatedAt { get; set; }
    }
    public enum ItemStatus
    {
        Created,
        Assigned,
        InProgress,
        Done
    }

    public enum Catagory
    {
        Travel,
        Personal,
        Social,
        Wellness

    }
}
