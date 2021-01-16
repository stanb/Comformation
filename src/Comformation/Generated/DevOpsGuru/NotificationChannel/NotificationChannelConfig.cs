using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DevOpsGuru.NotificationChannel
{
    /// <summary>
    /// AWS::DevOpsGuru::NotificationChannel NotificationChannelConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationchannelconfig.html
    /// </summary>
    public class NotificationChannelConfig
    {

        /// <summary>
        /// Sns
        /// 		
        /// 			Information about a notification channel configured in DevOps Guru to send notifications when
        /// insights are created. 		
        /// 		 		
        /// If you use an Amazon SNS topic in another account, you must attach a policy to it that grants DevOps
        /// Guru permission 				to it notifications. DevOps Guru adds the required policy on your behalf to send
        /// notifications using Amazon SNS in your account. 				For more information, see Permissions 				for
        /// cross account Amazon SNS topics.
        /// 				
        /// If you use an Amazon SNS topic that is encrypted by an AWS Key Management Service customer-managed
        /// key (CMK), then you must add permissions 				to the CMK. For more information, see Permissions for
        /// 				AWS KMS–encrypted Amazon SNS topics.
        /// 	
        /// Required: No
        /// Type: SnsChannelConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Sns")]
        public SnsChannelConfig Sns { get; set; }

    }
}
