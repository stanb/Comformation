using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application Input
    /// The Input property type specifies a SQL application&#39;s streaming source, the in-application stream name that is
    /// created, and the mapping between the two.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-input.html
    /// </summary>
    public class Input
    {

        /// <summary>
        /// NamePrefix
        /// The name prefix to use when creating an in-application stream. Suppose that you specify a prefix
        /// &quot;MyInApplicationStream. &quot; Kinesis Data Analytics then creates one or more (as per the
        /// InputParallelism count you specified) in-application streams with the names
        /// &quot;MyInApplicationStream_001,&quot; &quot;MyInApplicationStream_002,&quot; and so on.
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
        /// If the streaming source is an Amazon Kinesis data stream, identifies the stream&#39;s Amazon Resource
        /// Name (ARN).
        /// Required: No
        /// Type: KinesisStreamsInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamsInput")]
        public KinesisStreamsInput KinesisStreamsInput { get; set; }

        /// <summary>
        /// KinesisFirehoseInput
        /// If the streaming source is an Amazon Kinesis Data Firehose delivery stream, identifies the delivery
        /// stream&#39;s ARN.
        /// Required: No
        /// Type: KinesisFirehoseInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseInput")]
        public KinesisFirehoseInput KinesisFirehoseInput { get; set; }

        /// <summary>
        /// InputProcessingConfiguration
        /// The InputProcessingConfiguration for the input. An input processor transforms records as they are
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
