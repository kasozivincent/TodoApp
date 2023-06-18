using System.IO.Packaging;

namespace TodoApp.Model
{
    public class TodoItem
    {
       public string Title { get; set; }
       public string Description { get; set; }
       public Priority Priority { set; get; }
       public bool IsDone { set; get; }
    }
}
