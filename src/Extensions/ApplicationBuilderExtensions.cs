using ConveApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ConveApp.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();

        using var dbContext = scope.ServiceProvider.GetRequiredService<EfDbContext>();

        dbContext.Database.Migrate();
    }
}
