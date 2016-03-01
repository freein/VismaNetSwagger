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
    /// This class represents a inventory issue in InventoryIssueController.
    /// Used by getting data.
    /// </summary>
    public partial class InventoryReceiptDto
    {
        /// <summary>
        /// Initializes a new instance of the InventoryReceiptDto class.
        /// </summary>
        public InventoryReceiptDto() { }

        /// <summary>
        /// Initializes a new instance of the InventoryReceiptDto class.
        /// </summary>
        public InventoryReceiptDto(double? totalCost = default(double?), double? controlCost = default(double?), string transferNumber = default(string), IList<InventoryReceiptLineDto> receiptLines = default(IList<InventoryReceiptLineDto>), string referenceNumber = default(string), string status = default(string), bool? hold = default(bool?), DateTime? date = default(DateTime?), string postPeriod = default(string), string externalReference = default(string), string description = default(string), double? totalQuantity = default(double?), double? controlQuantity = default(double?), string batchNumber = default(string), DateTime? lastModifiedDateTime = default(DateTime?))
        {
            TotalCost = totalCost;
            ControlCost = controlCost;
            TransferNumber = transferNumber;
            ReceiptLines = receiptLines;
            ReferenceNumber = referenceNumber;
            Status = status;
            Hold = hold;
            Date = date;
            PostPeriod = postPeriod;
            ExternalReference = externalReference;
            Description = description;
            TotalQuantity = totalQuantity;
            ControlQuantity = controlQuantity;
            BatchNumber = batchNumber;
            LastModifiedDateTime = lastModifiedDateTime;
        }

        /// <summary>
        /// The total cost of the inventory items received. The system
        /// automatically calculates this value as a sum of all extended cost
        /// values of all received inventory items listed in theÂ Transaction
        /// DetailsÂ tab of this form.
        /// </summary>
        [JsonProperty(PropertyName = "totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// The total cost of the inventory items to be received.Â Control
        /// CostÂ is available only if theÂ Validate Document Totals on
        /// EntryÂ option is selected on theÂ Inventory PreferencesÂ form.
        /// The user enters this value manually to confirm the total cost as
        /// calculated automatically for the document. If theÂ Control CostÂ
        /// andÂ Total CostÂ values do not match, the system generates a
        /// warning message and the document cannot be saved.
        /// </summary>
        [JsonProperty(PropertyName = "controlCost")]
        public double? ControlCost { get; set; }

        /// <summary>
        /// The transfer number for the receipt operation. (Enter this number
        /// only if the two-step transfer operation is performed.)
        /// </summary>
        [JsonProperty(PropertyName = "transferNumber")]
        public string TransferNumber { get; set; }

        /// <summary>
        /// The inventory receipt lines
        /// </summary>
        [JsonProperty(PropertyName = "receiptLines")]
        public IList<InventoryReceiptLineDto> ReceiptLines { get; set; }

        /// <summary>
        /// The unique reference number of the receipt, which the system
        /// automatically assigns according to the numbering sequence
        /// selected for receipts on theÂ Inventory PreferencesÂ IN.10.10.00)
        /// form.
        /// </summary>
        [JsonProperty(PropertyName = "referenceNumber")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The current status of the receipt. The following options are
        /// available:
        /// On Hold:The receipt/issue is a draft and can be
        /// edited. Receipts with this status cannot be released.
        /// Balanced: The receipt/issue data has been validated by
        /// the system and the receipt can be released. It also can be
        /// modified or deleted, but changes can be saved only if the receipt
        /// is balanced.
        /// Released: The receipt/issue has been released and
        /// cannot be edited or deleted. Possible values for this property
        /// include: 'Hold', 'Balanced', 'Released'.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// A check box that you select to give the receipt theÂ On HoldÂ
        /// status. Clear the check box to save the receipt with theÂ
        /// BalancedÂ status.
        /// </summary>
        [JsonProperty(PropertyName = "hold")]
        public bool? Hold { get; set; }

        /// <summary>
        /// The date when the receipt was created. All transactions included
        /// in this document will have this transaction date.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The financial period to which the transactions recorded in the
        /// document should be posted.
        /// </summary>
        [JsonProperty(PropertyName = "postPeriod")]
        public string PostPeriod { get; set; }

        /// <summary>
        /// The external reference number of the inventory issue document (for
        /// example, the vendorâ€™s reference code).
        /// </summary>
        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// A brief description of the inventory issue or its transactions.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The total quantity of inventory items, which the system calculates
        /// automatically, for the document.
        /// </summary>
        [JsonProperty(PropertyName = "totalQuantity")]
        public double? TotalQuantity { get; set; }

        /// <summary>
        /// The manually entered quantity of inventory items.Â Control Qty.Â
        /// is available only if theÂ Validate Document Totals on EntryÂ
        /// option is selected on theÂ Inventory PreferencesÂ form. If theÂ
        /// Control Qty.Â andÂ Total Qty.values do not match, the system
        /// generates a warning message and the issue cannot be saved.
        /// </summary>
        [JsonProperty(PropertyName = "controlQuantity")]
        public double? ControlQuantity { get; set; }

        /// <summary>
        /// The reference number of the batch generated for the receipt. Click
        /// the number to open theÂ Journal TransactionsÂ (GL.30.10.00) form
        /// and view the details of the transactions.
        /// </summary>
        [JsonProperty(PropertyName = "batchNumber")]
        public string BatchNumber { get; set; }

        /// <summary>
        /// The date when the document was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDateTime")]
        public DateTime? LastModifiedDateTime { get; set; }

    }
}
