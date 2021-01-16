using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DevOpsGuru.NotificationChannel
{
    /// <summary>
    /// AWS::DevOpsGuru::NotificationChannel SnsChannelConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-snschannelconfig.html
    /// </summary>
    public class SnsChannelConfig
    {

        /// <summary>
        /// TopicArn
        /// 		
        /// The Amazon Resource Name (ARN) of an Amazon Simple Notification Service topic.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 36
        /// Maximum: 1024
        /// Pattern: ^arn:aws[a-z0-9-]*:sns:[a-z0-9-]+:\d{12}:[^:]+$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

    }
}
