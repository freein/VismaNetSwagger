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
    public partial class InventoryTransferLineDto
    {
        /// <summary>
        /// Initializes a new instance of the InventoryTransferLineDto class.
        /// </summary>
        public InventoryTransferLineDto() { }

        /// <summary>
        /// Initializes a new instance of the InventoryTransferLineDto class.
        /// </summary>
        public InventoryTransferLineDto(LocationDto toLocation = default(LocationDto), int? lineNumber = default(int?), InventoryNumberDescriptionDto inventoryItem = default(InventoryNumberDescriptionDto), LocationDto location = default(LocationDto), double? quantity = default(double?), string uom = default(string), ReasonCodeDto reasonCode = default(ReasonCodeDto), string description = default(string))
        {
            ToLocation = toLocation;
            LineNumber = lineNumber;
            InventoryItem = inventoryItem;
            Location = location;
            Quantity = quantity;
            Uom = uom;
            ReasonCode = reasonCode;
            Description = description;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toLocation")]
        public LocationDto ToLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineNumber")]
        public int? LineNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inventoryItem")]
        public InventoryNumberDescriptionDto InventoryItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public LocationDto Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uom")]
        public string Uom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reasonCode")]
        public ReasonCodeDto ReasonCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
