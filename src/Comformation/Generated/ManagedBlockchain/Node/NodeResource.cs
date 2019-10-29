using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Node
{
    /// <summary>
    /// AWS::ManagedBlockchain::Node
    /// Creates a peer node in a member.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-node.html
    /// </summary>
    public class NodeResource : ResourceBase
    {
        public class NodeProperties
        {
            /// <summary>
            /// MemberId
            /// The unique identifier of the member to which the node belongs.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MemberId { get; set; }

            /// <summary>
            /// NetworkId
            /// The unique identifier of the network that the node is in.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkId { get; set; }

            /// <summary>
            /// NodeConfiguration
            /// Configuration properties of a peer node.
            /// Required: Yes
            /// Type: NodeConfiguration
            /// Update requires: No interruption
            /// </summary>
			public NodeConfiguration NodeConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::ManagedBlockchain::Node";

        public NodeProperties Properties { get; } = new NodeProperties();

    }

	public static class NodeAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MemberId = new ResourceAttribute<Union<string, IntrinsicFunction>>("MemberId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NodeId = new ResourceAttribute<Union<string, IntrinsicFunction>>("NodeId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkId = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkId");
	}
}
