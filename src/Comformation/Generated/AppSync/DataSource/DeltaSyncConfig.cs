using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource DeltaSyncConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-deltasyncconfig.html
    /// </summary>
    public class DeltaSyncConfig
    {

        /// <summary>
        /// BaseTableTTL
        /// The number of minutes an Item is stored in the datasource.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseTableTTL")]
        public Union<string, IntrinsicFunction> BaseTableTTL { get; set; }

        /// <summary>
        /// DeltaSyncTableTTL
        /// The number of minutes a Delta Sync log entry is stored in the Delta Sync table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeltaSyncTableTTL")]
        public Union<string, IntrinsicFunction> DeltaSyncTableTTL { get; set; }

        /// <summary>
        /// DeltaSyncTableName
        /// The Delta Sync table name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeltaSyncTableName")]
        public Union<string, IntrinsicFunction> DeltaSyncTableName { get; set; }

    }
}
