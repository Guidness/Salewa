using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class MigrationErrors
    {
        /*An error occurred while accessing the Microsoft.Extensions.Hosting services. Continuing without the application service provider. Error: Some services are not able to be constructed (Error while validating the service descriptor 'ServiceType: Contracts.IRepositoryManager Lifetime: Scoped ImplementationType: Repository.RepositoryManager': Unable to resolve service for type 'Repository.RepositoryContext' while attempting to activate 'Repository.RepositoryManager'.) (Error while validating the service descriptor 'ServiceType: Service.Contracts.IServiceManager Lifetime: Scoped ImplementationType: Service.ServiceManager': Unable to resolve service for type 'Repository.RepositoryContext' while attempting to activate 'Repository.RepositoryManager'.)*/
    }
}
