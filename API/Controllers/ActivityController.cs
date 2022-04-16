using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivityController : BaseController
    {
        private readonly IMediator _mediator;
        public ActivityController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet]
        public async Task<ActionResult<List<Provider>>> GetProviders()
        {
            //newtonsoft json parse mediator kulesiyle burada haberlestirmen dogru olur mu? - her get bir işlem...
            return await Mediator.Send(new List.Query());
        }
        [HttpPost]
        public async Task<IActionResult> CreateActivity(Provider provider)
        {
            return Ok(await Mediator.Send(new Create.Command {Provider = provider}));
        }
    }
}