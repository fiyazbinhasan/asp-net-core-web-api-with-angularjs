using System.Collections.Generic;
using Angular.Core.Web.Api.Models;

namespace Angular.Core.Web.Api.Repository
{
    public class TodoRepository : ITodoRepository
    {
        public static List<Todo> Todos  = new List<Todo>();

        public IEnumerable<Todo> GetTodos()
        {
            return Todos;
        }

        public void AddTodo(Todo todo)
        {
            Todos.Add(todo);
        }
    }
}
