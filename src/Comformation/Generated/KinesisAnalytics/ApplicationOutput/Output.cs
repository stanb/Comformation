using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationOutput Output
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-output.html
    /// </summary>
    public class Output
    {

        /// <summary>
        /// DestinationSchema
        /// Describes the data format when records are written to the destination. For more information, see
        /// Configuring Application Output.
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
        /// Identifies an Amazon Kinesis Firehose delivery stream as the destination.
        /// Required: No
        /// Type: KinesisFirehoseOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseOutput")]
        public KinesisFirehoseOutput KinesisFirehoseOutput { get; set; }

        /// <summary>
        /// KinesisStreamsOutput
        /// Identifies an Amazon Kinesis stream as the destination.
        /// Required: No
        /// Type: KinesisStreamsOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamsOutput")]
        public KinesisStreamsOutput KinesisStreamsOutput { get; set; }

        /// <summary>
        /// Name
        /// Name of the in-application stream.
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
