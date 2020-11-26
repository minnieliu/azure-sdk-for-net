// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Administration.Models
{
    /// <summary> Represents a service error response body. </summary>
    public readonly partial struct ErrorBody
    {
        /// <summary> Initializes a new instance of ErrorBody. </summary>
        /// <param name="code"> The error code in the error response. </param>
        /// <param name="message"> The error message in the error response. </param>
        /// <param name="innerError"> Represents a service error response body. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorBody(string code, string message, ErrorBody? innerError)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            InnerError = innerError;
        }

        /// <summary> The error code in the error response. </summary>
        public string Code { get; }
        /// <summary> The error message in the error response. </summary>
        public string Message { get; }
        /// <summary> Represents a service error response body. </summary>
        public ErrorBody? InnerError { get; }
    }
}
