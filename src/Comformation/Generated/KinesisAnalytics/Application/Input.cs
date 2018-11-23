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
        /// Type: InputSchema
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputSchema")]
        public InputSchema InputSchema { get; set; }

        /// <summary>
        /// KinesisStreamsInput
        /// If the streaming source is an Amazon Kinesis stream, identifies the stream&#39;s ARN and an IAM role
        /// that enables Kinesis Data Analytics to access the stream on your behalf.
        /// Required: No
        /// Type: KinesisStreamsInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamsInput")]
        public KinesisStreamsInput KinesisStreamsInput { get; set; }

        /// <summary>
        /// KinesisFirehoseInput
        /// If the streaming source is an Amazon Kinesis Data Firehose delivery stream, identifies the delivery
        /// stream&#39;s Amazon Resource Name (ARN) and an IAM role that enables Kinesis Data Analytics to access
        /// the stream on your behalf.
        /// Required: No
        /// Type: KinesisFirehoseInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseInput")]
        public KinesisFirehoseInput KinesisFirehoseInput { get; set; }

        /// <summary>
        /// InputProcessingConfiguration
        /// The input processing configuration for the input. An input processor transforms records as they are
        /// received from the stream, before the application&#39;s SQL code executes. Currently, the only input
        /// processing configuration available is InputLambdaProcessor.
        /// Required: No
        /// Type: InputProcessingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputProcessingConfiguration")]
        public InputProcessingConfiguration InputProcessingConfiguration { get; set; }

        /// <summary>
        /// InputParallelism
        /// Describes the number of in-application streams to create.
        /// Required: No
        /// Type: InputParallelism
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputParallelism")]
        public InputParallelism InputParallelism { get; set; }

    }
}
