using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition Timeout
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-timeout.html
    /// </summary>
    public class Timeout
    {

        /// <summary>
        /// AttemptDurationSeconds
        /// The time duration in seconds (measured from the job attempt&#39;s startedAt timestamp) after which AWS
        /// Batch terminates your jobs if they have not finished. The minimum value for the timeout is 60
        /// seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttemptDurationSeconds")]
        public Union<int, IntrinsicFunction> AttemptDurationSeconds { get; set; }

    }
}
