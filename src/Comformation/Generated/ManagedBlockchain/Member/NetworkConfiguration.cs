using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member NetworkConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        /// Description
        /// Attributes of the blockchain framework for the network.
        /// Required: No
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// FrameworkVersion
        /// The version of the blockchain framework that the network uses.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 8
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FrameworkVersion")]
        public Union<string, IntrinsicFunction> FrameworkVersion { get; set; }

        /// <summary>
        /// VotingPolicy
        /// The voting rules for the network to decide if a proposal is accepted.
        /// Required: Yes
        /// Type: VotingPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VotingPolicy")]
        public VotingPolicy VotingPolicy { get; set; }

        /// <summary>
        /// Framework
        /// The blockchain framework that the network uses.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ETHEREUM | HYPERLEDGER_FABRIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Framework")]
        public Union<string, IntrinsicFunction> Framework { get; set; }

        /// <summary>
        /// Name
        /// The name of the network.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// NetworkFrameworkConfiguration
        /// Configuration properties relevant to the network for the blockchain framework that the network uses.
        /// Required: No
        /// Type: NetworkFrameworkConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkFrameworkConfiguration")]
        public NetworkFrameworkConfiguration NetworkFrameworkConfiguration { get; set; }

    }
}
