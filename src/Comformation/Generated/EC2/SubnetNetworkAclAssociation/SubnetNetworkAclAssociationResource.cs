using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetNetworkAclAssociation
{
    /// <summary>
    /// AWS::EC2::SubnetNetworkAclAssociation
    /// Associates a subnet with a network ACL. For more information, see ReplaceNetworkAclAssociation in the Amazon
    /// Elastic Compute Cloud API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html
    /// </summary>
    public class SubnetNetworkAclAssociationResource : ResourceBase
    {
        public class SubnetNetworkAclAssociationProperties
        {
            /// <summary>
            /// NetworkAclId
            /// 		
            /// The ID of the network ACL.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkAclId { get; set; }

            /// <summary>
            /// SubnetId
            /// 		
            /// The ID of the subnet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::SubnetNetworkAclAssociation";

        public SubnetNetworkAclAssociationProperties Properties { get; } = new SubnetNetworkAclAssociationProperties();

    }

	public static class SubnetNetworkAclAssociationAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssociationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssociationId");
	}
}
