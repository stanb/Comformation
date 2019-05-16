using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application KinesisFirehoseInput
    /// For an SQL-based Amazon Kinesis Data Analytics application, identifies a Kinesis Data Firehose delivery stream
    /// as the streaming source. You provide the delivery stream&#39;s Amazon Resource Name (ARN).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-kinesisfirehoseinput.html
    /// </summary>
    public class KinesisFirehoseInput
    {

        /// <summary>
        /// ResourceARN
        /// The Amazon Resource Name (ARN) of the delivery stream.
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
