using CQRS.Context;
using CQRS.Features.VehicleFeatures.Queries;
using CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Features.VehicleFeatures.Handlers;

public class GetAllVehiclesHandler : IRequestHandler<GetAllVehiclesQuery, IEnumerable<Vehicle>>
{
    private readonly VehicleDbContext _context;

    public GetAllVehiclesHandler(VehicleDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Vehicle>> Handle(GetAllVehiclesQuery query, CancellationToken cancellationToken)
    {
        var res = _context.Vehicles.ToList();
        return res.AsReadOnly();
    }
}