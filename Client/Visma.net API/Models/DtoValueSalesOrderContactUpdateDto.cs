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
    public partial class DtoValueSalesOrderContactUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DtoValueSalesOrderContactUpdateDto class.
        /// </summary>
        public DtoValueSalesOrderContactUpdateDto() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DtoValueSalesOrderContactUpdateDto class.
        /// </summary>
        public DtoValueSalesOrderContactUpdateDto(SalesOrderContactUpdateDto value = default(SalesOrderContactUpdateDto))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public SalesOrderContactUpdateDto Value { get; set; }

    }
}
