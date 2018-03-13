using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Core;

namespace WcfTest3.Data
{
    public class DatabaseInitializer<T> : DropCreateDatabaseAlways<WcfTest3Entities>
    {
        public override void InitializeDatabase(WcfTest3Entities context)
        {
            
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));
            
            base.InitializeDatabase(context);
        }

        protected override void Seed(WcfTest3Entities context)
        {
            base.Seed(context);
            // Create a role.
            if (!context.Roles.Any(r => r.Name == "Mod"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Mod" };

                manager.Create(role);
                context.SaveChanges();
            }

            // Create a user.
            if (!context.Users.Any(u => u.UserName == "default"))
            {
                var store = new UserStore<IdentityUser>(context);
                var manager = new UserManager<IdentityUser>(store);
                var user = new IdentityUser { UserName = "default" };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "Mod");
                context.SaveChanges();
            }

            var categories = new List<Category>
            {
                new Category { Name = "Shipment", Description = "Posts about shipment issues" },
                new Category { Name = "Internal", Description = "Internal mod issues" },
                new Category { Name = "Stock", Description = "Posts about stock statuses" },
                new Category { Name = "Transfer", Description = "Posts about transfer statuses" }
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var posts = new List<Post>
            {
                new Post { SentBy = "User1", Body = "Post content", SentAt = DateTime.Now, Subject = "A subject on the board"},
                new Post { SentBy = "User2", Body = "An another post content", SentAt = DateTime.Now, Subject = "An another subject on the board"},
                new Post { SentBy = "User3", Body = "Another one", SentAt = DateTime.Now, Subject = "Another one subject on the board"},
                new Post { SentBy = "User4", Body = "Another one", SentAt = DateTime.Now, Subject = "Another one subject on the board"},
                new Post { SentBy = "User5", Body = "Another one", SentAt = DateTime.Now, Subject = "Another one subject on the board"},
                new Post { SentBy = "User6", Body = "Another one", SentAt = DateTime.Now, Subject = "Another one subject on the board"},
                new Post { SentBy = "User7", Body = "Another one", SentAt = DateTime.Now, Subject = "Another one subject on the board"},
                new Post { SentBy = "User8", Body = "Another one", SentAt = DateTime.Now, Subject = "Another one subject on the board"},
                new Post { SentBy = "User9", Body = "Another one", SentAt = DateTime.Now, Subject = "Another one subject on the board"}
            };

            var random = new Random();

            posts.ForEach(p =>
            {
                var randomId = random.Next(1, 4);
                var category = context.Categories.Single(c => c.Id == randomId);

                p.Category = category;
                p.CategoryId = category.Id;

                context.Posts.Add(p);
            });
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment { SentBy = "User", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User2", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User3", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User4", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User5", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User6", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User7", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User8", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User9", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User10", Body = "Just a comment", SentAt = DateTime.Now},
                new Comment { SentBy = "User11", Body = "Just a comment", SentAt = DateTime.Now}
            };

            comments.ForEach(c =>
            {
                var randomId = random.Next(1, 9);
                var post = context.Posts.Single(p => p.Id == randomId);

                c.Post = post;
                c.PostId = post.Id;

                context.Comments.Add(c);
            });
            context.SaveChanges();
   
        }
    }
}
