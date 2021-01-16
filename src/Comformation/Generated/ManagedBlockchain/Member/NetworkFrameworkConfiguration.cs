using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member NetworkFrameworkConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkframeworkconfiguration.html
    /// </summary>
    public class NetworkFrameworkConfiguration
    {

        /// <summary>
        /// NetworkFabricConfiguration
        /// Configuration properties for Hyperledger Fabric for a member in a Managed Blockchain network using
        /// the Hyperledger Fabric framework.
        /// Required: No
        /// Type: NetworkFabricConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkFabricConfiguration")]
        public NetworkFabricConfiguration NetworkFabricConfiguration { get; set; }

    }
}
