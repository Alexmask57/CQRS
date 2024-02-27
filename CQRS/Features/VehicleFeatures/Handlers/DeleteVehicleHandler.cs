using CQRS.Context;
using CQRS.Features.VehicleFeatures.Commands;
using MediatR;

namespace CQRS.Features.VehicleFeatures.Handlers;

public class DeleteVehicleHandler(VehicleDbContext _context)
    : IRequestHandler<DeleteVehicleCommand>
{
    public async Task Handle(DeleteVehicleCommand request, CancellationToken cancellationToken)
    {
        var res = _context.Vehicles.FirstOrDefault(x => x.Id == request.Id);
        if (res is not null)
        {
            _context.Vehicles.Remove(res);
            _context.SaveChangesAsync();
        }
    }
}