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
    public partial class InventoryReceiptLineUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the InventoryReceiptLineUpdateDto
        /// class.
        /// </summary>
        public InventoryReceiptLineUpdateDto() { }

        /// <summary>
        /// Initializes a new instance of the InventoryReceiptLineUpdateDto
        /// class.
        /// </summary>
        public InventoryReceiptLineUpdateDto(DtoValueString warehouseId = default(DtoValueString), DtoValueNullableDecimal unitCost = default(DtoValueNullableDecimal), DtoValueNullableDecimal extCost = default(DtoValueNullableDecimal), string operation = default(string), DtoValueInt32 lineNumber = default(DtoValueInt32), DtoValueString inventoryNumber = default(DtoValueString), DtoValueString locationId = default(DtoValueString), DtoValueNullableDecimal quantity = default(DtoValueNullableDecimal), DtoValueString uom = default(DtoValueString), DtoValueString reasonCode = default(DtoValueString), DtoValueString description = default(DtoValueString))
        {
            WarehouseId = warehouseId;
            UnitCost = unitCost;
            ExtCost = extCost;
            Operation = operation;
            LineNumber = lineNumber;
            InventoryNumber = inventoryNumber;
            LocationId = locationId;
            Quantity = quantity;
            Uom = uom;
            ReasonCode = reasonCode;
            Description = description;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "warehouseId")]
        public DtoValueString WarehouseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitCost")]
        public DtoValueNullableDecimal UnitCost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extCost")]
        public DtoValueNullableDecimal ExtCost { get; set; }

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
        [JsonProperty(PropertyName = "inventoryNumber")]
        public DtoValueString InventoryNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locationId")]
        public DtoValueString LocationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public DtoValueNullableDecimal Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uom")]
        public DtoValueString Uom { get; set; }

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
