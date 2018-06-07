using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.RouteTable
{
    /// <summary>
    /// AWS::EC2::RouteTable
    /// Creates a new route table within a VPC. After you create a new route table, you can add routes and associate
    /// the table with a subnet.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route-table.html
    /// </summary>
    public class RouteTableResource : ResourceBase
    {
        public class RouteTableProperties
        {
            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this route table.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route-table.html#cfn-ec2-routetable-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC where the route table will be created.
            /// Example: vpc-11ad4878
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route-table.html#cfn-ec2-routetable-vpcid
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::RouteTable";
        
        public RouteTableProperties Properties { get; } = new RouteTableProperties();
    }
}
