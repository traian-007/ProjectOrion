using MediatR;
using Orion.Application.DTO;

namespace Orion.Application.PackageAppLayer
{
    public class DeletePackageHandler : IRequestHandler<DeletePackageCommand, PackageDto>
    {
        public Task<PackageDto> Handle(DeletePackageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class DeletePackageCommand : IRequest<PackageDto>
    {
        public int Id { get; set; }
    }
}
