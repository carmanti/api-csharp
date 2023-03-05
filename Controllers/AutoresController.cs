using Microsoft.AspNetCore.Mvc;

namespace webapi;

[ApiController]
[Route("api/autores")]
public class AutoresController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Autor>> Get()
    {
        return new List<Autor>(){
        new Autor(){Id=1, Nombre="Carlos"},
        new Autor(){Id=2, Nombre="Francisco"}
    };
    }
}