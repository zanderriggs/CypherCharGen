using Microsoft.AspNetCore.Mvc;

namespace CypherCharGen.TypeController;

[ApiController]
[Route("api/[controller]")]
public class TypeController : ControllerBase
{
    // GET: api/types/1
    [HttpGet]
    public ActionResult<string> GetType(int id)
    {
        // Get Type by id
        Type type = null;

        if (type is null)
        {
            return NotFound();
        }
        return Ok(type);
    }

    // GET: api/types
    [HttpGet]
    public ActionResult<string> GetTypes()
    {
        List<Type> typesList = new List<Type>();
        return Ok(typesList);
    }
}
