using CQRS.Features.VehicleFeatures.Commands;
using CQRS.Features.VehicleFeatures.Queries;
using CQRS.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiController(IMediator mediator) : Controller
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Vehicle>>> Get()
    {
        var query = new GetAllVehiclesQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Vehicle>> Get(Guid id)
    {
        var query = new GetVehicleByIdQuery() {Id = id};
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<ActionResult<IEnumerable<Vehicle>>> Post(CreateVehicleCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
    
    [HttpDelete]
    public async Task<ActionResult<IEnumerable<Vehicle>>> Delete(DeleteVehicleCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}