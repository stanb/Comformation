using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationOutput KinesisFirehoseOutput
    /// When configuring application output, identifies an Amazon Kinesis Firehose delivery stream as the destination.
    /// You provide the stream Amazon Resource Name (ARN) and an IAM role that enables Amazon Kinesis Analytics to
    /// write to the stream on your behalf.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-kinesisfirehoseoutput.html
    /// </summary>
    public class KinesisFirehoseOutput
    {

        /// <summary>
        /// ResourceARN
        /// ARN of the destination Amazon Kinesis Firehose delivery stream to write to.
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
        /// ARN of the IAM role that Amazon Kinesis Analytics can assume to write to the destination stream on
        /// your behalf. You need to grant the necessary permissions to this role.
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
