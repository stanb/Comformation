using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCPeeringConnection
{
    /// <summary>
    /// AWS::EC2::VPCPeeringConnection
    /// A VPC peering connection enables a network connection between two virtual private clouds (VPCs) so that you
    /// can route traffic between them using a private IP address. For more information about VPC peering and its
    /// limitations, see VPC Peering Overview in the Amazon VPC Peering Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html
    /// </summary>
    public class VPCPeeringConnectionResource : ResourceBase
    {
        public class VPCPeeringConnectionProperties
        {
            /// <summary>
            /// PeerOwnerId
            /// The AWS account ID of the owner of the VPC that you want to peer with.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PeerOwnerId { get; set; }

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
            /// The ID of the VPC with which you are creating the peering connection.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PeerVpcId { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this resource.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC that is requesting a peering connection.
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
