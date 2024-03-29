﻿namespace Actio.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IBusClient _busClient;
        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Post([FromBody ] CreateUser command)
        {
            await  _busClient.PublishAsync(command);
            return Accepted(); 

        }
    }
}
