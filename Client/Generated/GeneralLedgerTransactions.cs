// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace visma
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Models;

    /// <summary>
    /// GeneralLedgerTransactions operations.
    /// </summary>
    public partial class GeneralLedgerTransactions : IServiceOperations<VismanetAPI>, IGeneralLedgerTransactions
    {
        /// <summary>
        /// Initializes a new instance of the GeneralLedgerTransactions class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public GeneralLedgerTransactions(VismanetAPI client)
        {
            if (client == null) 
            {
                throw new ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the VismanetAPI
        /// </summary>
        public VismanetAPI Client { get; private set; }

        /// <summary>
        /// Get a range of General Ledger Transactions
        /// </summary>
        /// <param name='branch'>
        /// Mandatory
        /// </param>
        /// <param name='ledger'>
        /// Mandatory
        /// </param>
        /// <param name='fromPeriod'>
        /// Mandatory
        /// </param>
        /// <param name='toPeriod'>
        /// Mandatory
        /// </param>
        /// <param name='account'>
        /// Mandatory
        /// </param>
        /// <param name='subaccountId'>
        /// </param>
        /// <param name='fromDate'>
        /// </param>
        /// <param name='toDate'>
        /// </param>
        /// <param name='includeUnposted'>
        /// </param>
        /// <param name='includeUnreleased'>
        /// </param>
        /// <param name='skipRecords'>
        /// </param>
        /// <param name='numberToRead'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<IList<GeneralLedgerTransactionDetailsDto>>> GetAllWithHttpMessagesAsync(string branch = default(string), string ledger = default(string), string fromPeriod = default(string), string toPeriod = default(string), string account = default(string), string subaccountId = default(string), string fromDate = default(string), string toDate = default(string), bool? includeUnposted = default(bool?), bool? includeUnreleased = default(bool?), int? skipRecords = default(int?), int? numberToRead = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("branch", branch);
                tracingParameters.Add("ledger", ledger);
                tracingParameters.Add("fromPeriod", fromPeriod);
                tracingParameters.Add("toPeriod", toPeriod);
                tracingParameters.Add("account", account);
                tracingParameters.Add("subaccountId", subaccountId);
                tracingParameters.Add("fromDate", fromDate);
                tracingParameters.Add("toDate", toDate);
                tracingParameters.Add("includeUnposted", includeUnposted);
                tracingParameters.Add("includeUnreleased", includeUnreleased);
                tracingParameters.Add("skipRecords", skipRecords);
                tracingParameters.Add("numberToRead", numberToRead);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetAll", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "controller/api/v1/GeneralLedgerTransactions").ToString();
            List<string> _queryParameters = new List<string>();
            if (branch != null)
            {
                _queryParameters.Add(string.Format("branch={0}", Uri.EscapeDataString(branch)));
            }
            if (ledger != null)
            {
                _queryParameters.Add(string.Format("ledger={0}", Uri.EscapeDataString(ledger)));
            }
            if (fromPeriod != null)
            {
                _queryParameters.Add(string.Format("fromPeriod={0}", Uri.EscapeDataString(fromPeriod)));
            }
            if (toPeriod != null)
            {
                _queryParameters.Add(string.Format("toPeriod={0}", Uri.EscapeDataString(toPeriod)));
            }
            if (account != null)
            {
                _queryParameters.Add(string.Format("account={0}", Uri.EscapeDataString(account)));
            }
            if (subaccountId != null)
            {
                _queryParameters.Add(string.Format("subaccountId={0}", Uri.EscapeDataString(subaccountId)));
            }
            if (fromDate != null)
            {
                _queryParameters.Add(string.Format("fromDate={0}", Uri.EscapeDataString(fromDate)));
            }
            if (toDate != null)
            {
                _queryParameters.Add(string.Format("toDate={0}", Uri.EscapeDataString(toDate)));
            }
            if (includeUnposted != null)
            {
                _queryParameters.Add(string.Format("includeUnposted={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(includeUnposted, this.Client.SerializationSettings).Trim('"'))));
            }
            if (includeUnreleased != null)
            {
                _queryParameters.Add(string.Format("includeUnreleased={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(includeUnreleased, this.Client.SerializationSettings).Trim('"'))));
            }
            if (skipRecords != null)
            {
                _queryParameters.Add(string.Format("skipRecords={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(skipRecords, this.Client.SerializationSettings).Trim('"'))));
            }
            if (numberToRead != null)
            {
                _queryParameters.Add(string.Format("numberToRead={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(numberToRead, this.Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new Uri(_url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<IList<GeneralLedgerTransactionDetailsDto>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<GeneralLedgerTransactionDetailsDto>>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
