using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource RdsHttpEndpointConfig
    /// Use the RdsHttpEndpointConfig property type to specify RdsHttpEndpoint for an AWS AppSync relational database.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-rdshttpendpointconfig.html
    /// </summary>
    public class RdsHttpEndpointConfig
    {

        /// <summary>
        /// AwsRegion
        /// AWS Region for RDS HTTP endpoint.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegion")]
        public Union<string, IntrinsicFunction> AwsRegion { get; set; }

        /// <summary>
        /// Schema
        /// Logical schema name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schema")]
        public Union<string, IntrinsicFunction> Schema { get; set; }

        /// <summary>
        /// DatabaseName
        /// Logical database name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// DbClusterIdentifier
        /// Amazon RDS cluster identifier.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DbClusterIdentifier")]
        public Union<string, IntrinsicFunction> DbClusterIdentifier { get; set; }

        /// <summary>
        /// AwsSecretStoreArn
        /// AWS secret store ARN for database credentials.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsSecretStoreArn")]
        public Union<string, IntrinsicFunction> AwsSecretStoreArn { get; set; }

    }
}
