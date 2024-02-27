using CQRS.Context;
using CQRS.Features.VehicleFeatures.Commands;
using CQRS.Models;
using MediatR;

namespace CQRS.Features.VehicleFeatures.Handlers;

public class CreateVehicleHandler(VehicleDbContext _context)
    : IRequestHandler<CreateVehicleCommand>
{
    public async Task Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
    {
        var vehicle = new Vehicle()
        {
            Id = request.Id,
            Brand = request.Brand,
            Model = request.Model
        };
        _context.Add(vehicle);
        _context.SaveChangesAsync();
    }
}