using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource OracleParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-oracleparameters.html
    /// </summary>
    public class OracleParameters
    {

        /// <summary>
        /// Port
        /// Port.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<double, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// Database
        /// Database.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Database")]
        public Union<string, IntrinsicFunction> Database { get; set; }

        /// <summary>
        /// Host
        /// Host.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Host")]
        public Union<string, IntrinsicFunction> Host { get; set; }

    }
}
