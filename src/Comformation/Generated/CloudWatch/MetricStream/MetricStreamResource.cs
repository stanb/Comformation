using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.MetricStream
{
    /// <summary>
    /// AWS::CloudWatch::MetricStream
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html
    /// </summary>
    public class MetricStreamResource : ResourceBase
    {
        public class MetricStreamProperties
        {
            /// <summary>
            /// ExcludeFilters
            /// If you specify this parameter, the stream sends metrics from all metric namespaces except for the
            /// namespaces that you specify here. You cannot specify both IncludeFilters and ExcludeFilters in the
            /// same metric stream.
            /// When you modify the IncludeFilters or ExcludeFilters of an existing metric stream in any way, the
            /// metric stream is effectively restarted, so after such a change you will get only the datapoints that
            /// have a timestamp after the time of the update.
            /// Required: No
            /// Type: List of MetricStreamFilter
            /// Update requires: No interruption
            /// </summary>
            public List<MetricStreamFilter> ExcludeFilters { get; set; }

            /// <summary>
            /// FirehoseArn
            /// The ARN of the Amazon Kinesis Firehose delivery stream to use for this metric stream. This Amazon
            /// Kinesis Firehose delivery stream must already exist and must be in the same account as the metric
            /// stream.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FirehoseArn { get; set; }

            /// <summary>
            /// IncludeFilters
            /// If you specify this parameter, the stream sends only the metrics from the metric namespaces that you
            /// specify here. You cannot specify both IncludeFilters and ExcludeFilters in the same metric stream.
            /// When you modify the IncludeFilters or ExcludeFilters of an existing metric stream in any way, the
            /// metric stream is effectively restarted, so after such a change you will get only the datapoints that
            /// have a timestamp after the time of the update.
            /// Required: No
            /// Type: List of MetricStreamFilter
            /// Update requires: No interruption
            /// </summary>
            public List<MetricStreamFilter> IncludeFilters { get; set; }

            /// <summary>
            /// Name
            /// If you are creating a new metric stream, this is the name for the new stream. The name must be
            /// different than the names of other metric streams in this account and Region.
            /// If you are updating a metric stream, specify the name of that stream here.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of an IAM role that this metric stream will use to access Amazon Kinesis Firehose resources.
            /// This IAM role must already exist and must be in the same account as the metric stream. This IAM role
            /// must include the firehose:PutRecord and firehose:PutRecordBatch permissions.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// OutputFormat
            /// The output format for the stream. Valid values are json and opentelemetry0. 7 For more information
            /// about metric stream output formats, see Metric streams output formats.
            /// This parameter is required.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> OutputFormat { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to the metric stream.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CloudWatch::MetricStream";

        public MetricStreamProperties Properties { get; } = new MetricStreamProperties();

    }

    public static class MetricStreamAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationDate");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdateDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdateDate");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
    }
}
