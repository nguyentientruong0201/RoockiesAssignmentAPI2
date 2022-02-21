using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace APIAssignment1.Extension {
    public static class SeedingExtension {
        public static IWebHost SeedData(this IWebHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            PersonContext context = services.GetService<PersonContext>();
 
            // now we have the DbContext. Run migrations
            context.Database.Migrate();
 
            // now that the database is up to date. Let's seed
            new PostTypesSeeder(context).SeedData();
 

            // if we are debugging, then let's run the test data seeder
            // alternatively, check against the environment to run this seeder
        }   
        return host;
    }
    }
}