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
    /// InventoryTransfer operations.
    /// </summary>
    public partial interface IInventoryTransfer
    {
        /// <summary>
        /// Get a range of Inventory Transfers
        /// </summary>
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<InventoryTransferDto>>> GetAllWithHttpMessagesAsync(string greaterThanValue = default(string), int? numberToRead = default(int?), int? skipRecords = default(int?), string orderBy = default(string), string lastModifiedDateTime = default(string), string lastModifiedDateTimeCondition = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create an inventory transfer
        /// </summary>
        /// <param name='inventoryTransfer'>
        /// Define the data for the inventory transfer to create
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostWithHttpMessagesAsync(InventoryTransferUpdateDto inventoryTransfer, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a specific Inventory Transfer document
        /// </summary>
        /// <param name='inventoryTransferNumber'>
        /// Identifies the Inventory Transfer document
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<InventoryTransferDto>> GetWithHttpMessagesAsync(string inventoryTransferNumber, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Release inventory operation
        /// </summary>
        /// <param name='transferNumber'>
        /// Reference number of the released transfer to be released
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ReleaseInventoryDocumentActionResultDto>> ReleaseDocumentWithHttpMessagesAsync(string transferNumber, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a specific inventory transfer
        /// </summary>
        /// <param name='transferRefNumber'>
        /// Identifies the inventory transfer to update
        /// </param>
        /// <param name='transfer'>
        /// The data to update for inventory transfer
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PutWithHttpMessagesAsync(string transferRefNumber, InventoryTransferUpdateDto transfer, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
