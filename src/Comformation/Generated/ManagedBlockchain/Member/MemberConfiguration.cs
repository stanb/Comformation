using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member MemberConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberconfiguration.html
    /// </summary>
    public class MemberConfiguration
    {

        /// <summary>
        /// Description
        /// An optional description of the member.
        /// Required: No
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// MemberFrameworkConfiguration
        /// Configuration properties of the blockchain framework relevant to the member.
        /// Required: No
        /// Type: MemberFrameworkConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MemberFrameworkConfiguration")]
        public MemberFrameworkConfiguration MemberFrameworkConfiguration { get; set; }

        /// <summary>
        /// Name
        /// The name of the member.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^(?!-|[0-9])(?!. *-$)(?!. *?--)[a-zA-Z0-9-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
