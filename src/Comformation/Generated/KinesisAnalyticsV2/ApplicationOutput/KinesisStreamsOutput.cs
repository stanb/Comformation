using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationOutput KinesisStreamsOutput
    /// When you configure an SQL-based Amazon Kinesis Data Analytics application&#39;s output, identifies a Kinesis data
    /// stream as the destination. You provide the stream Amazon Resource Name (ARN).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-kinesisstreamsoutput.html
    /// </summary>
    public class KinesisStreamsOutput
    {

        /// <summary>
        /// ResourceARN
        /// The ARN of the destination Kinesis data stream to write to.
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
