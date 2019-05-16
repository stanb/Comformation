using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet
    /// Specifies a Spot Fleet request. A Spot Fleet request contains the configuration information to launch a fleet,
    /// or group, of instances.
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
            /// </summary>
			public SpotFleetRequestConfigData SpotFleetRequestConfigData { get; set; }

        }

        public string Type { get; } = "AWS::EC2::SpotFleet";

        public SpotFleetProperties Properties { get; } = new SpotFleetProperties();

    }
}
