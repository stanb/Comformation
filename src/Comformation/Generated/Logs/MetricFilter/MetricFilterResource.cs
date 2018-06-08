using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.MetricFilter
{
    /// <summary>
    /// AWS::Logs::MetricFilter
    /// The AWS::Logs::MetricFilter resource creates a metric filter that describes how Amazon CloudWatch Logs
    /// extracts information from logs that you specify and transforms it into Amazon CloudWatch metrics. If you have
    /// multiple metric filters that are associated with a log group, all the filters are applied to the log streams
    /// in that group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html
    /// </summary>
    public class MetricFilterResource : ResourceBase
    {
        public class MetricFilterProperties
        {
            /// <summary>
            /// FilterPattern
            /// Describes the pattern that CloudWatch Logs follows to interpret each entry in a log. A log entry
            /// might contain fields such as timestamps, IP addresses, error codes, bytes transferred, and so on.
            /// You use the pattern to specify those fields and to specify what to look for in the log file. For
            /// example, if you're interested in error codes that begin with 1234, your filter pattern might be
            /// [timestamps, ip_addresses, error_codes = 1234*, size, . . . ]. For more information, see Filter and
            /// Pattern Syntax in the Amazon CloudWatch User Guide.
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
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// MetricTransformations
            /// Describes how to transform data from a log into a CloudWatch metric.
            /// Required: Yes
            /// Type: A list of CloudWatch Logs MetricFilter MetricTransformation Property
            /// Important Currently, you can specify only one metric transformation for each metric filter. If you
            /// want to specify multiple metric transformations, you must specify multiple metric filters.
            /// Update requires: No interruption
            /// </summary>
			public Union<List<MetricTransformation>, IntrinsicFunction> MetricTransformations { get; set; }

        }
    
        public string Type { get; } = "AWS::Logs::MetricFilter";
        
        public MetricFilterProperties Properties { get; } = new MetricFilterProperties();
    }
}
