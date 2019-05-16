using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.MetricFilter
{
    /// <summary>
    /// AWS::Logs::MetricFilter
    /// The AWS::Logs::MetricFilter resource specifies a metric filter that describes how CloudWatch Logs extracts
    /// information from logs and transforms it into Amazon CloudWatch metrics. If you have multiple metric filters
    /// that are associated with a log group, all the filters are applied to the log streams in that group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html
    /// </summary>
    public class MetricFilterResource : ResourceBase
    {
        public class MetricFilterProperties
        {
            /// <summary>
            /// FilterPattern
            /// A filter pattern for extracting metric data out of ingested log events.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> FilterPattern { get; set; }

            /// <summary>
            /// LogGroupName
            /// The name of an existing log group that you want to associate with this metric filter.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: [\. \-_/#A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// MetricTransformations
            /// The metric transformations.
            /// Required: Yes
            /// Type: List of MetricTransformation
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
			public List<MetricTransformation> MetricTransformations { get; set; }

        }

        public string Type { get; } = "AWS::Logs::MetricFilter";

        public MetricFilterProperties Properties { get; } = new MetricFilterProperties();

    }
}
