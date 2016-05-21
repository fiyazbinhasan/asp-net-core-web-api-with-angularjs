using System.Collections.Generic;
using Angular.Core.Web.Api.Models;

namespace Angular.Core.Web.Api.Repository
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetTodos();
        void AddTodo(Todo todo);
    }
}
