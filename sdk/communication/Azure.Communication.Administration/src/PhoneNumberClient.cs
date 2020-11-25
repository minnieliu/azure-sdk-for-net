// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Administration.Models;
using Azure.Communication.Pipeline;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Administration
{
    /// <summary>
    /// The Azure Communication Services phone number administration client.
    /// </summary>
    public class PhoneNumberClient
    {
        /// <summary>Initializes a new instance of <see cref="PhoneNumberClient"/> for mocking.</summary>
        protected PhoneNumberClient()
        { }

        /// <summary> Starts a phone number search. </summary>
        /// <param name="countryCode"> Country code for the phone number search </param>
        /// <param name="searchRequest"> Defines the search options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{SearchResult}"/>. </returns>
        public virtual async Task<Operation<SearchResult>> StartSearchPhoneNumberAsync(String countryCode, SearchRequest searchRequest, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts a phone number search. </summary>
        /// <param name="countryCode"> Country code for the phone number search </param>
        /// <param name="searchRequest"> Defines the search options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{SearchResult}"/>. </returns>
        public virtual Operation<SearchResult> StartSearchPhoneNumber(String countryCode, SearchRequest searchRequest, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Starts purchase for the phone number search. </summary>
        /// <param name="searchId"> The search id to be purchased. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="SearchResult"/>. </returns>
        public virtual async Task<Operation<SearchResult>> StartPurchasePhoneNumberAsync(string searchId, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts purchase for the phone number search. </summary>
        /// <param name="searchId"> The search id to be purchased. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="SearchResult"/>. </returns>
        public virtual Operation<SearchResult> StartPurchasePhoneNumber(string searchId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets phone number search results. </summary>
        /// <param name="searchId"> The search id to be purchased. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{SearchResult}"/>. </returns>
        public virtual Task<Response<SearchResult>> GetSearchResultsAsync(string searchId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets phone number search results. </summary>
        /// <param name="searchId"> The search id to be purchased. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{SearchResult}"/>. </returns>
        public virtual Response<SearchResult> GetSearchResults(string searchId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets the operation. </summary>
        /// <param name="operationId"> The operation id to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{PhoneNumberOperation}"/>. </returns>
        public virtual Task<Response<PhoneNumberOperation>> GetPhoneNumberOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets the operation. </summary>
        /// <param name="operationId"> The operation id to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{PhoneNumberOperation}"/>. </returns>
        public virtual Response<PhoneNumberOperation> GetPhoneNumberOperation(string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Cancels the operation. </summary>
        /// <param name="operationId"> The operation id to cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response"/>. </returns>
        public virtual Task<Response> CancelPhoneNumberOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Cancels the operation. </summary>
        /// <param name="operationId"> The operation id to cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response"/>. </returns>
        public virtual Response CancelPhoneNumberOperation(string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Lists all the acquired phone numbers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="AsyncPageable{AcquiredPhoneNumbers}"/>. </returns>
        public virtual AsyncPageable<AcquiredPhoneNumber> ListAcquiredPhoneNumbersAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Lists all the acquired phone numbers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Pageable{AcquiredPhoneNumber}"/>. </returns>
        public virtual Pageable<AcquiredPhoneNumber> ListAcquiredPhoneNumbers(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets the acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{AcquiredPhoneNumber}"/>. </returns>
        public virtual Task<Response<AcquiredPhoneNumber>> GetAcquiredPhoneNumberAsync(PhoneNumber phoneNumber, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets the acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{AcquiredPhoneNumber}"/>. </returns>
        public virtual Response<AcquiredPhoneNumber> GetAcquiredPhoneNumber(PhoneNumber phoneNumber, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Starts an update for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number in the release request. </param>
        /// <param name="update"> The properties of a phone number to be udpated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{AcquiredPhoneNumber}"/>. </returns>
        public virtual async Task<Operation<AcquiredPhoneNumber>> StartUpdatePhoneNumberAsync(PhoneNumber phoneNumber, AcquiredPhoneNumberUpdate update, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts a release for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number in the release request. </param>
        /// <param name="update"> The properties of a phone number to be udpated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{AcquiredPhoneNumber}"/>. </returns>
        public virtual Operation<AcquiredPhoneNumber> StartUpdatePhoneNumber(PhoneNumber phoneNumber, AcquiredPhoneNumberUpdate update, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Starts a release for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number in the release request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{PhoneNumberRelease}"/>. </returns>
        public virtual async Task<Operation<PhoneNumberRelease>> StartReleasePhoneNumberAsync(PhoneNumber phoneNumber, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts a release for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number in the release request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{PhoneNumberRelease}"/>. </returns>
        public virtual Operation<PhoneNumberRelease> StartReleasePhoneNumber(PhoneNumber phoneNumber, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
