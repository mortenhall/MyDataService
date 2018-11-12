using System.Collections.Generic;
using MyDataService.Model;

namespace MyDataService.Services
{
    public interface IDataRepository
    {
        IList<TestData> GetAllData();
    }
}