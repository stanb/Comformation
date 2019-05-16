using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationCloudWatchLoggingOption CloudWatchLoggingOption
    /// Provides a description of Amazon CloudWatch logging options, including the log stream Amazon Resource Name
    /// (ARN).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationcloudwatchloggingoption-cloudwatchloggingoption.html
    /// </summary>
    public class CloudWatchLoggingOption
    {

        /// <summary>
        /// LogStreamARN
        /// The ARN of the CloudWatch log to receive application messages.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogStreamARN")]
        public Union<string, IntrinsicFunction> LogStreamARN { get; set; }

    }
}
