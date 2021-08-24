using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.CustomMetric
{
    /// <summary>
    /// AWS::IoT::CustomMetric
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-custommetric.html
    /// </summary>
    public class CustomMetricResource : ResourceBase
    {
        public class CustomMetricProperties
        {
            /// <summary>
            /// MetricName
            /// The name of the custom metric. This will be used in the metric report submitted from the
            /// device/thing. It shouldn&#39;t begin with aws:. Cannot be updated once it&#39;s defined.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// DisplayName
            /// Field that represents a friendly name in the console for the custom metric; it doesn&#39;t have to be
            /// unique. Don&#39;t use this name as the metric identifier in the device metric report. Can be updated.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// MetricType
            /// The type of the custom metric. Types include string-list, ip-address-list, number-list, and number.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MetricType { get; set; }

            /// <summary>
            /// Tags
            /// Metadata that can be used to manage the custom metric.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoT::CustomMetric";

        public CustomMetricProperties Properties { get; } = new CustomMetricProperties();

    }

    public static class CustomMetricAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MetricArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("MetricArn");
    }
}
