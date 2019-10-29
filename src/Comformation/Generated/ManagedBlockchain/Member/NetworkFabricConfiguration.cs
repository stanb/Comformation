using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member NetworkFabricConfiguration
    /// Hyperledger Fabric configuration properties for the network.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkfabricconfiguration.html
    /// </summary>
    public class NetworkFabricConfiguration
    {

        /// <summary>
        /// Edition
        /// The edition of Amazon Managed Blockchain that the network uses. Valid values are standard and
        /// starter. For more information, see
        /// Required: Yes
        /// Type: String
        /// Allowed Values: STANDARD | STARTER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Edition")]
        public Union<string, IntrinsicFunction> Edition { get; set; }

    }
}
