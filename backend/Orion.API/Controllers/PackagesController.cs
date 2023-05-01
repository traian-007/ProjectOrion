using Microsoft.AspNetCore.Mvc;
using Orion.API.Controllers.BaseController;
using Orion.Application.PackageAppLayer;

namespace Orion.API.Controllers
{
    public class PackagesController : OrionBaseController
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var request = new GetPackageByIdQuery { Id = id };
            var package = await Mediator.Send(request);

            return Ok(package);
        }
    }
}
