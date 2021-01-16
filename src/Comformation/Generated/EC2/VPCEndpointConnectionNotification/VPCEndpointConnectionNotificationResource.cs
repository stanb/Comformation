using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCEndpointConnectionNotification
{
    /// <summary>
    /// AWS::EC2::VPCEndpointConnectionNotification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointconnectionnotification.html
    /// </summary>
    public class VPCEndpointConnectionNotificationResource : ResourceBase
    {
        public class VPCEndpointConnectionNotificationProperties
        {
            /// <summary>
            /// ConnectionEvents
            /// One or more endpoint events for which to receive notifications. Valid values are Accept, Connect,
            /// Delete, and Reject.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ConnectionEvents { get; set; }

            /// <summary>
            /// VPCEndpointId
            /// The ID of the endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VPCEndpointId { get; set; }

            /// <summary>
            /// ServiceId
            /// The ID of the endpoint service.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceId { get; set; }

            /// <summary>
            /// ConnectionNotificationArn
            /// The ARN of the SNS topic for the notifications.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionNotificationArn { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPCEndpointConnectionNotification";

        public VPCEndpointConnectionNotificationProperties Properties { get; } = new VPCEndpointConnectionNotificationProperties();

    }
}
