using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetNetworkAclAssociation
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html
    /// </summary>
    public class SubnetNetworkAclAssociationResource : ResourceBase
    {
        public class SubnetNetworkAclAssociationProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html#cfn-ec2-subnetnetworkaclassociation-networkaclid
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkAclId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html#cfn-ec2-subnetnetworkaclassociation-associationid
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
