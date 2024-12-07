using DomainLayer.UoW.Impl.UnitofWork;
using DomainLayer.UoW.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public static class DomainLayerConfig
    {
        public static void AddDomainLayer(this IServiceCollection services)
        {
            services.AddScoped<IUnitofWork, UnitOfWork>();
        }
    }
}
