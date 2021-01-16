using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.AnomalyDetector
{
    /// <summary>
    /// AWS::CloudWatch::AnomalyDetector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html
    /// </summary>
    public class AnomalyDetectorResource : ResourceBase
    {
        public class AnomalyDetectorProperties
        {
            /// <summary>
            /// MetricName
            /// The name of the metric associated with the anomaly detection band.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// Stat
            /// The statistic of the metric associated with the anomaly detection band.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Stat { get; set; }

            /// <summary>
            /// Configuration
            /// Specifies details about how the anomaly detection model is to be trained, including time ranges to
            /// exclude when training and updating the model. The configuration can also include the time zone to
            /// use for the metric.
            /// Required: No
            /// Type: Configuration
            /// Update requires: No interruption
            /// </summary>
            public Configuration Configuration { get; set; }

            /// <summary>
            /// Dimensions
            /// The dimensions of the metric associated with the anomaly detection band.
            /// Required: No
            /// Type: List of Dimension
            /// Update requires: Replacement
            /// </summary>
            public List<Dimension> Dimensions { get; set; }

            /// <summary>
            /// Namespace
            /// The namespace of the metric associated with the anomaly detection band.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Namespace { get; set; }

        }

        public string Type { get; } = "AWS::CloudWatch::AnomalyDetector";

        public AnomalyDetectorProperties Properties { get; } = new AnomalyDetectorProperties();

    }
}
