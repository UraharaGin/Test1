using System;
using System.Data.Entity;

namespace MyTestPoject.Authorization.Domain
{
    public class DataBaseIntializer : DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            context.Genders.Add(new Gender() {GenderName = "female", GenderId = Guid.NewGuid()});
            context.Genders.Add(new Gender() {GenderName = "male", GenderId = Guid.NewGuid()});

            context.MatrialStatuses.Add(new MatrialStatus() { MatrialStatusName = "single", MatrialStatusId = Guid.NewGuid() });
            context.MatrialStatuses.Add(new MatrialStatus() { MatrialStatusName = "married", MatrialStatusId = Guid.NewGuid() });

            context.SaveChanges();
        }
    }
}