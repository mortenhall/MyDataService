using System.Collections.Generic;
using MyDataService.Model;
using MyDataService.Model.Enums;

namespace MyDataService.Services
{
    public class DataRepository : IDataRepository
    {
        public IList<TestData> GetAllData()
        {
            return new List<TestData>
            {
                new TestData
                {
                    Id = 42,
                    Description = "Some data",
                    DataType = DataType.Request
                }
            };
        }
    }
}