// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class PhoneNumberCountry
    {
        internal static PhoneNumberCountry DeserializePhoneNumberCountry(JsonElement element)
        {
            string localizedName = default;
            Optional<string> locale = default;
            string countryCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localizedName"))
                {
                    localizedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locale"))
                {
                    locale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
            }
            return new PhoneNumberCountry(localizedName, locale.Value, countryCode);
        }
    }
}
