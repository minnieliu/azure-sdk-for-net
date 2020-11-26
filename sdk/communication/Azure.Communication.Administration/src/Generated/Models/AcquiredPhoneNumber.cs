// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Administration.Models
{
    /// <summary> The acquired phone number and its metadata and configuration. </summary>
    public partial class AcquiredPhoneNumber
    {
        /// <summary> Initializes a new instance of AcquiredPhoneNumber. </summary>
        /// <param name="id"> The id, this is the same as the phone number in E.164 format. </param>
        /// <param name="phoneNumber"> The phoneNumber in E.164 format. </param>
        /// <param name="countryCode"> The ISO 3166-2 country code of the country that the phone number belongs to. </param>
        /// <param name="numberType"> The type of the phone number. </param>
        /// <param name="assignmentType"> The assignment type of the phone number, people or application. </param>
        /// <param name="purchaseDate"> The purchase date of the phone number. </param>
        /// <param name="capabilities"> The phone number&apos;s capabilities. </param>
        /// <param name="callbackUrl"> The webhook URL for receiving incoming events. </param>
        /// <param name="applicationId"> The application id the number has been assigned to. </param>
        /// <param name="monthlyRate"> The monthly cost of the phone number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="phoneNumber"/>, <paramref name="countryCode"/>, <paramref name="callbackUrl"/>, <paramref name="applicationId"/>, or <paramref name="monthlyRate"/> is null. </exception>
        internal AcquiredPhoneNumber(string id, string phoneNumber, string countryCode, PhoneNumberType numberType, AssignmentType assignmentType, DateTimeOffset purchaseDate, PhoneNumberCapabilities capabilities, string callbackUrl, string applicationId, MonthlyRate monthlyRate)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (callbackUrl == null)
            {
                throw new ArgumentNullException(nameof(callbackUrl));
            }
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }
            if (monthlyRate == null)
            {
                throw new ArgumentNullException(nameof(monthlyRate));
            }

            Id = id;
            PhoneNumber = phoneNumber;
            CountryCode = countryCode;
            NumberType = numberType;
            AssignmentType = assignmentType;
            PurchaseDate = purchaseDate;
            Capabilities = capabilities;
            CallbackUrl = callbackUrl;
            ApplicationId = applicationId;
            MonthlyRate = monthlyRate;
        }

        /// <summary> The id, this is the same as the phone number in E.164 format. </summary>
        public string Id { get; }
        /// <summary> The phoneNumber in E.164 format. </summary>
        public string PhoneNumber { get; }
        /// <summary> The ISO 3166-2 country code of the country that the phone number belongs to. </summary>
        public string CountryCode { get; }
        /// <summary> The type of the phone number. </summary>
        public PhoneNumberType NumberType { get; }
        /// <summary> The assignment type of the phone number, people or application. </summary>
        public AssignmentType AssignmentType { get; }
        /// <summary> The purchase date of the phone number. </summary>
        public DateTimeOffset PurchaseDate { get; }
        /// <summary> The phone number&apos;s capabilities. </summary>
        public PhoneNumberCapabilities Capabilities { get; }
        /// <summary> The webhook URL for receiving incoming events. </summary>
        public string CallbackUrl { get; }
        /// <summary> The application id the number has been assigned to. </summary>
        public string ApplicationId { get; }
        /// <summary> The monthly cost of the phone number. </summary>
        public MonthlyRate MonthlyRate { get; }
    }
}
