namespace TaskManager.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TaskManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManager.DataAccess.TasksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskManager.DataAccess.TasksContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Periods.AddRange(new Period[]
            {
                new Period() { Id = 1, PeriodTime = "Onetime"},
                new Period() { Id = 2, PeriodTime = "EveryDay"},
                new Period() { Id = 3, PeriodTime = "EveryMonth"},
                new Period() { Id = 4, PeriodTime = "EveryYear"}
            });

            context.TaskTypes.AddRange(new TaskType[]
            {
                new TaskType() { Id = 1, Type = "DwonloadFile"},
                new TaskType() { Id = 2, Type = "DislaceCatalog"},
                new TaskType() { Id = 3, Type = "SendEmail"}
            });

            context.SaveChanges();
        }
    }
}
