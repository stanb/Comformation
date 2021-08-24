using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html
    /// </summary>
    public class SpotFleetResource : ResourceBase
    {
        public class SpotFleetProperties
        {
            /// <summary>
            /// SpotFleetRequestConfigData
            /// Describes the configuration of a Spot Fleet request.
            /// Required: Yes
            /// Type: SpotFleetRequestConfigData
            /// Update requires: No interruption
            /// </summary>
            public SpotFleetRequestConfigData SpotFleetRequestConfigData { get; set; }

        }

        public string Type { get; } = "AWS::EC2::SpotFleet";

        public SpotFleetProperties Properties { get; } = new SpotFleetProperties();

    }

    public static class SpotFleetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
