using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource TeradataParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-teradataparameters.html
    /// </summary>
    public class TeradataParameters
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
