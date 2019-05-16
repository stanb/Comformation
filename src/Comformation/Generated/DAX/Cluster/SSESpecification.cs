using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.Cluster
{
    /// <summary>
    /// AWS::DAX::Cluster SSESpecification
    /// Represents the settings used to enable server-side encryption.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dax-cluster-ssespecification.html
    /// </summary>
    public class SSESpecification
    {

        /// <summary>
        /// SSEEnabled
        /// Indicates whether server-side encryption is enabled (true) or disabled (false) on the cluster.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEEnabled")]
        public Union<bool, IntrinsicFunction> SSEEnabled { get; set; }

    }
}
