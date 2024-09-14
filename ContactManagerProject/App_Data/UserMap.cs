using ContactManagerProject.Models;
using CsvHelper.Configuration;

namespace ContactManagerProject.App_Data
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.Name);
            Map(m => m.DateOfBirth);
            Map(m => m.Married);
            Map(m => m.Phone);
            Map(m => m.Salary);
        }
    }
}
