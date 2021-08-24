using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource PrestoParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-prestoparameters.html
    /// </summary>
    public class PrestoParameters
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

        /// <summary>
        /// Catalog
        /// Catalog.
        /// Required: Yes
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Catalog")]
        public Union<string, IntrinsicFunction> Catalog { get; set; }

    }
}
