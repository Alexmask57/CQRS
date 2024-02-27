using CQRS.Context;
using CQRS.Features.VehicleFeatures.Queries;
using CQRS.Models;
using MediatR;

namespace CQRS.Features.VehicleFeatures.Handlers;

public class GetVehicleByIdHandler : IRequestHandler<GetVehicleByIdQuery, Vehicle>
{
    private readonly VehicleDbContext _context;

    public GetVehicleByIdHandler(VehicleDbContext context)
    {
        _context = context;
    }
    
    public async Task<Vehicle> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
    {
        var res = _context.Vehicles.FirstOrDefault(x => x.Id == request.Id);
        return res;
    }
}