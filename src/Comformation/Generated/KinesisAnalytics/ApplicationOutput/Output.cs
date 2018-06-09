using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationOutput Output
    /// The Output property type specifies an array of output configuration objects for an Amazon Kinesis Data
    /// Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-output.html
    /// </summary>
    public class Output
    {

        /// <summary>
        /// DestinationSchema
        /// The data format when records are written to the destination.
        /// Required: Yes
        /// Type: Kinesis Data Analytics ApplicationOutput DestinationSchema
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationSchema")]
        public Union<DestinationSchema, IntrinsicFunction> DestinationSchema { get; set; }

        /// <summary>
        /// LambdaOutput
        /// Identifies a Lambda function as the destination.
        /// Required: Conditional.
        /// Type: Kinesis Data Analytics ApplicationOutput LambdaOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaOutput")]
        public Union<LambdaOutput, IntrinsicFunction> LambdaOutput { get; set; }

        /// <summary>
        /// KinesisFirehoseOutput
        /// Identifies an Amazon Kinesis Data Firehose delivery stream as the destination.
        /// Required: Conditional.
        /// Type: Kinesis Data Analytics ApplicationOutput KinesisFirehoseOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseOutput")]
        public Union<KinesisFirehoseOutput, IntrinsicFunction> KinesisFirehoseOutput { get; set; }

        /// <summary>
        /// KinesisStreamsOutput
        /// Identifies an Amazon Kinesis stream as the destination.
        /// Required: Conditional.
        /// Type: Kinesis Data Analytics ApplicationOutput KinesisStreamsOutput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamsOutput")]
        public Union<KinesisStreamsOutput, IntrinsicFunction> KinesisStreamsOutput { get; set; }

        /// <summary>
        /// Name
        /// The name of the in-application stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
