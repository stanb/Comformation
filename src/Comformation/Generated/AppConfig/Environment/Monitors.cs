using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.Environment
{
    /// <summary>
    /// AWS::AppConfig::Environment Monitors
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-environment-monitors.html
    /// </summary>
    public class Monitors
    {

        /// <summary>
        /// AlarmArn
        /// ARN of the Amazon CloudWatch alarm.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmArn")]
        public Union<string, IntrinsicFunction> AlarmArn { get; set; }

        /// <summary>
        /// AlarmRoleArn
        /// ARN of an IAM role for AWS AppConfig to monitor AlarmArn.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: ^((arn):(aws|aws-cn|aws-iso|aws-iso-[a-z]{1}|aws-us-gov):(iam)::\d{12}:role[/]. *)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmRoleArn")]
        public Union<string, IntrinsicFunction> AlarmRoleArn { get; set; }

    }
}
