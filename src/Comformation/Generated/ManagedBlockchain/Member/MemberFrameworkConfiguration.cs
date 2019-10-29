using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member MemberFrameworkConfiguration
    /// Configuration properties relevant to a member for the blockchain framework that the Managed Blockchain network
    /// uses.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberframeworkconfiguration.html
    /// </summary>
    public class MemberFrameworkConfiguration
    {

        /// <summary>
        /// MemberFabricConfiguration
        /// Configuration properties for Hyperledger Fabric.
        /// Required: No
        /// Type: MemberFabricConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MemberFabricConfiguration")]
        public MemberFabricConfiguration MemberFabricConfiguration { get; set; }

    }
}
