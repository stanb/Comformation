using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector RedshiftSourceConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-redshiftsourceconfig.html
    /// </summary>
    public class RedshiftSourceConfig
    {

        /// <summary>
        /// ClusterIdentifier
        /// A string identifying the Redshift cluster.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClusterIdentifier")]
        public Union<string, IntrinsicFunction> ClusterIdentifier { get; set; }

        /// <summary>
        /// DatabaseHost
        /// The name of the database host.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseHost")]
        public Union<string, IntrinsicFunction> DatabaseHost { get; set; }

        /// <summary>
        /// DatabasePort
        /// The port number where the database can be accessed.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabasePort")]
        public Union<int, IntrinsicFunction> DatabasePort { get; set; }

        /// <summary>
        /// SecretManagerArn
        /// The Amazon Resource Name (ARN) of the AWS Secrets Manager role.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretManagerArn")]
        public Union<string, IntrinsicFunction> SecretManagerArn { get; set; }

        /// <summary>
        /// DatabaseName
        /// The Redshift database name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// TableName
        /// The table name of the Redshift database.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the role providing access to the database.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// VpcConfiguration
        /// Contains information about the Amazon Virtual Private Cloud (VPC) configuration.
        /// Required: Yes
        /// Type: VpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcConfiguration")]
        public VpcConfiguration VpcConfiguration { get; set; }

    }
}
