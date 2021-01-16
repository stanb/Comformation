using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DevOpsGuru.NotificationChannel
{
    /// <summary>
    /// AWS::DevOpsGuru::NotificationChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsguru-notificationchannel.html
    /// </summary>
    public class NotificationChannelResource : ResourceBase
    {
        public class NotificationChannelProperties
        {
            /// <summary>
            /// Config
            /// 		
            /// 			A NotificationChannelConfig object that contains information about configured notification
            /// channels. 		
            /// 	
            /// Required: Yes
            /// Type: NotificationChannelConfig
            /// Update requires: Replacement
            /// </summary>
            public NotificationChannelConfig Config { get; set; }

        }

        public string Type { get; } = "AWS::DevOpsGuru::NotificationChannel";

        public NotificationChannelProperties Properties { get; } = new NotificationChannelProperties();

    }

    public static class NotificationChannelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
