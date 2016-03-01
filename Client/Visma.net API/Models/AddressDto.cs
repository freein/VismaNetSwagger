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
    public partial class AddressDto
    {
        /// <summary>
        /// Initializes a new instance of the AddressDto class.
        /// </summary>
        public AddressDto() { }

        /// <summary>
        /// Initializes a new instance of the AddressDto class.
        /// </summary>
        public AddressDto(int? addressId = default(int?), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string postalCode = default(string), string city = default(string), CountryDto country = default(CountryDto), CountyDto county = default(CountyDto))
        {
            AddressId = addressId;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            PostalCode = postalCode;
            City = city;
            Country = country;
            County = county;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressId")]
        public int? AddressId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public CountryDto Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "county")]
        public CountyDto County { get; set; }

    }
}
