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
        /// <summary>
        /// Initializes a phone number client with an Azure resource connection string.
        /// </summary>
        public PhoneNumberClient(string connectionString) : this()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a phone number client with an Azure resource connection string and client options.
        /// </summary>
        public PhoneNumberClient(string connectionString, PhoneNumberClientOptions? options = default)
        {
            throw new NotImplementedException();
        }

        internal PhoneNumberClient(PhoneNumberClientOptions options, ConnectionString connectionString)
        {
            throw new NotImplementedException();
        }

        internal PhoneNumberClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpointUrl)
        {
            throw new NotImplementedException();
        }
        /// <summary>Initializes a new instance of <see cref="PhoneNumberClient"/> for mocking.</summary>
        protected PhoneNumberClient()
        {
            throw new NotImplementedException();
        }

        /// <summary> Starts a phone number search for available numbers. </summary>
        /// <param name="countryCode"> Country code for the phone number search </param>
        /// <param name="numberType"> The phone number type. </param>
        /// <param name="assignmentType"> The phone number&apos;s assignment type. </param>
        /// <param name="capabilities"> The phone number&apos;s capabilities. </param>
        /// <param name="areaCode"> The desired area code. </param>
        /// <param name="quantity"> The desired quantity of phone numbers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{SearchResult}"/>. </returns>
        public virtual async Task<Operation<SearchResult>> StartSearchAvailablePhoneNumbersAsync(string countryCode, PhoneNumberType numberType, AssignmentType assignmentType, CapabilitiesRequest capabilities, string areaCode, int? quantity, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts a phone number search for available numbers. </summary>
        /// <param name="countryCode"> Country code for the phone number search </param>
        /// <param name="numberType"> The phone number type. </param>
        /// <param name="assignmentType"> The phone number's assignment type. </param>
        /// <param name="capabilities"> The phone number's capabilities. </param>
        /// <param name="areaCode"> The desired area code. </param>
        /// <param name="quantity"> The desired quantity of phone numbers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{SearchResult}"/>. </returns>
        public virtual Operation<SearchResult> StartSearchAvailablePhoneNumbers(string countryCode, PhoneNumberType numberType, AssignmentType assignmentType, CapabilitiesRequest capabilities, string areaCode, int? quantity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Starts purchase for the phone number search. </summary>
        /// <param name="searchId"> The search id to be purchased. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="SearchResult"/>. </returns>
        public virtual async Task<Operation<SearchResult>> StartPurchasePhoneNumbersAsync(string searchId, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts purchase for the phone number search. </summary>
        /// <param name="searchId"> The search id to be purchased. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="SearchResult"/>. </returns>
        public virtual Operation<SearchResult> StartPurchasePhoneNumbers(string searchId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Lists the acquired phone numbers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="AsyncPageable{AcquiredPhoneNumbers}"/>. </returns>
        public virtual AsyncPageable<AcquiredPhoneNumber> ListPhoneNumbersAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Lists the acquired phone numbers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Pageable{AcquiredPhoneNumber}"/>. </returns>
        public virtual Pageable<AcquiredPhoneNumber> ListPhoneNumbers(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets the acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{AcquiredPhoneNumber}"/>. </returns>
        public virtual Task<Response<AcquiredPhoneNumber>> GetPhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets the acquired phone number. </summary>
        /// <param name="phoneNumber"> The phone number to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Response{AcquiredPhoneNumber}"/>. </returns>
        public virtual Response<AcquiredPhoneNumber> GetPhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Starts an update for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number to update. </param>
        /// <param name="callbackurl"> The updatd callback url</param>
        /// <param name="applicationId"> The updated application id</param>
        /// <param name="capabilities"> The updated capabilities</param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{AcquiredPhoneNumber}"/>. </returns>
        public virtual async Task<Operation<AcquiredPhoneNumber>> StartUpdatePhoneNumberAsync(string phoneNumber, string callbackurl, string applicationId, CapabilitiesRequest capabilities, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts a release for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number to update. </param>
        /// <param name="callbackurl"> The updatd callback url</param>
        /// <param name="applicationId"> The updated application id</param>
        /// <param name="capabilities"> The updated capabilities</param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{AcquiredPhoneNumber}"/>. </returns>
        public virtual Operation<AcquiredPhoneNumber> StartUpdatePhoneNumber(string phoneNumber, string callbackurl, string applicationId, CapabilitiesRequest capabilities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Starts a release for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number in the release request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{PhoneNumberRelease}"/>. </returns>
        public virtual async Task<Operation<PhoneNumberRelease>> StartReleasePhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary> Starts a release for the given phone number. </summary>
        /// <param name="phoneNumber"> The phone number in the release request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A <see cref="Operation{PhoneNumberRelease}"/>. </returns>
        public virtual Operation<PhoneNumberRelease> StartReleasePhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
