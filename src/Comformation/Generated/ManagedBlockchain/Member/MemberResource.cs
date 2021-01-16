using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html
    /// </summary>
    public class MemberResource : ResourceBase
    {
        public class MemberProperties
        {
            /// <summary>
            /// MemberConfiguration
            /// Configuration properties of the member.
            /// Required: Yes
            /// Type: MemberConfiguration
            /// Update requires: No interruption
            /// </summary>
            public MemberConfiguration MemberConfiguration { get; set; }

            /// <summary>
            /// NetworkConfiguration
            /// Configuration properties of the network to which the member belongs.
            /// Required: No
            /// Type: NetworkConfiguration
            /// Update requires: No interruption
            /// </summary>
            public NetworkConfiguration NetworkConfiguration { get; set; }

            /// <summary>
            /// NetworkId
            /// The unique identifier of the network to which the member belongs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkId { get; set; }

            /// <summary>
            /// InvitationId
            /// The unique identifier of the invitation to join the network sent to the account that creates the
            /// member.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InvitationId { get; set; }

        }

        public string Type { get; } = "AWS::ManagedBlockchain::Member";

        public MemberProperties Properties { get; } = new MemberProperties();

    }

    public static class MemberAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MemberId = new ResourceAttribute<Union<string, IntrinsicFunction>>("MemberId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkId = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkId");
    }
}
