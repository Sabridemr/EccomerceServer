using Microsoft.Extensions.Configuration;

namespace Eccomerce.Persistance
{
    public static class Configurations
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/Eccomerce.API"));
                configurationManager.AddJsonFile("appsettings.json");
                
                return configurationManager.GetConnectionString("PostgreSqlConnection");
            }
        }
        
    }
}



