using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.PlacementGroup
{
    /// <summary>
    /// AWS::EC2::PlacementGroup
    /// The AWS::EC2::PlacementGroup resource is a logical grouping of instances within a single Availability Zone
    /// (AZ) that enables applications to participate in a low-latency, 10 Gbps network. You create a placement group
    /// first, and then you can launch instances in the placement group.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-placementgroup.html
    /// </summary>
    public class PlacementGroupResource : ResourceBase
    {
        public class PlacementGroupProperties
        {
            /// <summary>
            /// Strategy
            /// The placement strategy, which relates to the instance types that can be added to the placement
            /// group. For example, for the cluster strategy, you can cluster C4 instance types but not T2 instance
            /// types. For valid values, see CreatePlacementGroup in the Amazon EC2 API Reference. By default, AWS
            /// CloudFormation sets the value of this property to cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-placementgroup.html#cfn-ec2-placementgroup-strategy
            /// </summary>
			public Union<string, IntrinsicFunction> Strategy { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::PlacementGroup";
        
        public PlacementGroupProperties Properties { get; } = new PlacementGroupProperties();
    }
}
