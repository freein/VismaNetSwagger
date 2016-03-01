// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace visma
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Stocktake operations.
    /// </summary>
    public partial interface IStocktake
    {
        /// <summary>
        /// Get a range of stocktakes
        /// </summary>
        /// <param name='warehouse'>
        /// </param>
        /// <param name='location'>
        /// </param>
        /// <param name='inventory'>
        /// </param>
        /// <param name='lotSerialNumber'>
        /// </param>
        /// <param name='summaryStatus'>
        /// Possible values for this parameter include: 'Cancelled',
        /// 'Completed', 'Counting', 'Entering'
        /// </param>
        /// <param name='numberToRead'>
        /// </param>
        /// <param name='startWithLine'>
        /// </param>
        /// <param name='endWithLine'>
        /// </param>
        /// <param name='freezeDateTime'>
        /// </param>
        /// <param name='freezeDateTimeCondition'>
        /// </param>
        /// <param name='lastModifiedDateTime'>
        /// </param>
        /// <param name='lastModifiedDateTimeCondition'>
        /// </param>
        /// <param name='expirationDateTime'>
        /// </param>
        /// <param name='expirationDateTimeCondition'>
        /// </param>
        /// <param name='status'>
        /// Possible values for this parameter include: 'NotEntered',
        /// 'Entered', 'Skipped'
        /// </param>
        /// <param name='skipRecords'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StocktakeDto>>> GetAllStocktakesWithHttpMessagesAsync(string warehouse = default(string), string location = default(string), string inventory = default(string), string lotSerialNumber = default(string), string summaryStatus = default(string), int? numberToRead = default(int?), int? startWithLine = default(int?), int? endWithLine = default(int?), string freezeDateTime = default(string), string freezeDateTimeCondition = default(string), string lastModifiedDateTime = default(string), string lastModifiedDateTimeCondition = default(string), string expirationDateTime = default(string), string expirationDateTimeCondition = default(string), string status = default(string), int? skipRecords = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a specific
        /// </summary>
        /// <param name='referenceNumber'>
        /// Identifies the Stocktake
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<StocktakeDto>> GetWithHttpMessagesAsync(string referenceNumber, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a specific stocktake
        /// </summary>
        /// <param name='referenceNumber'>
        /// Identifies the stocktake to update
        /// </param>
        /// <param name='stocktake'>
        /// The data to update for stocktake
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PutWithHttpMessagesAsync(string referenceNumber, StocktakeUpdateDto stocktake, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
