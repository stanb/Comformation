using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource SnowflakeParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-snowflakeparameters.html
    /// </summary>
    public class SnowflakeParameters
    {

        /// <summary>
        /// Warehouse
        /// Warehouse.
        /// Required: Yes
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Warehouse")]
        public Union<string, IntrinsicFunction> Warehouse { get; set; }

        /// <summary>
        /// Database
        /// Database.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Database")]
        public Union<string, IntrinsicFunction> Database { get; set; }

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
