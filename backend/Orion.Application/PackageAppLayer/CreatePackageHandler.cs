using MediatR;
using Orion.Application.DTO;
using Orion.Domain.Enum;
using System.Net.Http.Json;

namespace Orion.Application.PackageAppLayer
{
    public class CreatePackageCommandHandler : IRequestHandler<CreatePackageCommand, PackageDto>
    {
        public Task<PackageDto> Handle(CreatePackageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class CreatePackageCommand : IRequest<PackageDto>
    {
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Features { get; set; }
        public int Price { get; set; }
        public JsonContent Meta { get; set; }
        public States Status { get; set; }
    }
}
