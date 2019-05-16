using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.RouteTable
{
    /// <summary>
    /// AWS::EC2::RouteTable
    /// Specifies a route table for a specified VPC. After you create a route table, you can add routes and associate
    /// the table with a subnet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route-table.html
    /// </summary>
    public class RouteTableResource : ResourceBase
    {
        public class RouteTableProperties
        {
            /// <summary>
            /// Tags
            /// 	
            /// Any tags assigned to the route table.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// 	
            /// The ID of the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::RouteTable";

        public RouteTableProperties Properties { get; } = new RouteTableProperties();

    }
}
