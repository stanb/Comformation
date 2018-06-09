using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application Input
    /// When you configure the application input, you specify the streaming source, the in-application stream name
    /// that is created, and the mapping between the two.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html
    /// </summary>
    public class Input
    {

        /// <summary>
        /// NamePrefix
        /// The name prefix to use when creating the in-application streams.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NamePrefix")]
        public Union<string, IntrinsicFunction> NamePrefix { get; set; }

        /// <summary>
        /// InputSchema
        /// Describes the format of the data in the streaming source, and how each data element maps to
        /// corresponding columns in the in-application stream that is being created.
        /// Required: Yes
        /// Type: Kinesis Data Analytics Application InputSchema
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputSchema")]
        public Union<InputSchema, IntrinsicFunction> InputSchema { get; set; }

        /// <summary>
        /// KinesisStreamsInput
        /// If the streaming source is an Amazon Kinesis stream, identifies the stream&#39;s ARN and an IAM role
        /// that enables Kinesis Data Analytics to access the stream on your behalf.
        /// Required: No
        /// Type: Kinesis Data Analytics Application KinesisStreamsInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamsInput")]
        public Union<KinesisStreamsInput, IntrinsicFunction> KinesisStreamsInput { get; set; }

        /// <summary>
        /// KinesisFirehoseInput
        /// If the streaming source is an Amazon Kinesis Firehose delivery stream, identifies the delivery
        /// stream&#39;s Amazon Resource Name (ARN) and an IAM role that enables Kinesis Data Analytics to access
        /// the stream on your behalf.
        /// Required: No
        /// Type: Kinesis Data Analytics Application KinesisFirehoseInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseInput")]
        public Union<KinesisFirehoseInput, IntrinsicFunction> KinesisFirehoseInput { get; set; }

        /// <summary>
        /// InputProcessingConfiguration
        /// The input processing configuration for the input. An input processor transforms records as they are
        /// received from the stream, before the application&#39;s SQL code executes. Currently, the only input
        /// processing configuration available is InputLambdaProcessor.
        /// Required: No
        /// Type: Kinesis Data Analytics Application InputProcessingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputProcessingConfiguration")]
        public Union<InputProcessingConfiguration, IntrinsicFunction> InputProcessingConfiguration { get; set; }

        /// <summary>
        /// InputParallelism
        /// Describes the number of in-application streams to create.
        /// Required: No
        /// Type: Kinesis Data Analytics Application InputParallelism
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputParallelism")]
        public Union<InputParallelism, IntrinsicFunction> InputParallelism { get; set; }

    }
}
