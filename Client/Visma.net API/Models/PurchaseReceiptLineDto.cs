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
    /// This class represents a Purchase Order Line in
    /// PurchaseReceiptContraoller. Used for getting data.
    /// </summary>
    public partial class PurchaseReceiptLineDto
    {
        /// <summary>
        /// Initializes a new instance of the PurchaseReceiptLineDto class.
        /// </summary>
        public PurchaseReceiptLineDto() { }

        /// <summary>
        /// Initializes a new instance of the PurchaseReceiptLineDto class.
        /// </summary>
        public PurchaseReceiptLineDto(IList<AllocationsDto> allocations = default(IList<AllocationsDto>), int? lineNbr = default(int?), BranchNumberDto branch = default(BranchNumberDto), InventoryNumberDescriptionDto inventory = default(InventoryNumberDescriptionDto), string lineType = default(string), WarehouseIdDescriptionDto warehouse = default(WarehouseIdDescriptionDto), LocationIdNameDto location = default(LocationIdNameDto), string lineDescription = default(string), string uom = default(string), double? orderQty = default(double?), double? openQty = default(double?), double? receiptQty = default(double?), double? unitCost = default(double?), double? extCost = default(double?), double? discountPercent = default(double?), double? discountAmount = default(double?), bool? manualDiscount = default(bool?), DiscountCodeNumberDescriptionDto discountCode = default(DiscountCodeNumberDescriptionDto), double? amount = default(double?), TaxCategoryNumberDescriptionDto taxCategory = default(TaxCategoryNumberDescriptionDto), AccountNumberTypeDescriptionDto account = default(AccountNumberTypeDescriptionDto), string description = default(string), SubAccountDescriptionDto sub = default(SubAccountDescriptionDto), AccountNumberTypeDescriptionDto actualAccount = default(AccountNumberTypeDescriptionDto), SubAccountDescriptionDto actualSub = default(SubAccountDescriptionDto), ProjectDto project = default(ProjectDto), ProjectTaskDto projectTask = default(ProjectTaskDto), DateTime? expirationDate = default(DateTime?), string lotSerialNumber = default(string), string poOrderType = default(string), string poOrderNbr = default(string), int? poOrderLineNbr = default(int?), string transferOrderType = default(string), string transferOrderNbr = default(string), int? transferOrderLineNbr = default(int?), bool? completePoLine = default(bool?))
        {
            Allocations = allocations;
            LineNbr = lineNbr;
            Branch = branch;
            Inventory = inventory;
            LineType = lineType;
            Warehouse = warehouse;
            Location = location;
            LineDescription = lineDescription;
            Uom = uom;
            OrderQty = orderQty;
            OpenQty = openQty;
            ReceiptQty = receiptQty;
            UnitCost = unitCost;
            ExtCost = extCost;
            DiscountPercent = discountPercent;
            DiscountAmount = discountAmount;
            ManualDiscount = manualDiscount;
            DiscountCode = discountCode;
            Amount = amount;
            TaxCategory = taxCategory;
            Account = account;
            Description = description;
            Sub = sub;
            ActualAccount = actualAccount;
            ActualSub = actualSub;
            Project = project;
            ProjectTask = projectTask;
            ExpirationDate = expirationDate;
            LotSerialNumber = lotSerialNumber;
            PoOrderType = poOrderType;
            PoOrderNbr = poOrderNbr;
            PoOrderLineNbr = poOrderLineNbr;
            TransferOrderType = transferOrderType;
            TransferOrderNbr = transferOrderNbr;
            TransferOrderLineNbr = transferOrderLineNbr;
            CompletePoLine = completePoLine;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allocations")]
        public IList<AllocationsDto> Allocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineNbr")]
        public int? LineNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "branch")]
        public BranchNumberDto Branch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inventory")]
        public InventoryNumberDescriptionDto Inventory { get; set; }

        /// <summary>
        /// Possible values for this property include: 'GoodsForInventory',
        /// 'GoodsForSalesOrder', 'GoodsForReplenishment',
        /// 'GoodsForDropShip', 'NonStockForDropShip',
        /// 'NonStockForSalesOrder', 'NonStock', 'Service', 'Freight',
        /// 'Description'.
        /// </summary>
        [JsonProperty(PropertyName = "lineType")]
        public string LineType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "warehouse")]
        public WarehouseIdDescriptionDto Warehouse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public LocationIdNameDto Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineDescription")]
        public string LineDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uom")]
        public string Uom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderQty")]
        public double? OrderQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "openQty")]
        public double? OpenQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receiptQty")]
        public double? ReceiptQty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitCost")]
        public double? UnitCost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extCost")]
        public double? ExtCost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountPercent")]
        public double? DiscountPercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountAmount")]
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualDiscount")]
        public bool? ManualDiscount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountCode")]
        public DiscountCodeNumberDescriptionDto DiscountCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taxCategory")]
        public TaxCategoryNumberDescriptionDto TaxCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public AccountNumberTypeDescriptionDto Account { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sub")]
        public SubAccountDescriptionDto Sub { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualAccount")]
        public AccountNumberTypeDescriptionDto ActualAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualSub")]
        public SubAccountDescriptionDto ActualSub { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        public ProjectDto Project { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "projectTask")]
        public ProjectTaskDto ProjectTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lotSerialNumber")]
        public string LotSerialNumber { get; set; }

        /// <summary>
        /// Possible values for this property include: 'RegularOrder',
        /// 'DropShip', 'Blanket', 'StandardBlanket'.
        /// </summary>
        [JsonProperty(PropertyName = "poOrderType")]
        public string PoOrderType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "poOrderNbr")]
        public string PoOrderNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "poOrderLineNbr")]
        public int? PoOrderLineNbr { get; set; }

        /// <summary>
        /// Possible values for this property include: 'CreditNote',
        /// 'DebitNote', 'Invoice', 'QuoteOrder', 'RMAOrder', 'SalesOrder',
        /// 'StandardOrder', 'TransferOrder'.
        /// </summary>
        [JsonProperty(PropertyName = "transferOrderType")]
        public string TransferOrderType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transferOrderNbr")]
        public string TransferOrderNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transferOrderLineNbr")]
        public int? TransferOrderLineNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completePoLine")]
        public bool? CompletePoLine { get; set; }

    }
}
