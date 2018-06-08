using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetNetworkAclAssociation
{
    /// <summary>
    /// AWS::EC2::SubnetNetworkAclAssociation
    /// Associates a subnet with a network ACL. For more information, see ReplaceNetworkAclAssociation in the Amazon
    /// EC2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html
    /// </summary>
    public class SubnetNetworkAclAssociationResource : ResourceBase
    {
        public class SubnetNetworkAclAssociationProperties
        {
            /// <summary>
            /// NetworkAclId
            /// The ID of the new ACL to associate with the subnet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkAclId { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID representing the current association between the original network ACL and the subnet.
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
        public static readonly ResourceAttribute<string> AssociationId = new ResourceAttribute<string>("AssociationId");
	}
}
