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
    public partial class DtoValueAddressUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the DtoValueAddressUpdateDto class.
        /// </summary>
        public DtoValueAddressUpdateDto() { }

        /// <summary>
        /// Initializes a new instance of the DtoValueAddressUpdateDto class.
        /// </summary>
        public DtoValueAddressUpdateDto(AddressUpdateDto value = default(AddressUpdateDto))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public AddressUpdateDto Value { get; set; }

    }
}
