using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS Glue Partition SerdeInfo
    /// The SerdeInfo property type specifies information about a serialization/deserialization program (SerDe), which
    /// serves as an extractor and loader for an AWS Glue partition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html
    /// </summary>
    public class SerdeInfo
    {

        /// <summary>
        /// Parameters
        /// UTF-8 string–to–UTF-8 string key-value pairs that specify the initialization parameters for the
        /// SerDe.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// SerializationLibrary
        /// The serialization library. This is usually the class that implements the SerDe, such as org. apache.
        /// hadoop. hive. serde2. columnar. ColumnarSerDe. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SerializationLibrary")]
        public Union<string, IntrinsicFunction> SerializationLibrary { get; set; }

        /// <summary>
        /// Name
        /// The name of the SerDe. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
