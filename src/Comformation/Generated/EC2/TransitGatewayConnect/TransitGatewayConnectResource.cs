using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayConnect
{
    /// <summary>
    /// AWS::EC2::TransitGatewayConnect
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayconnect.html
    /// </summary>
    public class TransitGatewayConnectResource : ResourceBase
    {
        public class TransitGatewayConnectProperties
        {
            /// <summary>
            /// TransportTransitGatewayAttachmentId
            /// The ID of the attachment from which the Connect attachment was created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransportTransitGatewayAttachmentId { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the attachment.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Options
            /// The Connect attachment options.
            /// protocol (gre)
            /// Required: Yes
            /// Type: TransitGatewayConnectOptions
            /// Update requires: Replacement
            /// </summary>
            public TransitGatewayConnectOptions Options { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayConnect";

        public TransitGatewayConnectProperties Properties { get; } = new TransitGatewayConnectProperties();

    }

    public static class TransitGatewayConnectAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TransitGatewayAttachmentId = new ResourceAttribute<Union<string, IntrinsicFunction>>("TransitGatewayAttachmentId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TransitGatewayId = new ResourceAttribute<Union<string, IntrinsicFunction>>("TransitGatewayId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
