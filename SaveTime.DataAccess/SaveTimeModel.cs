namespace SaveTime.DataAccess
{
    using SaveTime.DataModel.Business;
    using SaveTime.DataModel.Dictionary;
    using SaveTime.DataModel.Organization;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SaveTimeModel : DbContext
    {
        // Контекст настроен для использования строки подключения "SaveTimeModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SaveTime.DataAccess.SaveTimeModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "SaveTimeModel" 
        // в файле конфигурации приложения.
        public SaveTimeModel()
            : base("name=SaveTimeModel")
        {
        }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Client> Clients{ get; set; }
        public virtual DbSet<Record> Records{ get; set; }
        public virtual DbSet<Account> Accounts{ get; set; }
        public virtual DbSet<Branch> Branches{ get; set; }
        public virtual DbSet<Company> Companies{ get; set; }
        public virtual DbSet<Employee> Employees{ get; set; }
        public virtual DbSet<Employer> Employers{ get; set; }

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