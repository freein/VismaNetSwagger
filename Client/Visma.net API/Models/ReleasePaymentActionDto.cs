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
    public partial class ReleasePaymentActionDto
    {
        /// <summary>
        /// Initializes a new instance of the ReleasePaymentActionDto class.
        /// </summary>
        public ReleasePaymentActionDto() { }

        /// <summary>
        /// Initializes a new instance of the ReleasePaymentActionDto class.
        /// </summary>
        public ReleasePaymentActionDto(DtoValuePaymentTypes type = default(DtoValuePaymentTypes))
        {
            Type = type;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DtoValuePaymentTypes Type { get; set; }

    }
}
