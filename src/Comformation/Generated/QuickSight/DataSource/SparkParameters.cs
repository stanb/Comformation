using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource SparkParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sparkparameters.html
    /// </summary>
    public class SparkParameters
    {

        /// <summary>
        /// Port
        /// Port.
        /// Required: Yes
        /// Type: Double
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<double, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// Host
        /// Host.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Host")]
        public Union<string, IntrinsicFunction> Host { get; set; }

    }
}
