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
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of MetricStreamFilter
            /// Update requires: No interruption
            /// </summary>
            public List<MetricStreamFilter> ExcludeFilters { get; set; }

            /// <summary>
            /// FirehoseArn
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FirehoseArn { get; set; }

            /// <summary>
            /// IncludeFilters
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of MetricStreamFilter
            /// Update requires: No interruption
            /// </summary>
            public List<MetricStreamFilter> IncludeFilters { get; set; }

            /// <summary>
            /// Name
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoleArn
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// Not currently supported by AWS CloudFormation.
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
