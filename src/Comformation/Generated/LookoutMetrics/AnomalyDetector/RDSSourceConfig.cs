using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector RDSSourceConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-rdssourceconfig.html
    /// </summary>
    public class RDSSourceConfig
    {

        /// <summary>
        /// DBInstanceIdentifier
        /// A string identifying the database instance.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DBInstanceIdentifier")]
        public Union<string, IntrinsicFunction> DBInstanceIdentifier { get; set; }

        /// <summary>
        /// DatabaseHost
        /// The host name of the database.
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
        /// The name of the RDS database.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// TableName
        /// The name of the table in the database.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the role.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// VpcConfiguration
        /// An object containing information about the Amazon Virtual Private Cloud (VPC) configuration.
        /// Required: Yes
        /// Type: VpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcConfiguration")]
        public VpcConfiguration VpcConfiguration { get; set; }

    }
}
