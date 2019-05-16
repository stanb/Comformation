using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.PlacementGroup
{
    /// <summary>
    /// AWS::EC2::PlacementGroup
    /// Specifies a placement group in which to launch instances. The strategy of the placement group determines how
    /// the instances are organized within the group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-placementgroup.html
    /// </summary>
    public class PlacementGroupResource : ResourceBase
    {
        public class PlacementGroupProperties
        {
            /// <summary>
            /// Strategy
            /// The placement strategy.
            /// Required: No
            /// Type: String
            /// Allowed Values: cluster | partition | spread
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Strategy { get; set; }

        }

        public string Type { get; } = "AWS::EC2::PlacementGroup";

        public PlacementGroupProperties Properties { get; } = new PlacementGroupProperties();

    }
}
