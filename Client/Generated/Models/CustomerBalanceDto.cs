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
    public partial class CustomerBalanceDto
    {
        /// <summary>
        /// Initializes a new instance of the CustomerBalanceDto class.
        /// </summary>
        public CustomerBalanceDto() { }

        /// <summary>
        /// Initializes a new instance of the CustomerBalanceDto class.
        /// </summary>
        public CustomerBalanceDto(CustomerDescriptionDto customer = default(CustomerDescriptionDto), double? balance = default(double?), double? totalOrder = default(double?), double? totalLoan = default(double?), double? totalSalePeriod = default(double?), double? totalSaleYear = default(double?), double? totalDiscountPeriod = default(double?), double? totalDiscountYear = default(double?), DateTime? lastModified = default(DateTime?))
        {
            Customer = customer;
            Balance = balance;
            TotalOrder = totalOrder;
            TotalLoan = totalLoan;
            TotalSalePeriod = totalSalePeriod;
            TotalSaleYear = totalSaleYear;
            TotalDiscountPeriod = totalDiscountPeriod;
            TotalDiscountYear = totalDiscountYear;
            LastModified = lastModified;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customer")]
        public CustomerDescriptionDto Customer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalOrder")]
        public double? TotalOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalLoan")]
        public double? TotalLoan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalSalePeriod")]
        public double? TotalSalePeriod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalSaleYear")]
        public double? TotalSaleYear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalDiscountPeriod")]
        public double? TotalDiscountPeriod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalDiscountYear")]
        public double? TotalDiscountYear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public DateTime? LastModified { get; set; }

    }
}
