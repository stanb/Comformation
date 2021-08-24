using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector AnomalyDetectorConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-anomalydetectorconfig.html
    /// </summary>
    public class AnomalyDetectorConfig
    {

        /// <summary>
        /// AnomalyDetectorFrequency
        /// The frequency at which the detector analyzes its source data.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AnomalyDetectorFrequency")]
        public Union<string, IntrinsicFunction> AnomalyDetectorFrequency { get; set; }

    }
}
