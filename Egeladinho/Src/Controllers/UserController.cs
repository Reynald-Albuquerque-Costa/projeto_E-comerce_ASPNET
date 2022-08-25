using Egeladinho.Src.Models;
using Egeladinho.Src.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egeladinho.Src.Controllers
{
    [ApiController]
    [Route("api/Users")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly ICrud<User> _repository;

        public UserController(ICrud<User> repository)
        {
            _repository = repository;
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] User user)
        {
            await _repository.Create(user);

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            try
            {
                await _repository.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}