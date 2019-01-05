using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS AppSync DataSource RelationalDatabaseConfig
    /// Use the RelationalDatabaseConfig property type to specify RelationalDatabaseConfig for an AWS AppSync data
    /// source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-relationaldatabaseconfig.html
    /// </summary>
    public class RelationalDatabaseConfig
    {

        /// <summary>
        /// RdsHttpEndpointConfig
        /// The information about the rds resource.
        /// Required: No
        /// Type:RdsHttpEndpointConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RdsHttpEndpointConfig")]
        public RdsHttpEndpointConfig RdsHttpEndpointConfig { get; set; }

        /// <summary>
        /// RelationalDatabaseSourceType
        /// The type of the relational datasource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RelationalDatabaseSourceType")]
        public Union<string, IntrinsicFunction> RelationalDatabaseSourceType { get; set; }

    }
}
