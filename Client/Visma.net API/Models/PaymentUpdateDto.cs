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
    public partial class PaymentUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the PaymentUpdateDto class.
        /// </summary>
        public PaymentUpdateDto() { }

        /// <summary>
        /// Initializes a new instance of the PaymentUpdateDto class.
        /// </summary>
        public PaymentUpdateDto(DtoValueNullablePaymentTypes type = default(DtoValueNullablePaymentTypes), DtoValueBoolean hold = default(DtoValueBoolean), DtoValueDateTime applicationDate = default(DtoValueDateTime), DtoValueString applicationPeriod = default(DtoValueString), DtoValueString paymentRef = default(DtoValueString), DtoValueString customer = default(DtoValueString), DtoValueString location = default(DtoValueString), DtoValueString paymentMethod = default(DtoValueString), DtoValueString cashAccount = default(DtoValueString), DtoValueString currency = default(DtoValueString), DtoValueDecimal paymentAmount = default(DtoValueDecimal), DtoValueString invoiceText = default(DtoValueString), IList<PaymentLinesUpdateDto> paymentLines = default(IList<PaymentLinesUpdateDto>))
        {
            Type = type;
            Hold = hold;
            ApplicationDate = applicationDate;
            ApplicationPeriod = applicationPeriod;
            PaymentRef = paymentRef;
            Customer = customer;
            Location = location;
            PaymentMethod = paymentMethod;
            CashAccount = cashAccount;
            Currency = currency;
            PaymentAmount = paymentAmount;
            InvoiceText = invoiceText;
            PaymentLines = paymentLines;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DtoValueNullablePaymentTypes Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hold")]
        public DtoValueBoolean Hold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationDate")]
        public DtoValueDateTime ApplicationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationPeriod")]
        public DtoValueString ApplicationPeriod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentRef")]
        public DtoValueString PaymentRef { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customer")]
        public DtoValueString Customer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public DtoValueString Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentMethod")]
        public DtoValueString PaymentMethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cashAccount")]
        public DtoValueString CashAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public DtoValueString Currency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentAmount")]
        public DtoValueDecimal PaymentAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceText")]
        public DtoValueString InvoiceText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentLines")]
        public IList<PaymentLinesUpdateDto> PaymentLines { get; set; }

    }
}
