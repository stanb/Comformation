using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FMS.NotificationChannel
{
    /// <summary>
    /// AWS::FMS::NotificationChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-notificationchannel.html
    /// </summary>
    public class NotificationChannelResource : ResourceBase
    {
        public class NotificationChannelProperties
        {
            /// <summary>
            /// SnsRoleName
            /// The Amazon Resource Name (ARN) of the IAM role that allows Amazon SNS to record AWS Firewall Manager
            /// activity.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SnsRoleName { get; set; }

            /// <summary>
            /// SnsTopicArn
            /// The Amazon Resource Name (ARN) of the SNS topic that collects notifications from AWS Firewall
            /// Manager.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SnsTopicArn { get; set; }

        }

        public string Type { get; } = "AWS::FMS::NotificationChannel";

        public NotificationChannelProperties Properties { get; } = new NotificationChannelProperties();

    }
}
