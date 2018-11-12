using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDataService.Model;
using MyDataService.Model.Enums;
using MyDataService.Services;

namespace MyDataService.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/testdata")]
    public class TestDataController : ControllerBase
    {
        private IDataRepository _dataRepository;

        public TestDataController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        /// <summary>
        /// Returns all persisted data
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        ///
        /// {
        ///    
        /// }
        /// </remarks>
        [HttpGet]
        public ActionResult<IEnumerable<TestData>> GetAllData()
        {

            return Ok(_dataRepository.GetAllData());
        }

        /// <summary>
        /// Returns test data with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TestData> GetTestData(int id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult AddTestData([FromBody] TestData testData)
        {

            return Ok();
        }
    }
}