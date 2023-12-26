using BookShop.Application.Feutures.Address.Commands.CreateAddressCommand;
using BookShop.Application.Feutures.Address.Commands.DeleteAddressCommand;
using BookShop.Application.Feutures.Address.Commands.UpdateAddressCommand;
using BookShop.Application.Feutures.Address.Queries.GetAddressesQuery;
using BookShop.Application.Feutures.Address.Queries.GetAddressQuery;

namespace BookShop.WebApi.Controllers.admin;

public class AddressesController : BaseController
{
    [HttpGet("GetAllAddresses")]
    public async Task<IActionResult> GetAllAddresses()
    {
        return Ok(await Mediator.Send(new GetAddressesQuery()));
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromBody] GetAddressQuery  getAddressQuery)
    {
        return Ok(await Mediator.Send(getAddressQuery));
    }

    [HttpPost("AddBook")]
    public async Task<int> AddAddress([FromBody] CreateAddressCommand createAddressCommand)
    {
        return await Mediator.Send(createAddressCommand);
    }

    [HttpDelete]
    public async Task Delete([FromBody] DeleteAddressCommand deleteAddressCommand)
    {
        await Mediator.Send(deleteAddressCommand);
    }

    [HttpPut]
    public async Task Update([FromBody] UpdateAddressCommand updateAddressCommand)
    {
        await Mediator.Send(updateAddressCommand);
    }
}
