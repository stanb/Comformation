using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.Cluster
{
    /// <summary>
    /// DynamoDB Accelerator Cluster SSESpecification
    /// The SSESpecification property type specifies whether server-side encryption is enabled or not.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-daxservice-cluster-ssespecification.html
    /// </summary>
    public class SSESpecification
    {

        /// <summary>
        /// SSEEnabled
        /// Whether server-side encryption is enabled or not.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEEnabled")]
        public Union<bool, IntrinsicFunction> SSEEnabled { get; set; }

    }
}
