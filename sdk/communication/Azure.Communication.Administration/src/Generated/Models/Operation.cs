// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Administration.Models
{
    /// <summary> Long running operation. </summary>
    public partial class Operation
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="status"> Status of operation. </param>
        /// <param name="id"> Id of the operation. </param>
        /// <param name="kind"> Kind of the operation. </param>
        /// <param name="createdDateTime"> The date that the operation was created. </param>
        /// <param name="lastActionDateTime"> The most recent date that the operation was changed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal Operation(OperationStatusCodes status, string id, OperationKind kind, DateTimeOffset createdDateTime, DateTimeOffset lastActionDateTime)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Status = status;
            Id = id;
            Kind = kind;
            CreatedDateTime = createdDateTime;
            LastActionDateTime = lastActionDateTime;
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="status"> Status of operation. </param>
        /// <param name="id"> Id of the operation. </param>
        /// <param name="kind"> Kind of the operation. </param>
        /// <param name="createdDateTime"> The date that the operation was created. </param>
        /// <param name="lastActionDateTime"> The most recent date that the operation was changed. </param>
        /// <param name="resourceLocation"> Url for retrieving the result of the operation if any. </param>
        /// <param name="error"> Represents a service error response body. </param>
        internal Operation(OperationStatusCodes status, string id, OperationKind kind, DateTimeOffset createdDateTime, DateTimeOffset lastActionDateTime, string resourceLocation, ErrorBody error)
        {
            Status = status;
            Id = id;
            Kind = kind;
            CreatedDateTime = createdDateTime;
            LastActionDateTime = lastActionDateTime;
            ResourceLocation = resourceLocation;
            Error = error;
        }

        /// <summary> Status of operation. </summary>
        public OperationStatusCodes Status { get; }
        /// <summary> Id of the operation. </summary>
        public string Id { get; }
        /// <summary> Kind of the operation. </summary>
        public OperationKind Kind { get; }
        /// <summary> The date that the operation was created. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> The most recent date that the operation was changed. </summary>
        public DateTimeOffset LastActionDateTime { get; }
        /// <summary> Url for retrieving the result of the operation if any. </summary>
        public string ResourceLocation { get; }
        /// <summary> Represents a service error response body. </summary>
        public ErrorBody Error { get; }
    }
}
