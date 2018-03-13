namespace NmmInfo.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NmmInfo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NmmInfo.Models.ApplicationDbContext context)
        {
            context.beers.AddOrUpdate(b => b.Name,
                new Models.Beer()
                {
                    Name = "Ida's IPA",
                    Type = Models.BeerType.IPA,
                    ABV = 5.6,
                    IBU = 20
                },
                new Models.Beer()
                {
                    Name = "Paul's Porter",
                    Type = Models.BeerType.Porter,
                    ABV = 4.6,
                    IBU = 40
                }
            );
        }
    }
}
