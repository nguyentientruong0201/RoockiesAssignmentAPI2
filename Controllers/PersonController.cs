using Microsoft.AspNetCore.Mvc;
using APIAssignment1.DTO;
using APIAssignment1.Interface;

namespace APIAssignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpPost("/add-person")]
        public void AddPerson([FromBody] DTOTask person)
        {
            _service.AddPerson(person);
        }        
    }
}