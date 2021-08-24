using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource RedshiftParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-redshiftparameters.html
    /// </summary>
    public class RedshiftParameters
    {

        /// <summary>
        /// ClusterId
        /// Cluster ID. This field can be blank if the Host and Port are provided.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClusterId")]
        public Union<string, IntrinsicFunction> ClusterId { get; set; }

        /// <summary>
        /// Port
        /// Port. This field can be blank if the ClusterId is provided.
        /// Required: No
        /// Type: Double
        /// Minimum: 0
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
        /// Host. This field can be blank if ClusterId is provided.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Host")]
        public Union<string, IntrinsicFunction> Host { get; set; }

    }
}
