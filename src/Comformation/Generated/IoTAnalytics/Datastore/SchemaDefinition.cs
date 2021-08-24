using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore SchemaDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-schemadefinition.html
    /// </summary>
    public class SchemaDefinition
    {

        /// <summary>
        /// Columns
        /// Specifies one or more columns that store your data.
        /// Each schema can have up to 100 columns. Each column can have up to 100 nested types.
        /// Required: No
        /// Type: List of Column
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Columns")]
        public List<Column> Columns { get; set; }

    }
}
