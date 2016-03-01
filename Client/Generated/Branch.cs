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
    /// Branch operations.
    /// </summary>
    public partial class Branch : IServiceOperations<VismanetAPI>, IBranch
    {
        /// <summary>
        /// Initializes a new instance of the Branch class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public Branch(VismanetAPI client)
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
        /// Get a range of Branches
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
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<IList<BranchDto>>> GetAllBranchesWithHttpMessagesAsync(string greaterThanValue = default(string), int? numberToRead = default(int?), int? skipRecords = default(int?), string orderBy = default(string), string lastModifiedDateTime = default(string), string lastModifiedDateTimeCondition = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("greaterThanValue", greaterThanValue);
                tracingParameters.Add("numberToRead", numberToRead);
                tracingParameters.Add("skipRecords", skipRecords);
                tracingParameters.Add("orderBy", orderBy);
                tracingParameters.Add("lastModifiedDateTime", lastModifiedDateTime);
                tracingParameters.Add("lastModifiedDateTimeCondition", lastModifiedDateTimeCondition);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetAllBranches", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "controller/api/v1/branch").ToString();
            List<string> _queryParameters = new List<string>();
            if (greaterThanValue != null)
            {
                _queryParameters.Add(string.Format("greaterThanValue={0}", Uri.EscapeDataString(greaterThanValue)));
            }
            if (numberToRead != null)
            {
                _queryParameters.Add(string.Format("numberToRead={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(numberToRead, this.Client.SerializationSettings).Trim('"'))));
            }
            if (skipRecords != null)
            {
                _queryParameters.Add(string.Format("skipRecords={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(skipRecords, this.Client.SerializationSettings).Trim('"'))));
            }
            if (orderBy != null)
            {
                _queryParameters.Add(string.Format("orderBy={0}", Uri.EscapeDataString(orderBy)));
            }
            if (lastModifiedDateTime != null)
            {
                _queryParameters.Add(string.Format("lastModifiedDateTime={0}", Uri.EscapeDataString(lastModifiedDateTime)));
            }
            if (lastModifiedDateTimeCondition != null)
            {
                _queryParameters.Add(string.Format("lastModifiedDateTimeCondition={0}", Uri.EscapeDataString(lastModifiedDateTimeCondition)));
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
            var _result = new HttpOperationResponse<IList<BranchDto>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<IList<BranchDto>>(_responseContent, this.Client.DeserializationSettings);
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

        /// <summary>
        /// Get a specific branch
        /// </summary>
        /// <param name='branchNumber'>
        /// Identifies the branch
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
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<BranchDto>> GetSpecificBranchWithHttpMessagesAsync(string branchNumber, string greaterThanValue = default(string), int? numberToRead = default(int?), int? skipRecords = default(int?), string orderBy = default(string), string lastModifiedDateTime = default(string), string lastModifiedDateTimeCondition = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (branchNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "branchNumber");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("branchNumber", branchNumber);
                tracingParameters.Add("greaterThanValue", greaterThanValue);
                tracingParameters.Add("numberToRead", numberToRead);
                tracingParameters.Add("skipRecords", skipRecords);
                tracingParameters.Add("orderBy", orderBy);
                tracingParameters.Add("lastModifiedDateTime", lastModifiedDateTime);
                tracingParameters.Add("lastModifiedDateTimeCondition", lastModifiedDateTimeCondition);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetSpecificBranch", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "controller/api/v1/branch/{branchNumber}").ToString();
            _url = _url.Replace("{branchNumber}", Uri.EscapeDataString(branchNumber));
            List<string> _queryParameters = new List<string>();
            if (greaterThanValue != null)
            {
                _queryParameters.Add(string.Format("greaterThanValue={0}", Uri.EscapeDataString(greaterThanValue)));
            }
            if (numberToRead != null)
            {
                _queryParameters.Add(string.Format("numberToRead={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(numberToRead, this.Client.SerializationSettings).Trim('"'))));
            }
            if (skipRecords != null)
            {
                _queryParameters.Add(string.Format("skipRecords={0}", Uri.EscapeDataString(SafeJsonConvert.SerializeObject(skipRecords, this.Client.SerializationSettings).Trim('"'))));
            }
            if (orderBy != null)
            {
                _queryParameters.Add(string.Format("orderBy={0}", Uri.EscapeDataString(orderBy)));
            }
            if (lastModifiedDateTime != null)
            {
                _queryParameters.Add(string.Format("lastModifiedDateTime={0}", Uri.EscapeDataString(lastModifiedDateTime)));
            }
            if (lastModifiedDateTimeCondition != null)
            {
                _queryParameters.Add(string.Format("lastModifiedDateTimeCondition={0}", Uri.EscapeDataString(lastModifiedDateTimeCondition)));
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
            var _result = new HttpOperationResponse<BranchDto>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<BranchDto>(_responseContent, this.Client.DeserializationSettings);
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
