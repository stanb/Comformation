using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html
    /// </summary>
    public class FileFormatConfiguration
    {

        /// <summary>
        /// ParquetConfiguration
        /// </summary>
        [JsonProperty("ParquetConfiguration")]
        public ParquetConfiguration ParquetConfiguration { get; set; }

        /// <summary>
        /// JsonConfiguration
        /// </summary>
        [JsonProperty("JsonConfiguration")]
        public JsonConfiguration JsonConfiguration { get; set; }

    }
}
