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
    public partial class FOBPointDescriptionDto
    {
        /// <summary>
        /// Initializes a new instance of the FOBPointDescriptionDto class.
        /// </summary>
        public FOBPointDescriptionDto() { }

        /// <summary>
        /// Initializes a new instance of the FOBPointDescriptionDto class.
        /// </summary>
        public FOBPointDescriptionDto(string id = default(string), string description = default(string))
        {
            Id = id;
            Description = description;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
