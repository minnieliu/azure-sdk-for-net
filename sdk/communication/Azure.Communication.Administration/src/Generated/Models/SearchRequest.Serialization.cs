// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial struct SearchRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("numberType");
            writer.WriteStringValue(NumberType.ToString());
            writer.WritePropertyName("assignmentType");
            writer.WriteStringValue(AssignmentType.ToString());
            writer.WritePropertyName("capabilities");
            writer.WriteObjectValue(Capabilities);
            if (Optional.IsDefined(AreaCode))
            {
                writer.WritePropertyName("areaCode");
                writer.WriteStringValue(AreaCode);
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity");
                writer.WriteNumberValue(Quantity.Value);
            }
            writer.WriteEndObject();
        }
    }
}
