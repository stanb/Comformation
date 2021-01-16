using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource RelationalDatabaseConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-relationaldatabaseconfig.html
    /// </summary>
    public class RelationalDatabaseConfig
    {

        /// <summary>
        /// RdsHttpEndpointConfig
        /// Information about the Amazon RDS resource.
        /// Required: No
        /// Type: RdsHttpEndpointConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RdsHttpEndpointConfig")]
        public RdsHttpEndpointConfig RdsHttpEndpointConfig { get; set; }

        /// <summary>
        /// RelationalDatabaseSourceType
        /// The type of relational data source.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RelationalDatabaseSourceType")]
        public Union<string, IntrinsicFunction> RelationalDatabaseSourceType { get; set; }

    }
}
