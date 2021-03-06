using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetRouteTableAssociation
{
    /// <summary>
    /// AWS::EC2::SubnetRouteTableAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html
    /// </summary>
    public class SubnetRouteTableAssociationResource : ResourceBase
    {
        public class SubnetRouteTableAssociationProperties
        {
            /// <summary>
            /// RouteTableId
            /// 		
            /// The ID of the route table.
            /// The physical ID changes when the route table ID is changed.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RouteTableId { get; set; }

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

        public string Type { get; } = "AWS::EC2::SubnetRouteTableAssociation";

        public SubnetRouteTableAssociationProperties Properties { get; } = new SubnetRouteTableAssociationProperties();

    }
}
