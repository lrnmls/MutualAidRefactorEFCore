using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MutualAid.Data.Context;
using MutualAid.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.Manager
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<MutualAidContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                        appContext.Seed();
                    }
                    catch (Exception ex)
                    {
                        //Log errors or do anything you think it's needed
                        throw;
                    }
                }
            }

            return host;
        }
    }
}
