using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Step
{
    /// <summary>
    /// Amazon EMR Step KeyValue
    /// KeyValue is a property of the Amazon EMR Step HadoopJarStepConfig property that specifies key-value pairs,
    /// which are passed to a JAR file that Amazon EMR (Amazon EMR) executes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig-keyvalue.html
    /// </summary>
    public class KeyValue
    {

        /// <summary>
        /// Key
        /// The unique identifier of a key-value pair.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value part of the identified key.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
