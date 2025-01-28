using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
        //SOLUTION FOLDERIST
        // dotnet ef migrations add InitialCreate --project DAL --startup-project WebApp
        // dotnet ef database update --project DAL --startup-project WebApp 
        // dotnet ef database drop --project DAL --startup-project WebApp 
        
        
        // SCAFFOLDING - cd WebApp
        // dotnet aspnet-codegenerator razorpage -m Contributor -outDir Pages/Contributors -dc AppDbContext -udl --referenceScriptLibraries
        // 
        // dotnet aspnet-coddotnet aspnet-codegenerator razorpage -m Dj -outDir Pages/Djs -dc AppDbContext -udl --referenceScriptLibrariesegenerator razorpage -m Set -outDir Pages/Sets -dc AppDbContext -udl --referenceScriptLibraries
        
        
        // dotnet aspnet-codegenerator razorpage -m Set -outDir Pages/Sets -dc AppDbContext -udl --referenceScriptLibraries
        // dotnet aspnet-codegenerator razorpage -m SetTrack -outDir Pages/SetTracks -dc AppDbContext -udl --referenceScriptLibraries
        // dotnet aspnet-codegenerator razorpage -m Track -outDir Pages/Tracks -dc AppDbContext -udl --referenceScriptLibraries
        // dotnet aspnet-codegenerator razorpage -m TrackContributor -outDir Pages/TrackContributors -dc AppDbContext -udl --referenceScriptLibraries
        
        // Käivitada need read WebAppist. cd WebApp
        
        // Lehel olles too layoutis lingid nähtavale endale
        
        // Kui teed andmebaasi muudatusi, siis pane -f scaffolding asjadele taha, et üle kirjutaks
    }
}