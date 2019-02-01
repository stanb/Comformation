using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS AppSync RelationalDatabase RdsHttpEndpointConfig
    /// Use the RdsHttpEndpointConfig property type to specify RdsHttpEndpoint for an AWS AppSync relational database.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-relationaldatabaseconfig-rdshttpendpointconfig.html
    /// </summary>
    public class RdsHttpEndpointConfig
    {

        /// <summary>
        /// AwsRegion
        /// The aws region of the rdshttpendpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegion")]
        public Union<string, IntrinsicFunction> AwsRegion { get; set; }

        /// <summary>
        /// Schema
        /// The schema of the relational database.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schema")]
        public Union<string, IntrinsicFunction> Schema { get; set; }

        /// <summary>
        /// DatabaseName
        /// The name of the relational database.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// DbClusterIdentifier
        /// The database cluster identifier of the rdshttpendpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DbClusterIdentifier")]
        public Union<string, IntrinsicFunction> DbClusterIdentifier { get; set; }

        /// <summary>
        /// AwsSecretStoreArn
        /// The secret store ARN of the rdshttpendpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsSecretStoreArn")]
        public Union<string, IntrinsicFunction> AwsSecretStoreArn { get; set; }

    }
}
