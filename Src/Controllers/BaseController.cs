using Microsoft.AspNetCore.Mvc;

namespace MovieAppApi.Src.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController<T> : ControllerBase
{
  protected readonly ILogger<T> _logger;
  protected BaseController(ILogger<T> logger)
  {
    _logger = logger;
  }
}