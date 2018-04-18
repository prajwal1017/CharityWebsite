namespace CharityWebSite.Migrations
{
    using CharityWebSite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CharityWebSite.Models.WarDrobeCharityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CharityWebSite.Models.WarDrobeCharityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Donations.Add(new Donation { FirstName = "Peter", LastName = "Pevensie", Amount = 500, Date = new DateTime(2018, 3, 14), Comments = "When are you going to learn to do as you're told?" });
            context.Donations.Add(new Donation { FirstName = "Queen", LastName = "Jadis", Amount = 2000, Date = new DateTime(2018, 3, 20), Comments = "May I not be the only one with a polar bear fur overcoat!" });
            context.Donations.Add(new Donation { FirstName = "Mr.", LastName = "Tumnus", Amount = 25, Date = new DateTime(2018, 4, 14), Comments = "How would it be if you came and had tea with me?" });

            //context.Products.Add(new Product { ProductName = "Polar Bear Overcoat", Size = "L", Color = "Polar Bear White", Quantity = 3 });
            //context.Products.Add(new Product { ProductName = "Polar Bear Overcoat", Size = "L", Color = "Polar Bear White", Quantity = 3 });
            //context.Products.Add(new Product { ProductName = "Polar Bear Overcoat", Size = "L", Color = "Polar Bear White", Quantity = 3, Files = new File(~\Content\Images\PolarBearOvercoat.jpg) });
            base.Seed(context);
        }
    }
}