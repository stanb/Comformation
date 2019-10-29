using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member MemberFabricConfiguration
    /// Configuration properties for Hyperledger Fabric for a member in a Managed Blockchain network using the
    /// Hyperledger Fabric framework.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberfabricconfiguration.html
    /// </summary>
    public class MemberFabricConfiguration
    {

        /// <summary>
        /// AdminUsername
        /// The user name for the member&#39;s initial administrative user.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 16
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdminUsername")]
        public Union<string, IntrinsicFunction> AdminUsername { get; set; }

        /// <summary>
        /// AdminPassword
        /// The password for the member&#39;s initial administrative user. The AdminPassword must be at least eight
        /// characters long and no more than 32 characters. It must contain at least one uppercase letter, one
        /// lowercase letter, and one digit. It cannot have a single quote(‘), double quote(“), forward
        /// slash(/), backward slash(\), @, or a space.
        /// Required: Yes
        /// Type: String
        /// Minimum: 8
        /// Maximum: 32
        /// Pattern: ^(?=. *[a-z])(?=. *[A-Z])(?=. *\d)(?!. *[@&#39;\\&quot;/])[a-zA-Z0-9\S]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdminPassword")]
        public Union<string, IntrinsicFunction> AdminPassword { get; set; }

    }
}
