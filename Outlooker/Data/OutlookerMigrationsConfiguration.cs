using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace Outlooker.Data
{
    public class OutlookerMigrationsConfiguration : DbMigrationsConfiguration<OutlookerContext>
    {
        public OutlookerMigrationsConfiguration()
        {
#if DEBUG
            this.AutomaticMigrationDataLossAllowed = true; //danger in setting this value. Need to do research first before trying it to actual website
#endif
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OutlookerContext context)
        {
            base.Seed(context);

#if DEBUG
            if (context.Topics.Count() == 0)
            {
                var topic = new Topic()
                {
                    Title = "I love MVC",
                    Created = DateTime.Now,
                    Body = "I love ASP.NET MVC and I want everyone to know",
                    Replies = new List<Reply>(){
                        new Reply(){
                            Body = "I love it too!",
                            Created = DateTime.Now
                        },
                        new Reply(){
                            Body = "Me too",
                            Created = DateTime.Now
                        },
                        new Reply(){
                            Body = "Aw shucks",
                            Created = DateTime.Now
                        }
                    }
                };
                context.Topics.Add(topic);

                var anotherTopic = new Topic()
                {
                    Title = "I like Ruby too!",
                    Created = DateTime.Now,
                    Body = "Ruby on Rails is popular"
                };
                context.Topics.Add(anotherTopic);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }
#endif
        }
    }
}
