using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// AWS::KinesisAnalytics::Application KinesisFirehoseInput
    /// Identifies an Amazon Kinesis Firehose delivery stream as the streaming source. You provide the delivery
    /// stream&#39;s Amazon Resource Name (ARN) and an IAM role ARN that enables Amazon Kinesis Analytics to access the
    /// stream on your behalf.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-kinesisfirehoseinput.html
    /// </summary>
    public class KinesisFirehoseInput
    {

        /// <summary>
        /// ResourceARN
        /// ARN of the input delivery stream.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

        /// <summary>
        /// RoleARN
        /// ARN of the IAM role that Amazon Kinesis Analytics can assume to access the stream on your behalf.
        /// You need to make sure that the role has the necessary permissions to access the stream.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:aws:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
