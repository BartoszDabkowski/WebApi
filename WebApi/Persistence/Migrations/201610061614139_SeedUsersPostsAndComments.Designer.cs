// <auto-generated />

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace WebApi.Persistence.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class SeedUsers : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(SeedUsers));
        
        string IMigrationMetadata.Id
        {
            get { return "201610061614139_SeedUsers"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}