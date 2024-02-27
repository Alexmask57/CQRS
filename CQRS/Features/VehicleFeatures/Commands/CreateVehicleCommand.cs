using MediatR;

namespace CQRS.Features.VehicleFeatures.Commands;

public class CreateVehicleCommand : IRequest
{
    public Guid Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
}