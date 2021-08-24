using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore FileFormatConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html
    /// </summary>
    public class FileFormatConfiguration
    {

        /// <summary>
        /// ParquetConfiguration
        /// Contains the configuration information of the Parquet format.
        /// Required: No
        /// Type: ParquetConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParquetConfiguration")]
        public ParquetConfiguration ParquetConfiguration { get; set; }

        /// <summary>
        /// JsonConfiguration
        /// Contains the configuration information of the JSON format.
        /// Required: No
        /// Type: JsonConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonConfiguration")]
        public JsonConfiguration JsonConfiguration { get; set; }

    }
}
