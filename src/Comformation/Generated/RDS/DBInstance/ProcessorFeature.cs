using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBInstance
{
    /// <summary>
    /// Amazon RDS DBInstance ProcessorFeature
    /// The ProcessorFeature property type specifies the processor features of a DB instance class status.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbinstance-processorfeature.html
    /// </summary>
    public class ProcessorFeature
    {

        /// <summary>
        /// Name
        /// The name of the processor feature. Valid values are coreCount to specify the number of CPU cores and
        /// threadsPerCore to specify the number of threads per core.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value of a processor feature name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
