// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace visma
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class LedgerExtensions
    {
            /// <summary>
            /// Get a range of Ledgers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='greaterThanValue'>
            /// </param>
            /// <param name='numberToRead'>
            /// </param>
            /// <param name='skipRecords'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='lastModifiedDateTime'>
            /// </param>
            /// <param name='lastModifiedDateTimeCondition'>
            /// </param>
            public static IList<LedgerDto> GetAllLedgers(this ILedger operations, string greaterThanValue = default(string), int? numberToRead = default(int?), int? skipRecords = default(int?), string orderBy = default(string), string lastModifiedDateTime = default(string), string lastModifiedDateTimeCondition = default(string))
            {
                return Task.Factory.StartNew(s => ((ILedger)s).GetAllLedgersAsync(greaterThanValue, numberToRead, skipRecords, orderBy, lastModifiedDateTime, lastModifiedDateTimeCondition), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a range of Ledgers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='greaterThanValue'>
            /// </param>
            /// <param name='numberToRead'>
            /// </param>
            /// <param name='skipRecords'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='lastModifiedDateTime'>
            /// </param>
            /// <param name='lastModifiedDateTimeCondition'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LedgerDto>> GetAllLedgersAsync( this ILedger operations, string greaterThanValue = default(string), int? numberToRead = default(int?), int? skipRecords = default(int?), string orderBy = default(string), string lastModifiedDateTime = default(string), string lastModifiedDateTimeCondition = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllLedgersWithHttpMessagesAsync(greaterThanValue, numberToRead, skipRecords, orderBy, lastModifiedDateTime, lastModifiedDateTimeCondition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
