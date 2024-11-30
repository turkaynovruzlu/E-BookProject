using Microsoft.Extensions.DependencyInjection;
using Repository.Implementations;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class RepositoryConfig
    {
        public static void AddRepositoryConfig(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository,BookRepository>();
            services.AddScoped<IBookUserRepository,BookUserRepository>();
            services.AddScoped<ICommentRepository,CommentRepository>();
            services.AddScoped<IPaymentRepository,PaymentRepository>();
            services.AddScoped<IRoleRepository,RoleRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IScoreRepository, ScoreRepository>();
        }
    }
}
