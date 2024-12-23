using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProSoft.DMT.Api.Data.MsSql;

public static class MigrationHelper
{
   public static IHost Migrate<T>(IHost host) where T : AppDbContext
   {
      using (var scope = host.Services.CreateScope())
      {
         var services = scope.ServiceProvider;
         var logger = services.GetRequiredService<ILogger<AppDbContext>>();

         try
         {
            logger.LogInformation("Checking for pending database migrations");
            var db = services.GetRequiredService<T>();
            var pendingMigrations = db.Database.GetPendingMigrations().ToList();

            if (pendingMigrations is { Count: > 0 })
            {
               var logMessage = new StringBuilder();

               logMessage.Append($"Found {pendingMigrations.Count} pending migrations:");

               foreach (var migration in pendingMigrations)
               {
                  logMessage.Append($"\r\n- {migration}");
               }

               logger.LogInformation(message: "{LogMessage}", logMessage.ToString());
               db.Database.Migrate();
               logger.LogInformation("Migrations successfully applied.");
            }
            else
            {
               logger.LogInformation("No pending migrations to apply.");
            }
         }
         catch (Exception ex)
         {
            logger.LogError(ex, "An error occurred while migrating the database.");
         }
      }

      return host;
   }
}
