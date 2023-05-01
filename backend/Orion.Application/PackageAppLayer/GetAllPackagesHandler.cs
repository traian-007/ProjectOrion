using MediatR;
using Orion.Application.DTO;

namespace Orion.Application.PackageAppLayer
{
    public class GetAllPackagesHandler : IRequestHandler<GetAllPackagesQuery, IEnumerable<PackageDto>>
    {
        public Task<IEnumerable<PackageDto>> Handle(GetAllPackagesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class GetAllPackagesQuery : IRequest<IEnumerable<PackageDto>>
    {
    }
}
