using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Node
{
    /// <summary>
    /// AWS::ManagedBlockchain::Node NodeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-node-nodeconfiguration.html
    /// </summary>
    public class NodeConfiguration
    {

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone in which the node exists. Required for Ethereum nodes. Ethereum on Managed
        /// Blockchain is in preview release and is subject to change.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// InstanceType
        /// The Amazon Managed Blockchain instance type for the node.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

    }
}
