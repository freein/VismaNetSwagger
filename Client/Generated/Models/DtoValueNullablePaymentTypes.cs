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
    public partial class DtoValueNullablePaymentTypes
    {
        /// <summary>
        /// Initializes a new instance of the DtoValueNullablePaymentTypes
        /// class.
        /// </summary>
        public DtoValueNullablePaymentTypes() { }

        /// <summary>
        /// Initializes a new instance of the DtoValueNullablePaymentTypes
        /// class.
        /// </summary>
        public DtoValueNullablePaymentTypes(string value = default(string))
        {
            Value = value;
        }

        /// <summary>
        /// Possible values for this property include: 'Payment',
        /// 'CreditNote', 'Prepayment', 'Refund', 'VoidPayment',
        /// 'SmallBalanceWo'.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
