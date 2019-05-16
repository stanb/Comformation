using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition SerdeInfo
    /// Information about a serialization/deserialization program (SerDe) that serves as an extractor and loader.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html
    /// </summary>
    public class SerdeInfo
    {

        /// <summary>
        /// Parameters
        /// These key-value pairs define initialization parameters for the SerDe.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// SerializationLibrary
        /// Usually the class that implements the SerDe. An example is org. apache. hadoop. hive. serde2.
        /// columnar. ColumnarSerDe.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SerializationLibrary")]
        public Union<string, IntrinsicFunction> SerializationLibrary { get; set; }

        /// <summary>
        /// Name
        /// Name of the SerDe.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
