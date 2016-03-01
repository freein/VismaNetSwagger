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
    public partial class ShipmentDetailLineUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the ShipmentDetailLineUpdateDto
        /// class.
        /// </summary>
        public ShipmentDetailLineUpdateDto() { }

        /// <summary>
        /// Initializes a new instance of the ShipmentDetailLineUpdateDto
        /// class.
        /// </summary>
        public ShipmentDetailLineUpdateDto(string operation = default(string), DtoValueInt32 lineNumber = default(DtoValueInt32), DtoValueString warehouse = default(DtoValueString), DtoValueString location = default(DtoValueString), DtoValueString uom = default(DtoValueString), DtoValueNullableDecimal shippedQty = default(DtoValueNullableDecimal), DtoValueString lotSerialNbr = default(DtoValueString), DtoValueNullableDateTime expirationDate = default(DtoValueNullableDateTime), DtoValueString reasonCode = default(DtoValueString), DtoValueString description = default(DtoValueString))
        {
            Operation = operation;
            LineNumber = lineNumber;
            Warehouse = warehouse;
            Location = location;
            Uom = uom;
            ShippedQty = shippedQty;
            LotSerialNbr = lotSerialNbr;
            ExpirationDate = expirationDate;
            ReasonCode = reasonCode;
            Description = description;
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
        [JsonProperty(PropertyName = "warehouse")]
        public DtoValueString Warehouse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public DtoValueString Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uom")]
        public DtoValueString Uom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippedQty")]
        public DtoValueNullableDecimal ShippedQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lotSerialNbr")]
        public DtoValueString LotSerialNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public DtoValueNullableDateTime ExpirationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reasonCode")]
        public DtoValueString ReasonCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public DtoValueString Description { get; set; }

    }
}
