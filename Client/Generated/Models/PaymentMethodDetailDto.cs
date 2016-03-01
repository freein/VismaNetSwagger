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
    public partial class PaymentMethodDetailDto
    {
        /// <summary>
        /// Initializes a new instance of the PaymentMethodDetailDto class.
        /// </summary>
        public PaymentMethodDetailDto() { }

        /// <summary>
        /// Initializes a new instance of the PaymentMethodDetailDto class.
        /// </summary>
        public PaymentMethodDetailDto(string detailID = default(string), string description = default(string))
        {
            DetailID = detailID;
            Description = description;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "detailID")]
        public string DetailID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
