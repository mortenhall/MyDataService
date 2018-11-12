using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using DataType = MyDataService.Model.Enums.DataType;

namespace MyDataService.Model
{
    public class TestData
    {
        /// <summary>
        /// The Id of the data element
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// A description string
        /// </summary>
        public string Description { get; set; }

        public DataType DataType { get; set; }


    }
}