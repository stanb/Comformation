using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCPeeringConnection
{
    /// <summary>
    /// AWS::EC2::VPCPeeringConnection
    /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and 			an accepter VPC with
    /// which to create the connection. The accepter VPC can belong to 			another AWS account and can be in a
    /// different Region to the requester VPC. The requester 			VPC and accepter VPC cannot have overlapping CIDR
    /// blocks.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html
    /// </summary>
    public class VPCPeeringConnectionResource : ResourceBase
    {
        public class VPCPeeringConnectionProperties
        {
            /// <summary>
            /// PeerOwnerId
            /// The AWS account ID of the owner of the accepter VPC.
            /// Default: Your AWS account ID
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PeerOwnerId { get; set; }

            /// <summary>
            /// PeerRegion
            /// The Region code for the accepter VPC, if the accepter VPC is located in a Region other than the
            /// Region in which you make the request.
            /// 		
            /// Default: The Region in which you make the request.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PeerRegion { get; set; }

            /// <summary>
            /// PeerRoleArn
            /// The Amazon Resource Name (ARN) of the VPC peer role for the peering connection in another AWS
            /// account.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PeerRoleArn { get; set; }

            /// <summary>
            /// PeerVpcId
            /// The ID of the VPC with which you are creating the VPC peering connection. You must 			specify this
            /// parameter in the request.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PeerVpcId { get; set; }

            /// <summary>
            /// Tags
            /// Any tags assigned to the resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPCPeeringConnection";

        public VPCPeeringConnectionProperties Properties { get; } = new VPCPeeringConnectionProperties();

    }
}
