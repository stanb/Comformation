using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application KinesisStreamsInput
    /// Identifies an Amazon Kinesis data stream as the streaming source. You provide the stream&#39;s Amazon Resource
    /// Name (ARN).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-kinesisstreamsinput.html
    /// </summary>
    public class KinesisStreamsInput
    {

        /// <summary>
        /// ResourceARN
        /// The ARN of the input Kinesis data stream to read.
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
