// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class Row
    {
        /// <summary>
        /// Initializes a new instance of the Row class.
        /// </summary>
        public Row() { }

        /// <summary>
        /// Initializes a new instance of the Row class.
        /// </summary>
        public Row(string id = default(string))
        {
            Id = id;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
