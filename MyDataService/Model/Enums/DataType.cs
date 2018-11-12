using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MyDataService.Model.Enums
{
    /// <summary>
    /// The data type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataType
    {
        /// <summary>
        /// Response data in Json format
        /// </summary>
        Response,
        /// <summary>
        /// Request payload in Json format
        /// </summary>
        Request
    }
}