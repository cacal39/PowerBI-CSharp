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
    public partial class Datasource
    {
        /// <summary>
        /// Initializes a new instance of the Datasource class.
        /// </summary>
        public Datasource() { }

        /// <summary>
        /// Initializes a new instance of the Datasource class.
        /// </summary>
        public Datasource(string name = default(string), string connectionString = default(string))
        {
            Name = name;
            ConnectionString = connectionString;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

    }
}
