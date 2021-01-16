using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.MetricFilter
{
    /// <summary>
    /// AWS::Logs::MetricFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html
    /// </summary>
    public class MetricFilterResource : ResourceBase
    {
        public class MetricFilterProperties
        {
            /// <summary>
            /// FilterPattern
            /// A filter pattern for extracting metric data out of ingested log events. For more information, see
            /// Filter and Pattern Syntax.
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
