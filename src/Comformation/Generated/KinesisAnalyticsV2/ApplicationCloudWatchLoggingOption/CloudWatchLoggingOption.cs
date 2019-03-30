using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationCloudWatchLoggingOption CloudWatchLoggingOption
    /// The CloudWatchLoggingOption property type specifies an Amazon CloudWatch log stream to monitor application
    /// configuration errors.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationcloudwatchloggingoption-cloudwatchloggingoption.html
    /// </summary>
    public class CloudWatchLoggingOption
    {

        /// <summary>
        /// LogStreamARN
        /// The ARN of the CloudWatch log to receive application messages.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogStreamARN")]
        public Union<string, IntrinsicFunction> LogStreamARN { get; set; }

    }
}
