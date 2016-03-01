// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace visma.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class ShipmentsQueryParameters
    {
        /// <summary>
        /// Initializes a new instance of the ShipmentsQueryParameters class.
        /// </summary>
        public ShipmentsQueryParameters() { }

        /// <summary>
        /// Initializes a new instance of the ShipmentsQueryParameters class.
        /// </summary>
        public ShipmentsQueryParameters(string greaterThanValue = default(string), int? numberToRead = default(int?), int? skipRecords = default(int?), string orderBy = default(string), string lastModifiedDateTime = default(string), string lastModifiedDateTimeCondition = default(string))
        {
            GreaterThanValue = greaterThanValue;
            NumberToRead = numberToRead;
            SkipRecords = skipRecords;
            OrderBy = orderBy;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedDateTimeCondition = lastModifiedDateTimeCondition;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "greaterThanValue")]
        public string GreaterThanValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberToRead")]
        public int? NumberToRead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skipRecords")]
        public int? SkipRecords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public string OrderBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDateTimeCondition")]
        public string LastModifiedDateTimeCondition { get; set; }

    }
}
