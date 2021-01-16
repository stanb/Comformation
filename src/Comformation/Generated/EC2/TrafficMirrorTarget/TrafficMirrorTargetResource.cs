using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TrafficMirrorTarget
{
    /// <summary>
    /// AWS::EC2::TrafficMirrorTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html
    /// </summary>
    public class TrafficMirrorTargetResource : ResourceBase
    {
        public class TrafficMirrorTargetProperties
        {
            /// <summary>
            /// NetworkLoadBalancerArn
            /// The Amazon Resource Name (ARN) of the Network Load Balancer that is associated with the target.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkLoadBalancerArn { get; set; }

            /// <summary>
            /// Description
            /// The description of the Traffic Mirror target.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// The network interface ID that is associated with the target.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to the Traffic Mirror target.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TrafficMirrorTarget";

        public TrafficMirrorTargetProperties Properties { get; } = new TrafficMirrorTargetProperties();

    }
}
