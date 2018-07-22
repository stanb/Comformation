using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition Timeout
    /// The Timeout property type specifies a job timeout configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-timeout.html
    /// </summary>
    public class Timeout
    {

        /// <summary>
        /// AttemptDurationSeconds
        /// The time duration in seconds (measured from the job attempt&#39;s startedAt timestamp) after which AWS
        /// Batch terminates your jobs if they have not finished.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttemptDurationSeconds")]
        public Union<int, IntrinsicFunction> AttemptDurationSeconds { get; set; }

    }
}
