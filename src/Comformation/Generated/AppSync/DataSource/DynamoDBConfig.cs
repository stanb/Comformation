using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource DynamoDBConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html
    /// </summary>
    public class DynamoDBConfig
    {

        /// <summary>
        /// TableName
        /// The table name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// AwsRegion
        /// The AWS Region.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegion")]
        public Union<string, IntrinsicFunction> AwsRegion { get; set; }

        /// <summary>
        /// Versioned
        /// Set to TRUE to use Conflict Detection and Resolution with this data source.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Versioned")]
        public Union<bool, IntrinsicFunction> Versioned { get; set; }

        /// <summary>
        /// DeltaSyncConfig
        /// The DeltaSyncConfig for a versioned datasource.
        /// Required: No
        /// Type: DeltaSyncConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeltaSyncConfig")]
        public DeltaSyncConfig DeltaSyncConfig { get; set; }

        /// <summary>
        /// UseCallerCredentials
        /// Set to TRUE to use AWS Identity and Access Management with this data source.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseCallerCredentials")]
        public Union<bool, IntrinsicFunction> UseCallerCredentials { get; set; }

    }
}
