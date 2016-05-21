using System.Collections.Generic;
using Angular.Core.Web.Api.Models;
using Angular.Core.Web.Api.Repository;
using Microsoft.AspNetCore.Mvc;


namespace Angular.Core.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private ITodoRepository _repository;

        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return _repository.GetTodos();
        }

        [HttpPost]
        public void Post([FromBody]Todo todo)
        {
            _repository.AddTodo(todo);
        }

    }
}
