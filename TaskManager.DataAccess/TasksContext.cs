namespace TaskManager.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TaskManager.Models;

    public class TasksContext : DbContext
    {
        // Контекст настроен для использования строки подключения "TasksContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "TaskManager.DataAccess.TasksContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "TasksContext" 
        // в файле конфигурации приложения.
        public TasksContext()
            : base("name=TasksContext")
        {
            Database.SetInitializer(new PeriodsAndTaskTypesInitializer());
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}