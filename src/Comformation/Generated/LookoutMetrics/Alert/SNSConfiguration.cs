using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.Alert
{
    /// <summary>
    /// AWS::LookoutMetrics::Alert SNSConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-snsconfiguration.html
    /// </summary>
    public class SNSConfiguration
    {

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that has access to the target SNS topic.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// SnsTopicArn
        /// The ARN of the target SNS topic.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SnsTopicArn")]
        public Union<string, IntrinsicFunction> SnsTopicArn { get; set; }

    }
}
