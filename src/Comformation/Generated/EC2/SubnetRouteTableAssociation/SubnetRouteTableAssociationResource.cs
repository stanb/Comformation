using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SubnetRouteTableAssociation
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html
    /// </summary>
    public class SubnetRouteTableAssociationResource : ResourceBase
    {
        public class SubnetRouteTableAssociationProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html#cfn-ec2-subnetroutetableassociation-routetableid
            /// </summary>
			public Union<string, IntrinsicFunction> RouteTableId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-route-table-assoc.html#cfn-ec2-subnetroutetableassociation-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SubnetRouteTableAssociation";
        
        public SubnetRouteTableAssociationProperties Properties { get; } = new SubnetRouteTableAssociationProperties();
    }
}
