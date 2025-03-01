using Jotem.Infrastructure.Security.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotem.Infrastructure.Security.Extensions;

public static class Registration
{
    public static  IServiceCollection addSecurityRegistration(this IServiceCollection services)
    {
        services.AddSingleton<IJwtProvider, TokenService>();

        return services;
    }

}
