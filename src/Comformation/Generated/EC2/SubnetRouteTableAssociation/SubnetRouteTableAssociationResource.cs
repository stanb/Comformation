using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetRouteTableAssociation
{
    /// <summary>
    /// AWS::EC2::SubnetRouteTableAssociation
    /// Associates a subnet with a route table.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html
    /// </summary>
    public class SubnetRouteTableAssociationResource : ResourceBase
    {
        public class SubnetRouteTableAssociationProperties
        {
            /// <summary>
            /// RouteTableId
            /// The ID of the route table. This is commonly written as a reference to a route table declared
            /// elsewhere in the template. For example:
            /// "RouteTableId" : { "Ref" : "myRouteTable" }
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption. However, the physical ID changes when the route table ID is
            /// changed.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html#cfn-ec2-subnetroutetableassociation-routetableid
            /// </summary>
			public Union<string, IntrinsicFunction> RouteTableId { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet. This is commonly written as a reference to a subnet declared elsewhere in the
            /// template. For example:
            /// "SubnetId" : { "Ref" : "mySubnet" }
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html#cfn-ec2-subnetroutetableassociation-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SubnetRouteTableAssociation";
        
        public SubnetRouteTableAssociationProperties Properties { get; } = new SubnetRouteTableAssociationProperties();
    }
}
