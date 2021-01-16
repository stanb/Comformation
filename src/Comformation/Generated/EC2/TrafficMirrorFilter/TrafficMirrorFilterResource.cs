using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TrafficMirrorFilter
{
    /// <summary>
    /// AWS::EC2::TrafficMirrorFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilter.html
    /// </summary>
    public class TrafficMirrorFilterResource : ResourceBase
    {
        public class TrafficMirrorFilterProperties
        {
            /// <summary>
            /// Description
            /// The description of the Traffic Mirror filter.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// NetworkServices
            /// The network service traffic that is associated with the Traffic Mirror filter.
            /// Valid values are amazon-dns.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> NetworkServices { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to a Traffic Mirror filter.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TrafficMirrorFilter";

        public TrafficMirrorFilterProperties Properties { get; } = new TrafficMirrorFilterProperties();

    }
}
