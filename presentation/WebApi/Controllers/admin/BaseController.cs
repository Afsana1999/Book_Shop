namespace BookShop.WebApi.Controllers.admin;

[Route("api/admin/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    private ISender _mediatr = null;
    public ISender Mediator => _mediatr ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
