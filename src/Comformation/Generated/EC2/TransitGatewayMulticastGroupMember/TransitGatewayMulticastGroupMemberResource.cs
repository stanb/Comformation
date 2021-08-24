using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayMulticastGroupMember
{
    /// <summary>
    /// AWS::EC2::TransitGatewayMulticastGroupMember
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupmember.html
    /// </summary>
    public class TransitGatewayMulticastGroupMemberResource : ResourceBase
    {
        public class TransitGatewayMulticastGroupMemberProperties
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
            /// The group members&#39; network interface IDs to register with the transit gateway multicast group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayMulticastGroupMember";

        public TransitGatewayMulticastGroupMemberProperties Properties { get; } = new TransitGatewayMulticastGroupMemberProperties();

    }

    public static class TransitGatewayMulticastGroupMemberAttributes
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
