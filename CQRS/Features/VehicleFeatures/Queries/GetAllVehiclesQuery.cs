using CQRS.Models;
using MediatR;

namespace CQRS.Features.VehicleFeatures.Queries;

public class GetAllVehiclesQuery : IRequest<IEnumerable<Vehicle>>
{
    
}