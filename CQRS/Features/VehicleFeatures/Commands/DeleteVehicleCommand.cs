using MediatR;

namespace CQRS.Features.VehicleFeatures.Commands;

public class DeleteVehicleCommand : IRequest
{
    public Guid Id { get; set; }
}