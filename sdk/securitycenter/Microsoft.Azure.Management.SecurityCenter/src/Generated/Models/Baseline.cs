// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Baseline details.
    /// </summary>
    public partial class Baseline
    {
        /// <summary>
        /// Initializes a new instance of the Baseline class.
        /// </summary>
        public Baseline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Baseline class.
        /// </summary>
        /// <param name="expectedResults">Expected results.</param>
        /// <param name="updatedTime">Baseline update time (UTC).</param>
        public Baseline(IList<IList<string>> expectedResults = default(IList<IList<string>>), System.DateTime? updatedTime = default(System.DateTime?))
        {
            ExpectedResults = expectedResults;
            UpdatedTime = updatedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets expected results.
        /// </summary>
        [JsonProperty(PropertyName = "expectedResults")]
        public IList<IList<string>> ExpectedResults { get; set; }

        /// <summary>
        /// Gets or sets baseline update time (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "updatedTime")]
        public System.DateTime? UpdatedTime { get; set; }

    }
}
