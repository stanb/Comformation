using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ResponsePlan
{
    /// <summary>
    /// AWS::SSMIncidents::ResponsePlan NotificationTargetItem
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-notificationtargetitem.html
    /// </summary>
    public class NotificationTargetItem
    {

        /// <summary>
        /// SnsTopicArn
        /// The Amazon Resource Name (ARN) of the SNS topic.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1000
        /// Pattern: ^arn:aws(-cn|-us-gov)?:[a-z0-9-]*:[a-z0-9-]*:([0-9]{12})?:. +$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnsTopicArn")]
        public Union<string, IntrinsicFunction> SnsTopicArn { get; set; }

    }
}
