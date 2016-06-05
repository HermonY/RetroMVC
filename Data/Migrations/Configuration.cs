namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.RetroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.RetroContext context)
        {
            context.Comment.ToList().ForEach(x => context.Comment.Remove(x));
            context.Blog.ToList().ForEach(x=>context.Blog.Remove(x));
           

            var blog1 = new Entities.Blog
            {
                Author = "Hermon Yohannes",
                Content = "blah",
                Title = "Liked, Loved & Suggestions"

            };
            blog1.Comments.Add(new Entities.Comment {Text = "lorem ipsum"});
            context.Blog.Add(blog1);

            var blog2 = new Entities.Blog
            {
                Author = "Hermon Yohannes2",
                Content = "blah",
                Title = "Liked, Loved & Suggestions"

            };
            blog2.Comments.Add(new Entities.Comment { Text = "lorem ipsum2" });
            context.Blog.Add(blog2);

            var blog3 = new Entities.Blog
            {
                Author = "Hermon Yohannes3",
                Content = "blah",
                Title = "Liked, Loved & Suggestions"

            };
            blog3.Comments.Add(new Entities.Comment { Text = "lorem ipsum3" });
            context.Blog.Add(blog3);


            context.SaveChanges();
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
        }
    }
}
