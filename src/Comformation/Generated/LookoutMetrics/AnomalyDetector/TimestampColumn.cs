using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector TimestampColumn
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-timestampcolumn.html
    /// </summary>
    public class TimestampColumn
    {

        /// <summary>
        /// ColumnName
        /// The name of the timestamp column.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnName")]
        public Union<string, IntrinsicFunction> ColumnName { get; set; }

        /// <summary>
        /// ColumnFormat
        /// The format of the timestamp column.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnFormat")]
        public Union<string, IntrinsicFunction> ColumnFormat { get; set; }

    }
}
