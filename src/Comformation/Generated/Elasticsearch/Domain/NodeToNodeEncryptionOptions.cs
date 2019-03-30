using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// Elasticsearch Domain NodeToNodeEncryptionOptions
    /// The NodeToNodeEncryptionOptions property type specifies whether node-to-node encryption is enabled.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-nodetonodeencryptionoptions.html
    /// </summary>
    public class NodeToNodeEncryptionOptions
    {

        /// <summary>
        /// Enabled
        /// Specifies whether node-to-node encryption is enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
