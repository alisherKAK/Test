using System.Data.Entity;
using TaskManager.Models;

namespace TaskManager.DataAccess
{
    public class PeriodsAndTaskTypesInitializer : CreateDatabaseIfNotExists<TasksContext>
    {
        protected override void Seed(TasksContext context)
        {
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
