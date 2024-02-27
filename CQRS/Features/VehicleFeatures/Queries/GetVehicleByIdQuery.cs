using CQRS.Models;
using MediatR;

namespace CQRS.Features.VehicleFeatures.Queries;

public class GetVehicleByIdQuery : IRequest<Vehicle>
{
    public Guid Id { get; set; }
}