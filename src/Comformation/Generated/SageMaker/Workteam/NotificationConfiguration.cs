using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Workteam
{
    /// <summary>
    /// AWS::SageMaker::Workteam NotificationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-notificationconfiguration.html
    /// </summary>
    public class NotificationConfiguration
    {

        /// <summary>
        /// NotificationTopicArn
        /// The ARN for the SNS topic to which notifications should be published.
        /// Required: Yes
        /// Type: String
        /// Pattern: arn:aws[a-z\-]*:sns:[a-z0-9\-]*:[0-9]{12}:[a-zA-Z0-9_. -]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationTopicArn")]
        public Union<string, IntrinsicFunction> NotificationTopicArn { get; set; }

    }
}
