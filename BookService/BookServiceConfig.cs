using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    public static class BookServiceConfig
    {
        public static void AddBookServiceConfig(this IServiceCollection services,IConfiguration configuration)
        {
            
        }
    }
}
