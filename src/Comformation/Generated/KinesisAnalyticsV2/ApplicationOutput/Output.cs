using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationOutput Output
    /// Describes an SQL-based Amazon Kinesis Data Analytics application&#39;s output configuration, in which you identify
    /// an in-application stream and a destination where you want the in-application stream data to be written. The
    /// destination can be a Kinesis data stream or a Kinesis Data Firehose delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-output.html
    /// </summary>
    public class Output
    {

        /// <summary>
        /// DestinationSchema
        /// Describes the data format when records are written to the destination.
        /// Required: Yes
        /// Type: DestinationSchema
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationSchema")]
        public DestinationSchema DestinationSchema { get; set; }

        /// <summary>
        /// LambdaOutput
        /// Identifies an AWS Lambda function as the destination.
        /// Required: No
        /// Type: LambdaOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaOutput")]
        public LambdaOutput LambdaOutput { get; set; }

        /// <summary>
        /// KinesisFirehoseOutput
        /// Identifies an Amazon Kinesis Data Firehose delivery stream as the destination.
        /// Required: No
        /// Type: KinesisFirehoseOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseOutput")]
        public KinesisFirehoseOutput KinesisFirehoseOutput { get; set; }

        /// <summary>
        /// KinesisStreamsOutput
        /// Identifies an Amazon Kinesis data stream as the destination.
        /// Required: No
        /// Type: KinesisStreamsOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamsOutput")]
        public KinesisStreamsOutput KinesisStreamsOutput { get; set; }

        /// <summary>
        /// Name
        /// The name of the in-application stream.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 32
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
