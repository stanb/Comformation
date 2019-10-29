using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TrafficMirrorSession
{
    /// <summary>
    /// AWS::EC2::TrafficMirrorSession
    /// Creates a Traffic Mirror session.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html
    /// </summary>
    public class TrafficMirrorSessionResource : ResourceBase
    {
        public class TrafficMirrorSessionProperties
        {
            /// <summary>
            /// TrafficMirrorTargetId
            /// The ID of the Traffic Mirror target.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TrafficMirrorTargetId { get; set; }

            /// <summary>
            /// Description
            /// The description of the Traffic Mirror session.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SessionNumber
            /// The session number determines the order in which sessions are evaluated when an interface is used by
            /// multiple sessions. The first session with a matching filter is the one that mirrors the packets.
            /// Valid values are 1-32766.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> SessionNumber { get; set; }

            /// <summary>
            /// VirtualNetworkId
            /// The VXLAN ID for the Traffic Mirror session. For more information about the VXLAN protocol, see RFC
            /// 7348. If you do not specify a VirtualNetworkId, an account-wide unique id is chosen at random.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> VirtualNetworkId { get; set; }

            /// <summary>
            /// PacketLength
            /// The number of bytes in each packet to mirror. These are bytes after the VXLAN header. Do not specify
            /// this parameter when you want to mirror the entire packet. To mirror a subset of the packet, set this
            /// to the length (in bytes) that you want to mirror. For example, if you set this value to 100, then
            /// the first 100 bytes that meet the filter criteria are copied to the target.
            /// If you do not want to mirror the entire packet, use the PacketLength parameter to specify the number
            /// of bytes in each packet to mirror.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> PacketLength { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// The ID of the source network interface.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            /// TrafficMirrorFilterId
            /// The ID of the Traffic Mirror filter.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TrafficMirrorFilterId { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to a Traffic Mirror session.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TrafficMirrorSession";

        public TrafficMirrorSessionProperties Properties { get; } = new TrafficMirrorSessionProperties();

    }
}
