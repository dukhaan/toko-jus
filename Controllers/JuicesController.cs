using Microsoft.AspNetCore.Mvc;
using MyWebApi.Data;
using MyWebApi.Models;

namespace MyWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JuicesController : ControllerBase
{
    private readonly JuiceStore _juiceStore;

    public JuicesController(JuiceStore juiceStore)
    {
        _juiceStore = juiceStore;
    }

    [HttpGet]
    public ActionResult<IReadOnlyList<Juice>> GetAll() => Ok(_juiceStore.GetAll());

    [HttpGet("{id:int}")]
    public ActionResult<Juice> GetById(int id)
    {
        var juice = _juiceStore.GetById(id);
        return juice is null ? NotFound() : Ok(juice);
    }

    [HttpPost]
    public ActionResult<Juice> Create(Juice juice)
    {
        var createdJuice = _juiceStore.Create(juice);
        return CreatedAtAction(nameof(GetById), new { id = createdJuice.Id }, createdJuice);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, Juice juice) => _juiceStore.Update(id, juice) ? NoContent() : NotFound();

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id) => _juiceStore.Delete(id) ? NoContent() : NotFound();
}
