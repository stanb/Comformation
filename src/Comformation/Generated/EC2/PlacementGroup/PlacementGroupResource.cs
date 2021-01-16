using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.PlacementGroup
{
    /// <summary>
    /// AWS::EC2::PlacementGroup
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
            /// Allowed values: cluster | partition | spread
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Strategy { get; set; }

        }

        public string Type { get; } = "AWS::EC2::PlacementGroup";

        public PlacementGroupProperties Properties { get; } = new PlacementGroupProperties();

    }
}
