using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain ColdStorageOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-coldstorageoptions.html
    /// </summary>
    public class ColdStorageOptions
    {

        /// <summary>
        /// Enabled
        /// Whether to enable or disable cold storage on the domain. You must enable UltraWarm storage in order
        /// to enable cold storage.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
