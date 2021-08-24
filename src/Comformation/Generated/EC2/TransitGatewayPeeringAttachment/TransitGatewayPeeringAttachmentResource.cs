using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayPeeringAttachment
{
    /// <summary>
    /// AWS::EC2::TransitGatewayPeeringAttachment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html
    /// </summary>
    public class TransitGatewayPeeringAttachmentResource : ResourceBase
    {
        public class TransitGatewayPeeringAttachmentProperties
        {
            /// <summary>
            /// TransitGatewayId
            /// The ID of the transit gateway peering attachment.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayId { get; set; }

            /// <summary>
            /// PeerTransitGatewayId
            /// The ID of the transit gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PeerTransitGatewayId { get; set; }

            /// <summary>
            /// PeerAccountId
            /// The ID of the AWS account that owns the transit gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PeerAccountId { get; set; }

            /// <summary>
            /// PeerRegion
            /// The Region of the transit gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PeerRegion { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the transit gateway peering attachment.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayPeeringAttachment";

        public TransitGatewayPeeringAttachmentProperties Properties { get; } = new TransitGatewayPeeringAttachmentProperties();

    }

    public static class TransitGatewayPeeringAttachmentAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TransitGatewayAttachmentId = new ResourceAttribute<Union<string, IntrinsicFunction>>("TransitGatewayAttachmentId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
