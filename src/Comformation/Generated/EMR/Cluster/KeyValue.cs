using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster KeyValue
    /// KeyValue is a subproperty of the HadoopJarStepConfig property type. KeyValue is used to pass parameters to a
    /// step.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-keyvalue.html
    /// </summary>
    public class KeyValue
    {

        /// <summary>
        /// Key
        /// The unique identifier of a key value pair.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 10280
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value part of the identified key.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 10280
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
