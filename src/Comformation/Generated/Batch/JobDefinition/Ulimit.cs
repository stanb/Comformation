using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition Ulimit
    /// The Ulimit property type specifies the ulimits to use in a job definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ulimit.html
    /// </summary>
    public class Ulimit
    {

        /// <summary>
        /// SoftLimit
        /// The soft limit for the ulimit type.
        /// Required: yes
        /// Type: Integer
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("SoftLimit")]
        public Union<int, IntrinsicFunction> SoftLimit { get; set; }

        /// <summary>
        /// HardLimit
        /// The hard limit for the ulimit type.
        /// Required: yes
        /// Type: Integer
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("HardLimit")]
        public Union<int, IntrinsicFunction> HardLimit { get; set; }

        /// <summary>
        /// Name
        /// The type of the ulimit.
        /// Required: yes
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
