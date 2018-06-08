using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition Environment
    /// The Environment property type specifies environment variables to use in a job definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-environment.html
    /// </summary>
    public class Environment
    {

        /// <summary>
        /// Value
        /// The value of the environment variable.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name of the environment variable.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
