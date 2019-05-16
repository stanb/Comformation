using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationOutput KinesisFirehoseOutput
    /// For an SQL-based Amazon Kinesis Data Analytics application, when configuring application output, identifies a
    /// Kinesis Data Firehose delivery stream as the destination. You provide the stream Amazon Resource Name (ARN) of
    /// the delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-kinesisfirehoseoutput.html
    /// </summary>
    public class KinesisFirehoseOutput
    {

        /// <summary>
        /// ResourceARN
        /// The ARN of the destination delivery stream to write to.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

    }
}
