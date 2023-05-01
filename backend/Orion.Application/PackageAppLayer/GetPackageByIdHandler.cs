using MediatR;
using Orion.Application.DTO;

namespace Orion.Application.PackageAppLayer
{
    public class GetPackageByIdHandler : IRequestHandler<GetPackageByIdQuery, PackageDto>
    {
        public Task<PackageDto> Handle(GetPackageByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class GetPackageByIdQuery : IRequest<PackageDto>
    {
        public int Id { get; set; }
    }
}
