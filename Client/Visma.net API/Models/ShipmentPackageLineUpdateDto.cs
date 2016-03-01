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
    public partial class ShipmentPackageLineUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the ShipmentPackageLineUpdateDto
        /// class.
        /// </summary>
        public ShipmentPackageLineUpdateDto() { }

        /// <summary>
        /// Initializes a new instance of the ShipmentPackageLineUpdateDto
        /// class.
        /// </summary>
        public ShipmentPackageLineUpdateDto(string operation = default(string), DtoValueInt32 lineNumber = default(DtoValueInt32), DtoValueNullableBoolean confirmed = default(DtoValueNullableBoolean), DtoValueString boxId = default(DtoValueString), DtoValueString description = default(DtoValueString), DtoValueNullableDecimal weight = default(DtoValueNullableDecimal), DtoValueNullableDecimal declaredValue = default(DtoValueNullableDecimal), DtoValueNullableDecimal codAmount = default(DtoValueNullableDecimal), DtoValueString trackingNumber = default(DtoValueString), DtoValueString customRefNbr1 = default(DtoValueString), DtoValueString customRefNbr2 = default(DtoValueString))
        {
            Operation = operation;
            LineNumber = lineNumber;
            Confirmed = confirmed;
            BoxId = boxId;
            Description = description;
            Weight = weight;
            DeclaredValue = declaredValue;
            CodAmount = codAmount;
            TrackingNumber = trackingNumber;
            CustomRefNbr1 = customRefNbr1;
            CustomRefNbr2 = customRefNbr2;
        }

        /// <summary>
        /// Possible values for this property include: 'Insert', 'Update',
        /// 'Delete'.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineNumber")]
        public DtoValueInt32 LineNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "confirmed")]
        public DtoValueNullableBoolean Confirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "boxId")]
        public DtoValueString BoxId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public DtoValueString Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public DtoValueNullableDecimal Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "declaredValue")]
        public DtoValueNullableDecimal DeclaredValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "codAmount")]
        public DtoValueNullableDecimal CodAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trackingNumber")]
        public DtoValueString TrackingNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customRefNbr1")]
        public DtoValueString CustomRefNbr1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customRefNbr2")]
        public DtoValueString CustomRefNbr2 { get; set; }

    }
}
