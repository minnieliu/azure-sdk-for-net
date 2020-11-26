// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Communication.Administration.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Administration
{
    internal partial class PhoneNumberAdministrationRestClient
    {
        private string endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PhoneNumberAdministrationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public PhoneNumberAdministrationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateSearchAvailablePhoneNumbersRequest(string countryCode, PhoneNumberType numberType, AssignmentType assignmentType, CapabilitiesRequest capabilities, string areaCode, int? quantity)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/availablePhoneNumbers/countries/", false);
            uri.AppendPath(countryCode, true);
            uri.AppendPath("/~search", false);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var model = new SearchRequest(numberType, assignmentType, capabilities, areaCode, quantity);
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code. </param>
        /// <param name="numberType"> The phone number type. </param>
        /// <param name="assignmentType"> The phone number&apos;s assignment type. </param>
        /// <param name="capabilities"> The phone number&apos;s capabilities. </param>
        /// <param name="areaCode"> The desired area code. </param>
        /// <param name="quantity"> The desired quantity of phone numbers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="capabilities"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumberAdministrationSearchAvailablePhoneNumbersHeaders>> SearchAvailablePhoneNumbersAsync(string countryCode, PhoneNumberType numberType, AssignmentType assignmentType, CapabilitiesRequest capabilities, string areaCode = null, int? quantity = null, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (capabilities == null)
            {
                throw new ArgumentNullException(nameof(capabilities));
            }

            using var message = CreateSearchAvailablePhoneNumbersRequest(countryCode, numberType, assignmentType, capabilities, areaCode, quantity);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumberAdministrationSearchAvailablePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code. </param>
        /// <param name="numberType"> The phone number type. </param>
        /// <param name="assignmentType"> The phone number&apos;s assignment type. </param>
        /// <param name="capabilities"> The phone number&apos;s capabilities. </param>
        /// <param name="areaCode"> The desired area code. </param>
        /// <param name="quantity"> The desired quantity of phone numbers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="capabilities"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumberAdministrationSearchAvailablePhoneNumbersHeaders> SearchAvailablePhoneNumbers(string countryCode, PhoneNumberType numberType, AssignmentType assignmentType, CapabilitiesRequest capabilities, string areaCode = null, int? quantity = null, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (capabilities == null)
            {
                throw new ArgumentNullException(nameof(capabilities));
            }

            using var message = CreateSearchAvailablePhoneNumbersRequest(countryCode, numberType, assignmentType, capabilities, areaCode, quantity);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumberAdministrationSearchAvailablePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSearchResultRequest(string searchId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/availablePhoneNumbers/searchResults/", false);
            uri.AppendPath(searchId, true);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a search result by its id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchId"/> is null. </exception>
        public async Task<Response<SearchResult>> GetSearchResultAsync(string searchId, CancellationToken cancellationToken = default)
        {
            if (searchId == null)
            {
                throw new ArgumentNullException(nameof(searchId));
            }

            using var message = CreateGetSearchResultRequest(searchId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchResult.DeserializeSearchResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a search result by its id. </summary>
        /// <param name="searchId"> The search Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchId"/> is null. </exception>
        public Response<SearchResult> GetSearchResult(string searchId, CancellationToken cancellationToken = default)
        {
            if (searchId == null)
            {
                throw new ArgumentNullException(nameof(searchId));
            }

            using var message = CreateGetSearchResultRequest(searchId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchResult.DeserializeSearchResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePurchasePhoneNumbersRequest(string searchId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/availablePhoneNumbers/~purchase", false);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var model = new PurchaseRequest()
            {
                SearchId = searchId
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Purchase phone numbers. </summary>
        /// <param name="searchId"> The id of the search result to purchase. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<PhoneNumberAdministrationPurchasePhoneNumbersHeaders>> PurchasePhoneNumbersAsync(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePurchasePhoneNumbersRequest(searchId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumberAdministrationPurchasePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Purchase phone numbers. </summary>
        /// <param name="searchId"> The id of the search result to purchase. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<PhoneNumberAdministrationPurchasePhoneNumbersHeaders> PurchasePhoneNumbers(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePurchasePhoneNumbersRequest(searchId);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumberAdministrationPurchasePhoneNumbersHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOperationRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/phoneNumbers/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get an operation by its id. </summary>
        /// <param name="operationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<Response<PhoneNumberOperation>> GetOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberOperation value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PhoneNumberOperation.DeserializePhoneNumberOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get an operation by its id. </summary>
        /// <param name="operationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public Response<PhoneNumberOperation> GetOperation(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateGetOperationRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PhoneNumberOperation value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PhoneNumberOperation.DeserializePhoneNumberOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelOperationRequest(string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/phoneNumbers/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancels the operation if cancellation is supported for the operation type. </summary>
        /// <param name="operationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public async Task<Response> CancelOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateCancelOperationRequest(operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Cancels the operation if cancellation is supported for the operation type. </summary>
        /// <param name="operationId"> The operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public Response CancelOperation(string operationId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            using var message = CreateCancelOperationRequest(operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListPhoneNumbersRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/phoneNumbers", false);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists acquired phone numbers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AcquiredPhoneNumbers>> ListPhoneNumbersAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListPhoneNumbersRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcquiredPhoneNumbers value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AcquiredPhoneNumbers.DeserializeAcquiredPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists acquired phone numbers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AcquiredPhoneNumbers> ListPhoneNumbers(CancellationToken cancellationToken = default)
        {
            using var message = CreateListPhoneNumbersRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcquiredPhoneNumbers value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AcquiredPhoneNumbers.DeserializeAcquiredPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetPhoneNumberRequest(string phoneNumber)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets information about an acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<Response<AcquiredPhoneNumber>> GetPhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateGetPhoneNumberRequest(phoneNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcquiredPhoneNumber value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AcquiredPhoneNumber.DeserializeAcquiredPhoneNumber(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets information about an acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public Response<AcquiredPhoneNumber> GetPhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateGetPhoneNumberRequest(phoneNumber);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcquiredPhoneNumber value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AcquiredPhoneNumber.DeserializeAcquiredPhoneNumber(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdatePhoneNumberRequest(string phoneNumber, string callbackUrl, string applicationId, CapabilitiesRequest capabilities)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Headers.Add("Accept", "application/json");
            var model = new AcquiredPhoneNumberUpdate()
            {
                CallbackUrl = callbackUrl,
                ApplicationId = applicationId,
                Capabilities = capabilities
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Update an acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B. </param>
        /// <param name="callbackUrl"> The webhook URL for receiving incoming events. </param>
        /// <param name="applicationId"> The application id the number has been assigned to. </param>
        /// <param name="capabilities"> The new set of enabled capabilities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumberAdministrationUpdatePhoneNumberHeaders>> UpdatePhoneNumberAsync(string phoneNumber, string callbackUrl = null, string applicationId = null, CapabilitiesRequest capabilities = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateUpdatePhoneNumberRequest(phoneNumber, callbackUrl, applicationId, capabilities);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumberAdministrationUpdatePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update an acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B. </param>
        /// <param name="callbackUrl"> The webhook URL for receiving incoming events. </param>
        /// <param name="applicationId"> The application id the number has been assigned to. </param>
        /// <param name="capabilities"> The new set of enabled capabilities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumberAdministrationUpdatePhoneNumberHeaders> UpdatePhoneNumber(string phoneNumber, string callbackUrl = null, string applicationId = null, CapabilitiesRequest capabilities = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateUpdatePhoneNumberRequest(phoneNumber, callbackUrl, applicationId, capabilities);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumberAdministrationUpdatePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReleasePhoneNumberRequest(string phoneNumber)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/phoneNumbers/", false);
            uri.AppendPath(phoneNumber, true);
            uri.AppendQuery("api-version", "2020-07-20-preview1", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Releases an acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public async Task<ResponseWithHeaders<PhoneNumberAdministrationReleasePhoneNumberHeaders>> ReleasePhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateReleasePhoneNumberRequest(phoneNumber);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new PhoneNumberAdministrationReleasePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Releases an acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public ResponseWithHeaders<PhoneNumberAdministrationReleasePhoneNumberHeaders> ReleasePhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var message = CreateReleasePhoneNumberRequest(phoneNumber);
            _pipeline.Send(message, cancellationToken);
            var headers = new PhoneNumberAdministrationReleasePhoneNumberHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListPhoneNumbersNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists acquired phone numbers. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<AcquiredPhoneNumbers>> ListPhoneNumbersNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListPhoneNumbersNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcquiredPhoneNumbers value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AcquiredPhoneNumbers.DeserializeAcquiredPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists acquired phone numbers. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<AcquiredPhoneNumbers> ListPhoneNumbersNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListPhoneNumbersNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcquiredPhoneNumbers value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AcquiredPhoneNumbers.DeserializeAcquiredPhoneNumbers(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
