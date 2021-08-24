using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayMulticastGroupSource
{
    /// <summary>
    /// AWS::EC2::TransitGatewayMulticastGroupSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupsource.html
    /// </summary>
    public class TransitGatewayMulticastGroupSourceResource : ResourceBase
    {
        public class TransitGatewayMulticastGroupSourceProperties
        {
            /// <summary>
            /// GroupIpAddress
            /// The IP address assigned to the transit gateway multicast group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GroupIpAddress { get; set; }

            /// <summary>
            /// TransitGatewayMulticastDomainId
            /// The ID of the transit gateway multicast domain.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayMulticastDomainId { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// The group sources&#39; network interface IDs to register with the transit gateway multicast group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayMulticastGroupSource";

        public TransitGatewayMulticastGroupSourceProperties Properties { get; } = new TransitGatewayMulticastGroupSourceProperties();

    }

    public static class TransitGatewayMulticastGroupSourceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TransitGatewayAttachmentId = new ResourceAttribute<Union<string, IntrinsicFunction>>("TransitGatewayAttachmentId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SubnetId = new ResourceAttribute<Union<string, IntrinsicFunction>>("SubnetId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceType = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceType");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> GroupMember = new ResourceAttribute<Union<bool, IntrinsicFunction>>("GroupMember");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> GroupSource = new ResourceAttribute<Union<bool, IntrinsicFunction>>("GroupSource");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MemberType = new ResourceAttribute<Union<string, IntrinsicFunction>>("MemberType");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SourceType = new ResourceAttribute<Union<string, IntrinsicFunction>>("SourceType");
    }
}
