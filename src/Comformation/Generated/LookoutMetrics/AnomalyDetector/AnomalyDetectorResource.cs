using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutmetrics-anomalydetector.html
    /// </summary>
    public class AnomalyDetectorResource : ResourceBase
    {
        public class AnomalyDetectorProperties
        {
            /// <summary>
            /// AnomalyDetectorName
            /// The name of the detector.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AnomalyDetectorName { get; set; }

            /// <summary>
            /// AnomalyDetectorDescription
            /// A description of the detector.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AnomalyDetectorDescription { get; set; }

            /// <summary>
            /// AnomalyDetectorConfig
            /// Contains information about the configuration of the anomaly detector.
            /// Required: Yes
            /// Type: AnomalyDetectorConfig
            /// Update requires: No interruption
            /// </summary>
            public AnomalyDetectorConfig AnomalyDetectorConfig { get; set; }

            /// <summary>
            /// MetricSetList
            /// The detector&#39;s dataset.
            /// Required: Yes
            /// Type: List of MetricSet
            /// Update requires: No interruption
            /// </summary>
            public List<MetricSet> MetricSetList { get; set; }

            /// <summary>
            /// KmsKeyArn
            /// The ARN of the KMS key to use to encrypt your data.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyArn { get; set; }

        }

        public string Type { get; } = "AWS::LookoutMetrics::AnomalyDetector";

        public AnomalyDetectorProperties Properties { get; } = new AnomalyDetectorProperties();

    }

    public static class AnomalyDetectorAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
