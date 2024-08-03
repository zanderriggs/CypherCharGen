using CypherCharGen.Models;
using Microsoft.AspNetCore.Mvc;

namespace CypherCharGen.DescriptorController;

[ApiController]
[Route("api/[controller]")]
public class DescriptorController : ControllerBase
{
    // GET: api/types/1
    [HttpGet]
    public ActionResult GetDescriptor(int id)
    {
        // Get Type by id
        Descriptor type = null;

        if (type is null)
        {
            return NotFound();
        }
        return Ok(type);
    }

    // GET: api/types
    [HttpGet]
    public ActionResult GetDescriptors()
    {
        List<Descriptor> descriptorList = new List<Descriptor>();
        return Ok(descriptorList);
    }
}
