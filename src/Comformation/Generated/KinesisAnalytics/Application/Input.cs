using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// AWS::KinesisAnalytics::Application Input
    /// When you configure the application input, you specify the streaming source, the in-application stream name
    /// that is created, and the mapping between the two. For more information, see Configuring Application Input.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html
    /// </summary>
    public class Input
    {

        /// <summary>
        /// NamePrefix
        /// Name prefix to use when creating an in-application stream. Suppose that you specify a prefix
        /// &quot;MyInApplicationStream. &quot; Amazon Kinesis Analytics then creates one or more (as per the
        /// InputParallelism count you specified) in-application streams with names &quot;MyInApplicationStream_001,&quot;
        /// &quot;MyInApplicationStream_002,&quot; and so on.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 32
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NamePrefix")]
        public Union<string, IntrinsicFunction> NamePrefix { get; set; }

        /// <summary>
        /// InputSchema
        /// Describes the format of the data in the streaming source, and how each data element maps to
        /// corresponding columns in the in-application stream that is being created.
        /// Also used to describe the format of the reference data source.
        /// Required: Yes
        /// Type: InputSchema
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputSchema")]
        public InputSchema InputSchema { get; set; }

        /// <summary>
        /// KinesisStreamsInput
        /// If the streaming source is an Amazon Kinesis stream, identifies the stream&#39;s Amazon Resource Name
        /// (ARN) and an IAM role that enables Amazon Kinesis Analytics to access the stream on your behalf.
        /// Note: Either KinesisStreamsInput or KinesisFirehoseInput is required.
        /// Required: Conditional
        /// Type: KinesisStreamsInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamsInput")]
        public KinesisStreamsInput KinesisStreamsInput { get; set; }

        /// <summary>
        /// KinesisFirehoseInput
        /// If the streaming source is an Amazon Kinesis Firehose delivery stream, identifies the delivery
        /// stream&#39;s ARN and an IAM role that enables Amazon Kinesis Analytics to access the stream on your
        /// behalf.
        /// Note: Either KinesisStreamsInput or KinesisFirehoseInput is required.
        /// Required: Conditional
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
        /// Data from your source is routed to these in-application input streams.
        /// See Configuring Application Input.
        /// Required: No
        /// Type: InputParallelism
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputParallelism")]
        public InputParallelism InputParallelism { get; set; }

    }
}
