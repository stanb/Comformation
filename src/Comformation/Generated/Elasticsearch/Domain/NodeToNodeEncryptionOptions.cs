using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain NodeToNodeEncryptionOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-nodetonodeencryptionoptions.html
    /// </summary>
    public class NodeToNodeEncryptionOptions
    {

        /// <summary>
        /// Enabled
        /// Specifies whether node-to-node encryption is enabled, as a Boolean.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
