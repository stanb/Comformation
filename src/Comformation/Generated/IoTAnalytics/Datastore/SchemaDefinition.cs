using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-schemadefinition.html
    /// </summary>
    public class SchemaDefinition
    {

        /// <summary>
        /// Columns
        /// </summary>
        [JsonProperty("Columns")]
        public List<Column> Columns { get; set; }

    }
}
