using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore ParquetConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-parquetconfiguration.html
    /// </summary>
    public class ParquetConfiguration
    {

        /// <summary>
        /// SchemaDefinition
        /// Information needed to define a schema.
        /// Required: No
        /// Type: SchemaDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaDefinition")]
        public SchemaDefinition SchemaDefinition { get; set; }

    }
}
